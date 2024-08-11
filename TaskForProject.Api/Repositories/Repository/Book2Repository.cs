using Microsoft.EntityFrameworkCore;
using TaskForProject.Api.Dbcontext;
using TaskForProject.Api.Models;
using TaskForProject.Api.Repositories.IRepository;

namespace TaskForProject.Api.Repositories.Repository
{
    public class Book2Repository : IBook2Repository
    {
        private readonly AppDbContext _context;

        public Book2Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Book2> AddAsync(Book2 book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));

            await _context.book2s.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<List<Book2>> GetAllAsync()
        {
            return await _context.book2s.Where(a=>a.Id>0).ToListAsync();
        }
    }
}
