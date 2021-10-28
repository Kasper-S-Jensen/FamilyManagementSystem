using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodosWebAPI.Data;
using TodosWebAPI.Models;

namespace TodosWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : ControllerBase
    {
        private ITodoData TodoData;
        private IList<Todo> todos;

        public TodosController(ITodoData todoData)
        {
            TodoData = todoData;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Todo>>> GetTodos([FromQuery] bool? IsCompleted, [FromQuery] int? UserId)
        {
            try
            {
                todos = TodoData.GetTodos();
                if (IsCompleted != null)
                {
                    todos = todos.Where(todo => todo.IsCompleted == IsCompleted).ToList();
                }

                if (UserId != null)
                {
                    todos = todos.Where(todo => todo.UserID == UserId).ToList();
                }

                return Ok(todos);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        [HttpGet ("{id:int}")]
        public async Task<ActionResult<Todo>> GetTodo([FromRoute] int id)
        {
            try
            {
                Todo todo;

                todo = TodoData.Get(id);
            

                return Ok(todo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Todo>> AddTodo([FromBody] Todo todo)
        {
            try
            {
                TodoData.AddTodo(todo);
                return Created($"/{todo.TodoID}", todo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete ("{id:int}")]
        public async Task<ActionResult<Todo>> RemoveTodo([FromRoute] int id)
        {
            try
            {
                TodoData.RemoveTodo(id);
                
                return Ok(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPatch("{id:int}")]
        public async Task<ActionResult<Todo>> UpdateTodo([FromBody] Todo todo)
        {
            try
            {
                TodoData.Update(todo);
                return Created($"/{todo.TodoID}", todo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}