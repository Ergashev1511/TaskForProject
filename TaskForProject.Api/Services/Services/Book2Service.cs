using TaskForProject.Api.Models;
using TaskForProject.Api.Repositories.IRepository;
using TaskForProject.Api.Services.IServices;

namespace TaskForProject.Api.Services.Services
{
    public class Book2Service : IBook2Service
    {
        private readonly IBook2Repository _repository;
        public Book2Service(IBook2Repository repository)
        {
            _repository = repository;
        }

        public async Task<Book2> CreateBook2(Book2 book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));

            var newbook2=new Book2()
            {
                Author = book.Author,
                BookName=book.BookName,
                Description=book.Description,
                Year=book.Year,
            };
            await _repository.AddAsync(newbook2);
            return newbook2;

        }

        public async Task<List<Book2>> GetAllBook2()
        {
            var books = await _repository.GetAllAsync();
            if (books != null && books.Any())
            {
                return books.Select(book => new Book2()
                {
                    Id = book.Id,
                    BookName = book.BookName,
                    Author = book.Author,
                    Description = book.Description,
                    Year = book.Year,

                }).ToList();
            }
            return new List<Book2>();
        }
    }
}
