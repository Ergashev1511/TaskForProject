using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskForProject.Api.Models;
using TaskForProject.Api.Services.IServices;

namespace TaskForProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Book1Controller : ControllerBase
    {
        private readonly IBook1Services _services;

        public Book1Controller(IBook1Services services)
        {
            _services = services;   
        }


        [HttpPost("CreateBook1")]
        public async ValueTask<IActionResult> CreateBook1(Book1 book)
        {
            return Ok(await _services.CreateBook1(book));
        }


        [HttpGet("GetAllBook1")]
        public async ValueTask<IActionResult> GetAllBook1()
        {
            return Ok(await _services.GetAllBook1());
        }

    }
}
