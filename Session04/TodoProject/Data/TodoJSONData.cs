using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TodoProject.Models;

namespace TodoProject.Data
{
    public class TodoJSONData : ITodoData
    {
        private string todoFile = "todos.json";
        private IList<Todo> todos;


        public TodoJSONData()
        {
            if (!File.Exists(todoFile))
            {
                Seed();
                WriteTodosToFile();
            }
            else
            {
                string content = File.ReadAllText(todoFile);
                todos = JsonSerializer.Deserialize<List<Todo>>(content);
            }
        }

        public async Task<IList<Todo>> GetTodosAsync()
        {
            List<Todo> todolist = new List<Todo>(todos);
            return todolist;
        }

        public async Task AddTodoAsync(Todo todo)
        {
            int max = todos.Max(todo => todo.TodoID);
            todo.TodoID = (++max);
            todos.Add(todo);
            WriteTodosToFile();
        }

        public async Task RemoveTodoAsync(int todoId)
        {
            Todo toRemove = todos.First(t => t.TodoID == todoId);
            todos.Remove(toRemove);
            WriteTodosToFile();
        }

        public async Task UpdateAsync(Todo todo)
        {
            Todo toUpdate = todos.First(t => t.TodoID == todo.TodoID);
            toUpdate.IsCompleted = todo.IsCompleted;
            toUpdate.Title = todo.Title;
            WriteTodosToFile();
        }

        /*public async Task GetAAsync(int id)
        {
            
            return todos.FirstOrDefault(t => t.TodoID == id);
        }*/

        private void WriteTodosToFile()
        {
            string todosAsJson = JsonSerializer.Serialize(todos);
            File.WriteAllText(todoFile, todosAsJson);
        }

        private void Seed()
        {
            Todo[] ts =
            {
                new Todo {UserID = 1, TodoID = 1, Title = "Do dishes", IsCompleted = false},
                new Todo {UserID = 1, TodoID = 2, Title = "Walk the dog", IsCompleted = false},
                new Todo {UserID = 2, TodoID = 3, Title = "Do DNP homework", IsCompleted = true},
                new Todo {UserID = 3, TodoID = 4, Title = "Eat breakfast", IsCompleted = false},
                new Todo {UserID = 4, TodoID = 5, Title = "Mow lawn", IsCompleted = true},
            };

            todos = ts.ToList();
        }
    }
}