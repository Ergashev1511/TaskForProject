using TaskForProject.Api.Models;
using TaskForProject.Api.Repositories.IRepository;
using TaskForProject.Api.Services.IServices;

namespace TaskForProject.Api.Services.Services
{
    public class Book1Service : IBook1Services
    {
        private readonly IBook1Repository _repository;

        public Book1Service(IBook1Repository repository)
        {
            _repository = repository;
        }

        public async Task<Book1> CreateBook1(Book1 book1)
        {
            if (book1 == null) throw new ArgumentNullException(nameof(book1));

            var newbook1 = new Book1()
            {
                Author = book1.Author,
                BookName = book1.BookName,
                Year = book1.Year,
                Description = book1.Description,
            };
             await _repository.AddAsync(newbook1);
            return newbook1;
        }

        public async Task<List<Book1>> GetAllBook1()
        {
           var book1s=await _repository.GetAllAsync();
            if(book1s != null && book1s.Any())
            {
                return book1s.Select(book => new Book1()
                {
                    Id = book.Id,
                    BookName = book.BookName,
                    Year = book.Year,
                    Description = book.Description,
                    Author = book.Author,
                }).ToList();
            }
            return new List<Book1>();
        }
    }
}
