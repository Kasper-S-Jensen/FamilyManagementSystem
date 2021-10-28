using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoProject.Models;

namespace TodoProject.Data
{
    public interface ITodoData
    {
        Task<IList<Todo>> GetTodosAsync();
        Task AddTodoAsync(Todo todo);
        Task RemoveTodoAsync(int todoId);
        Task UpdateAsync(Todo todo);
        Task<Todo> GetAsync(int id);
    }
}