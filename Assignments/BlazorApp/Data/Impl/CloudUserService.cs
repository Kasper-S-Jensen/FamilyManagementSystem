using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorApp.Models;

namespace BlazorApp.Data.Impl
{
    public class CloudUserService : IUserService
    {
        private string path = "https://localhost:5003";
        public async Task<User> ValidateUserAsync(string username, string Password)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{path}/User?username={username}&password={Password}");

            Console.WriteLine("repons" +responseMessage);
            if (!responseMessage.IsSuccessStatusCode)
            {
                var errResponse = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(errResponse);
                throw new Exception(errResponse);
            }

            string result = await responseMessage.Content.ReadAsStringAsync();
            
            Console.WriteLine("result: "+result);
            User user = JsonSerializer.Deserialize<User>(result,
                new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});

            return user;
        }
    }
}