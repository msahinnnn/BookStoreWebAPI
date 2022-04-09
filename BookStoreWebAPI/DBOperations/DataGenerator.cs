using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using BookStoreWebAPI.DBOperations;
using BookStoreWebAPI.Entities;

namespace BookStoreWebAPI.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Authors.AddRange(
                    new Author
                    {
                        Name = "J.R.R.",
                        Surname = "Tolkien",
                        BirthDate = new DateTime(1911, 06, 12)
                    },
                    new Author 
                    {
                        Name = "Charlotte Perkins",
                        Surname = "Gilman",
                        BirthDate = new DateTime(1923, 05, 05)
                    },
                    new Author
                    {
                        Name = "Frank Patrick",
                        Surname = "Herbert",
                        BirthDate = new DateTime(1930, 01, 10)
                    }
                    );

                context.Genres.AddRange(
                    new Genre
                    {
                        Name = "Personal Growth"
                    },
                    new Genre
                    {
                        Name = "Science Fiction"
                    },
                    new Genre
                    {
                        Name = "Noval"
                    }
                    );


                context.Books.AddRange(
                    new Book
                    {
                        //Id = 1,
                        Title = "LOrd of The Rings",
                        GenreId = 1, //Pernonal Growth
                        AuthorId = 1,
                        PageCount = 200,
                        PublishDate = new DateTime(2001, 06, 12)
                    },
                    new Book
                    {
                        //Id = 2,
                        Title = "Herland",
                        GenreId = 2, //Science Fiction
                        AuthorId = 2,
                        PageCount = 250,
                        PublishDate = new DateTime(2010, 05, 23)
                    },
                    new Book
                    {
                        //Id = 3,
                        Title = "Dune",
                        GenreId = 2, //Science Fiction
                        AuthorId = 3,
                        PageCount = 540,
                        PublishDate = new DateTime(2001, 12, 21)
                    }
                );

                
                context.SaveChanges();

            }
        }
    }
}
