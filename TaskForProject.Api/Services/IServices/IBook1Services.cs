using TaskForProject.Api.Models;

namespace TaskForProject.Api.Services.IServices
{
    public interface IBook1Services
    {
        public Task<Book1>  CreateBook1(Book1 book1);
        public Task<List<Book1>> GetAllBook1();
    }
}
