using BookStoreWebAPI.DBOperations;
using System;
using System.Linq;

namespace BookStoreWebAPI.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand
    {
        private readonly IBookStoreDbContext _context;
        public int AuthorId { get; set; }
        public UpdateAuthorModel Model { get; set; }


        public UpdateAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
        }


        public void Handle()
        {

            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
                throw new InvalidOperationException("boyle bir yazar yok");

            if (_context.Authors.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Id != AuthorId))
                throw new InvalidOperationException("aynı isimli bir yazar zaten mevcut");



            author.Name = String.IsNullOrEmpty(Model.Name.Trim()) ? author.Name : Model.Name;
            _context.SaveChanges();
        }

    }

    public class UpdateAuthorModel
    {
        public string Name { get; set; }

    }
}

