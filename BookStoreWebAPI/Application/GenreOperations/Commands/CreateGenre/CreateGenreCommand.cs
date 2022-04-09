using BookStoreWebAPI.DBOperations;
using BookStoreWebAPI.Entities;
using System;
using System.Linq;

namespace BookStoreWebAPI.Application.GenreOperations.Commands
{
    public class CreateGenreCommand
    {

        public CreateGenreModel Model { get; set; }
        private readonly IBookStoreDbContext _context;

        public CreateGenreCommand(IBookStoreDbContext context)
        {
            _context = context;
        }


        public void Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.Name == Model.Name);
            if (genre is null)
                throw new InvalidOperationException("kitap turu zaten mevcut");

            genre = new Genre();
            genre.Name = Model.Name;
            _context.Genres.Add(genre);

            _context.SaveChanges();

        }

    }


    public class CreateGenreModel
    {
        public string Name { get; set; }
    }


}
