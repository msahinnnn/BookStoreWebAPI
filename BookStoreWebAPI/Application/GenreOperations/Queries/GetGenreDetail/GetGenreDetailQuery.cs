﻿using AutoMapper;
using BookStoreWebAPI.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreWebAPI.Application.GenreOperations.Queries.GetGenreDetail
{
    public class GetGenreDetailQuery
    {
        public int GenreId { get; set; }
        public readonly IBookStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetGenreDetailQuery(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public GenreDetailViewModel Handle()
        {

            var genre = _context.Genres.SingleOrDefault(x => x.IsActive && x.Id == GenreId);

            if (genre is null)
                throw new InvalidOperationException("kitap turu bulunamadı");
            return _mapper.Map<GenreDetailViewModel>(genre); ;


        }

    }

    public class GenreDetailViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

}
