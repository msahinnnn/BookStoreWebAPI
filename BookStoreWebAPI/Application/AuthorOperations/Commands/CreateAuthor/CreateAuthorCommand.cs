using AutoMapper;
using BookStoreWebAPI.DBOperations;
using BookStoreWebAPI.Entities;
using System;
using System.Linq;

namespace BookStoreWebAPI.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommand
    {

        public CreateAuthorModel Model { get; set; }
        private readonly IBookStoreDbContext _context;
       

        public CreateAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
            
        }


        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Name == Model.Name);
            if (author is null)
                throw new InvalidOperationException("yazar zaten mevcut");

            author = new Author();
            author.Name = Model.Name;
            _context.Authors.Add(author);

            _context.SaveChanges();

        }

    }


    public class CreateAuthorModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

}
