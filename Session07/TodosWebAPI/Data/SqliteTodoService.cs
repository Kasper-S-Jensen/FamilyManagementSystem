using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TodosWebAPI.DataAccess;
using TodosWebAPI.Models;

namespace TodosWebAPI.Data
{
    public class SqliteTodoService : ITodoData
    {
        private TodoDBContext todoDbContext;
        
        public SqliteTodoService(TodoDBContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }
        
            

        public async Task<IList<Todo>> GetTodosAsync()
        {
            return await todoDbContext.Todos.ToListAsync();
        }

        public async Task<Todo> AddTodoAsync(Todo todo)
        {
           EntityEntry<Todo> newlyAdded = await todoDbContext.AddAsync(todo);
           await todoDbContext.SaveChangesAsync();
           return newlyAdded.Entity;
        }

        public async Task RemoveTodoAsync(int todoId)
        {
            Todo toRemove = await todoDbContext.Todos.FirstOrDefaultAsync(todo => todo.TodoID == todoId);
            if (toRemove!=null)
            {
                todoDbContext.Remove(todoId);
               await todoDbContext.SaveChangesAsync();
            }
        }

        public async Task<Todo> UpdateAsync(Todo todo)
        {
            try
            {
                Todo toUpdate = await todoDbContext.Todos.FirstAsync(t => t.TodoID == todo.TodoID);
                toUpdate.IsCompleted = todo.IsCompleted;
                todoDbContext.Update(toUpdate);
                await todoDbContext.SaveChangesAsync();
                return toUpdate;
            }
            catch (Exception e)
            {
                throw new Exception($"Did not find todo with id{todo.TodoID}");
            }
        }

        public Task<Todo> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}