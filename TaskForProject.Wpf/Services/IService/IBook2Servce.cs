using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForProject.Api.Models;

namespace TaskForProject.Wpf.Services.IService
{
    public interface IBook2Servce
    {
        public Task<bool> CraateBook2(Book2 book2);
        public Task<List<Book2>> GetAllBook2();
    }
}
