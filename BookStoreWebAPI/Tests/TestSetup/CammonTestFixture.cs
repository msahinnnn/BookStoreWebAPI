﻿using AutoMapper;
using BookStoreWebAPI.AutoMapper;
using BookStoreWebAPI.DBOperations;
using Microsoft.EntityFrameworkCore;

namespace BookStoreWebAPI.Tests.TestSetup
{
    public class CammonTestFixture
    {

        public BookStoreDbContext Context { get; set; }
        public IMapper Mapper { get; set; } 
        public CammonTestFixture()
        {
            var options = new DbContextOptionsBuilder<BookStoreDbContext>().UseInMemoryDatabase(databaseName:"BookStoreTestDB").Options;  
            Context = new BookStoreDbContext(options);
           
            Context.Database.EnsureCreated();
            Context.AddBooks();
            Context.AddGenres();
            Context.AddAuthors();
            Context.SaveChanges();

            Mapper = new MapperConfiguration(cfg => { cfg.AddProfile<MappingProfile>(); }).CreateMapper();
        
        }







    }
}
