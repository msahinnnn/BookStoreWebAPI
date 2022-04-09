using AutoMapper;
using BookStoreWebAPI.DBOperations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BookStoreWebAPI.Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQuery
    {
        public int AuthorId { get; set; }
        public readonly IBookStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetAuthorDetailQuery(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public AuthorDetailViewModel Handle()
        {

            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);

            if (author is null)
                throw new InvalidOperationException("yazar turu bulunamadı");
            return _mapper.Map<AuthorDetailViewModel>(author); 


        }

    }

    public class AuthorDetailViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}

