using TaskForProject.Api.Models;

namespace TaskForProject.Api.Services.IServices
{
    public interface IBook2Service
    {
        public Task<Book2> CreateBook2(Book2 book);
        public Task<List<Book2>> GetAllBook2();
    }
}
