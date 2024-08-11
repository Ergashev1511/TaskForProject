using TaskForProject.Api.Models;

namespace TaskForProject.Api.Repositories.IRepository
{
    public interface IBook1Repository
    {
        public Task<Book1>  AddAsync(Book1 book1);
        public Task<List<Book1>> GetAllAsync();
    }
}
