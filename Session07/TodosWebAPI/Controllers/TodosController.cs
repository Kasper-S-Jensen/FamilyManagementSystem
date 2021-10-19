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

        public TodosController(ITodoData todoData)
        {
            TodoData = todoData;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Todo>>> GetTodos([FromQuery] bool? IsCompleted, [FromQuery] int? UserId)
        {
            try
            {
                IList<Todo> todos = TodoData.GetTodos();
                if (IsCompleted!=null)
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
    }
}