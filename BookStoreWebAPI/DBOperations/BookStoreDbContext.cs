using Microsoft.EntityFrameworkCore;
using BookStoreWebAPI.DBOperations;
namespace BookStoreWebAPI.DBOperations
{
    public class BookStoreDbContext :DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {

        }

        
        public DbSet<Book> Books { get; set; }
    }
}
