﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorApp.Models;

namespace BlazorApp.Data.Impl
{
    public class CloudFamilyData : IFamilyData
    {
        private string path = "https://localhost:5003";
        
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{path}/Adults");

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errResponse = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(errResponse);
                throw new Exception(errResponse);
                
            }
            string result = await responseMessage.Content.ReadAsStringAsync();

            List<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(result,
                new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});

            return adults;
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{path}/Families");

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errResponse = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(errResponse);
                throw new Exception(errResponse);
                
            }
            string result = await responseMessage.Content.ReadAsStringAsync();

            IList<Family> families = JsonSerializer.Deserialize<List<Family>>(result,
                new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});

            return families;
        }

        public async Task<IList<Child>> GetChildrenAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task AddFamilyAsync(Family family)
        {
            using HttpClient client = new HttpClient();
            string todoAsJson = JsonSerializer.Serialize(family);
            StringContent content = new StringContent(todoAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response =
                await client.PostAsync($"{path}/Families", content);
            if (!response.IsSuccessStatusCode)
            {
                var errResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine(errResponse);
                throw new Exception(errResponse);
                
            }
        }

        public async Task AddAdultAsync(Family family)
        {
            using HttpClient client = new HttpClient();
            string todoAsJson = JsonSerializer.Serialize(family);
            StringContent content = new StringContent(todoAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response =
                await client.PostAsync($"{path}/Adults", content);
            if (!response.IsSuccessStatusCode)
            {
                var errResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine(errResponse);
                throw new Exception(errResponse);
                
            }
        }

        public async Task RemoveAdultAsync(int ID)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync($"{path}/Adults/{ID}");
            if (!response.IsSuccessStatusCode)
            {
                var errResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine(errResponse);
                throw new Exception(errResponse);
                
            }
        }

        public async Task RemoveFamilyAsync(string streetName, int houseNumber)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync($"{path}/Families/{streetName}/{houseNumber}");
            if (!response.IsSuccessStatusCode)
            {
                var errResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine(errResponse);
                throw new Exception(errResponse);
                
            }
        }

        public async Task UpdateAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateAsync(Family family)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Family> GetFamilyAsync(string streetName, int houseNumber)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"{path}/Families/{streetName}{houseNumber}");

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errResponse = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(errResponse);
                throw new Exception(errResponse);
                
            }
            string result = await responseMessage.Content.ReadAsStringAsync();

            Family family = JsonSerializer.Deserialize<Family>(result,
                new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});

            return family;
        }
    }
}