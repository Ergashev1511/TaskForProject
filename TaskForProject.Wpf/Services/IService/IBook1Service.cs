using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForProject.Api.Models;

namespace TaskForProject.Wpf.Services.IService
{
    public interface IBook1Service
    {
    public Task<bool>  CreateBook1(Book1 book1);
        public Task<List<Book1>> GetAllBook1();
    }
}
