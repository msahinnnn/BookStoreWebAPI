using AutoMapper;
using BookStoreWebAPI.Application.AuthorOperations.Queries.GetAuthorDetail;
using BookStoreWebAPI.Application.AuthorOperations.Queries.GetAuthors;
using BookStoreWebAPI.Application.GenreOperations.Queries.GetGenreDetail;
using BookStoreWebAPI.Application.GenreOperations.Queries.GetGenres;
using BookStoreWebAPI.BookOperations.GetBookDetail;
using BookStoreWebAPI.BookOperations.GetBooks;
using BookStoreWebAPI.Entities;
using static BookStoreWebAPI.Application.AuthorOperations.Commands.CreateAuthor.CreateAuthorCommand;
using static BookStoreWebAPI.BookOperations.CreateBookCommand;

namespace BookStoreWebAPI.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateDetailViewModel, Book>();
            CreateMap<Book, BookDetailViewModel>().ForMember(dest => dest.Genre, opt =>opt.MapFrom(src => src.Genre.Name));
            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name));
            CreateMap<Book, BookDetailViewModel>().ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name));
            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name));

            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();

            CreateMap<Author, AuthorsViewModel>();
            CreateMap<Author, AuthorDetailViewModel>();

        }
    }
}
