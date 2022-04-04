using Microsoft.EntityFrameworkCore;
using BookStoreWebAPI.DBOperations;
using BookStoreWebAPI.Entities;

namespace BookStoreWebAPI.DBOperations
{
    public class BookStoreDbContext :DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {

        }

        
        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}
