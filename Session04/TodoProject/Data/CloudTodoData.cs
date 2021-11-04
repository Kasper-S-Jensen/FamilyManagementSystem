using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TodoProject.Models;

namespace TodoProject.Data
{
    public class CloudTodoData : ITodoData
    {
        private string path = "https://localhost:5003";

        public async Task<IList<Todo>> GetTodosAsync()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{path}/Todos");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            string result = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            List<Todo> todos = JsonSerializer.Deserialize<List<Todo>>(result);
            foreach (var todo in todos)
            {
                Console.WriteLine(todo.TodoID);
                Console.WriteLine(todo.Title);
            }
            return todos;
        }

        public async Task AddTodoAsync(Todo todo)
        {
            using HttpClient client = new HttpClient();
            string todoAsJson = JsonSerializer.Serialize(todo);
            StringContent content = new StringContent(todoAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response =
                await client.PostAsync($"{path}/Todos", content);
            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
        }

        public async Task RemoveTodoAsync(int todoId)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync($"{path}/Todos/{todoId}");
            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
        }

        public async Task UpdateAsync(Todo todo)
        {
            using HttpClient client = new HttpClient();
            string todoAsJson = JsonSerializer.Serialize(todo);
            Console.WriteLine(todoAsJson);
            HttpContent content = new StringContent(todoAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PatchAsync($"{path}/todos/{todo.TodoID}", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<Todo> GetAsync(int id)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{path}/Todos/{id}");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            string result = await responseMessage.Content.ReadAsStringAsync();

            Todo todo = JsonSerializer.Deserialize<Todo>(result,
                new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});

            return todo;
        }
    }
}