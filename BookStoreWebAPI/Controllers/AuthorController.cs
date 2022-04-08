using AutoMapper;
using BookStoreWebAPI.DBOperations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public AuthorController(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



    }
}
