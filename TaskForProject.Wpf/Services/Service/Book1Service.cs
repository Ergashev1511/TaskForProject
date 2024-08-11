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
    public class Book1Service : IBook1Service
    {
        public async Task<bool> CreateBook1(Book1 book1)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, Auth.BASE_URL + "/api/Book1/CreateBook1");
                var content = new MultipartFormDataContent();

                content.Add(new StringContent(book1.BookName), "BookName");
                content.Add(new StringContent(book1.Author), "Author");
                content.Add(new StringContent(book1.Description), "Description");
                content.Add(new StringContent(book1.Year), "Year");

                request.Content = content;

                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    return true;
                }
                return false;
            }
            catch 
            { 
                return false;
            }
        }

        public async Task<List<Book1>> GetAllBook1()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri($"{Auth.BASE_URL}" + $"/api/Book1/GetAllBook1");
                HttpResponseMessage message = await client.GetAsync(client.BaseAddress);
                string response = await message.Content.ReadAsStringAsync();
                List<Book1> posts = JsonConvert.DeserializeObject<List<Book1>>(response)!;

                return posts;
            }
            catch
            {
                return new List<Book1>();
            }
        }
    }
}
