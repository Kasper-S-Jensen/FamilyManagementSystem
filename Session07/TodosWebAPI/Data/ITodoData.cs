using System.Collections.Generic;
using System.Threading.Tasks;
using TodosWebAPI.Models;

namespace TodosWebAPI.Data
{
    public interface ITodoData
    {
        Task<IList<Todo>> GetTodosAsync();
        Task<Todo> AddTodoAsync(Todo todo);
        Task RemoveTodoAsync(int todoId);
        Task<Todo> UpdateAsync(Todo todo);
        Task<Todo> GetAsync(int id);
    }
}