using TaskForProject.Api.Models;

namespace TaskForProject.Api.Repositories.IRepository
{
    public interface IBook2Repository
    {
        public Task<Book2> AddAsync(Book2 book);
        public Task<List<Book2>> GetAllAsync();
    }
}
