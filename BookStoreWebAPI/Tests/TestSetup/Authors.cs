using BookStoreWebAPI.DBOperations;
using BookStoreWebAPI.Entities;
using System;

namespace BookStoreWebAPI.Tests.TestSetup
{
    public static class Authors
    {
        public static void AddAuthors(this BookStoreDbContext context)
        {
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
        }
    }
}
