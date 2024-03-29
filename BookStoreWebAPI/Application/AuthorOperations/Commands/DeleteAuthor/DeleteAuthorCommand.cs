﻿using BookStoreWebAPI.DBOperations;
using System;
using System.Linq;

namespace BookStoreWebAPI.Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        public int AuthorId { get; set; }

        private readonly IBookStoreDbContext _context;

        public DeleteAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
        }


        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
                throw new InvalidOperationException("Yazar bulunamadı");

            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}
