using AutoMapper;
using BookStoreWebAPI.Application.GenreOperations.Queries.GetGenreDetail;
using BookStoreWebAPI.Application.GenreOperations.Queries.GetGenres;
using BookStoreWebAPI.BookOperations.GetBookDetail;
using BookStoreWebAPI.BookOperations.GetBooks;
using BookStoreWebAPI.Cammon;
using BookStoreWebAPI.Entities;
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
            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();

        }
    }
}
