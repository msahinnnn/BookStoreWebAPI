using AutoMapper;
using BookStoreWebAPI.BookOperations.GetBookDetail;
using BookStoreWebAPI.BookOperations.GetBooks;
using BookStoreWebAPI.Cammon;
using static BookStoreWebAPI.BookOperations.CreateBookCommand;

namespace BookStoreWebAPI.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateDetailViewModel, Book>();
            CreateMap<Book, BookDetailViewModel>().ForMember(dest => dest.Genre, opt =>opt.MapFrom(src => (GenreEnum)src.GenreId)).ToString();
            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => (GenreEnum)src.GenreId)).ToString();
        }
    }
}
