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
        private string path = "https://localhost:5001";

        public async Task<IList<Todo>> GetTodosAsync()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{path}/Todos");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception(@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            string result = await responseMessage.Content.ReadAsStringAsync();

            List<Todo> todos = JsonSerializer.Deserialize<List<Todo>>(result,
                new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});

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
                throw new Exception(@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }

        public Task RemoveTodoAsync(int todoId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Todo todo)
        {
            throw new System.NotImplementedException();
        }
    }
}