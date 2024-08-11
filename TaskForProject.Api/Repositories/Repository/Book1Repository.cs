using Microsoft.EntityFrameworkCore;
using TaskForProject.Api.Dbcontext;
using TaskForProject.Api.Models;
using TaskForProject.Api.Repositories.IRepository;

namespace TaskForProject.Api.Repositories.Repository
{
    public class Book1Repository : IBook1Repository
    {
        private readonly AppDbContext _context;
        public Book1Repository(AppDbContext context)
        {
            _context = context;   
        }

        public async Task<Book1> AddAsync(Book1 book1)
        {
            if (book1 == null) throw new ArgumentNullException(nameof(book1));

            await _context.book1s.AddAsync(book1);
            await _context.SaveChangesAsync();
            return book1;
        }

        public async Task<List<Book1>> GetAllAsync()
        {
            return await _context.book1s.Where(a=>a.Id>0).ToListAsync();
        }
    }
}
