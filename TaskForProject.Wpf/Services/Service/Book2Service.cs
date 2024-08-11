using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TaskForProject.Api.Models;
using TaskForProject.Wpf.Api;
using TaskForProject.Wpf.Services.IService;

namespace TaskForProject.Wpf.Services.Service
{
    public class Book2Service : IBook2Servce
    {
        public async Task<bool> CraateBook2(Book2 book2)
        {
            try
            {
                //var client = new HttpClient();
                //var request = new HttpRequestMessage(HttpMethod.Post, Auth.BASE_URL + "/api/Book2/CreateBook2");
                //var content = new MultipartFormDataContent();

                //content.Add(new StringContent(book2.BookName), "BookName");
                //content.Add(new StringContent(book2.Author), "Author");
                //content.Add(new StringContent(book2.Description), "Description");
                //content.Add(new StringContent(book2.Year), "Year");

                //request.Content = content;

                //var response = await client.SendAsync(request);
                //if (response.IsSuccessStatusCode)
                //{
                //    var res = await response.Content.ReadAsStringAsync();
                //    return true;
                //}
                //return false;
                var client = new HttpClient();
                var jsonContent = JsonSerializer.Serialize(book2);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(Auth.BASE_URL + "/api/Book2/CreateBook2", content);
                var res = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response: {res}");



                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Book2>> GetAllBook2()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri($"{Auth.BASE_URL}" + $"/api/Book2/GetAllBook2");
                HttpResponseMessage message = await client.GetAsync(client.BaseAddress);
                string response = await message.Content.ReadAsStringAsync();
                List<Book2> posts = JsonConvert.DeserializeObject<List<Book2>>(response)!;

                return posts;
            }
            catch
            {
                return new List<Book2>();
            }
        }
    }
}
