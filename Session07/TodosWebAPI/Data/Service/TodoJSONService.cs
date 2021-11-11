using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TodosWebAPI.Models;

namespace TodosWebAPI.Data
{
    public class TodoJsonService : ITodoService
    {
        private string todoFile = "todos.json";
        private IList<Todo> todos;


        public TodoJsonService()
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

        public IList<Todo> GetTodos()
        {
            List<Todo> todolist = new List<Todo>(todos);
            return todolist;
        }

        public void AddTodo(Todo todo)
        {
            int max = todos.Max(todo => todo.TodoID);
            todo.TodoID = (++max);
            todos.Add(todo);
            WriteTodosToFile();
        }

        public void RemoveTodo(int todoId)
        {
            Todo toRemove = todos.First(t => t.TodoID == todoId);
            todos.Remove(toRemove);
            WriteTodosToFile();
        }

        public void Update(Todo todo)
        {
            Todo toUpdate = todos.First(t => t.TodoID == todo.TodoID);
            toUpdate.IsCompleted = todo.IsCompleted;
            toUpdate.Title = todo.Title;
            WriteTodosToFile();
        }

        public Todo Get(int id)
        {
            return todos.FirstOrDefault(t => t.TodoID == id);
        }

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
                new Todo {UserID = 1, TodoID = 3, Title = "Walk the cat", IsCompleted = true},
                new Todo {UserID = 1, TodoID = 4, Title = "Walk the fish", IsCompleted = true},
                new Todo {UserID = 2, TodoID = 5, Title = "Do DNP homework", IsCompleted = true},
                new Todo {UserID = 3, TodoID = 6, Title = "Eat breakfast", IsCompleted = false},
                new Todo {UserID = 4, TodoID = 7, Title = "Mow lawn", IsCompleted = true},
            };

            todos = ts.ToList();
        }

        public Task<IList<Todo>> GetTodosAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Todo> AddTodoAsync(Todo todo)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveTodoAsync(int todoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Todo> UpdateAsync(Todo todo)
        {
            throw new System.NotImplementedException();
        }

        public Task<Todo> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}