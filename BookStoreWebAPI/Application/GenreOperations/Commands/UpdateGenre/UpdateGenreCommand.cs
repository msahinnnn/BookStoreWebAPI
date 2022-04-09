using BookStoreWebAPI.DBOperations;
using System;
using System.Linq;

namespace BookStoreWebAPI.Application.GenreOperations.Commands.UpdateGenre
{
    public class UpdateGenreCommand
    {
        private readonly IBookStoreDbContext _context;
        public int GenreId { get; set; }
        public UpdateGenreModel Model { get; set; }


        public UpdateGenreCommand(IBookStoreDbContext context)
        {
            _context = context;
        }


        public void Handle()
        {

            var genre = _context.Genres.SingleOrDefault(x => x.Id == GenreId);
            if (genre is null)
                throw new InvalidOperationException("boyle bir tur yok");

            if (_context.Genres.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Id != GenreId))
                throw new InvalidOperationException("aynı isimli bir kitap turu zaten mevcut");



            genre.Name = String.IsNullOrEmpty(Model.Name.Trim()) ? genre.Name : Model.Name; 
            genre.IsActive = Model.IsActive;
            _context.SaveChanges();
        }

    }

    public class UpdateGenreModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
