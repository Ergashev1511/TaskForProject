using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskForProject.Api.Models;
using TaskForProject.Api.Services.IServices;

namespace TaskForProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Book2Controller : ControllerBase
    {
        private readonly IBook2Service _service;

        public Book2Controller(IBook2Service service)
        {
            _service = service;
        }


        [HttpPost("CreateBook2")]
         public async ValueTask<IActionResult> CreateBook2(Book2 book2)
        {
            return Ok(await _service.CreateBook2(book2));
        }


        [HttpGet("GetAllBook2")]
        public async ValueTask<IActionResult> GetAllBook2()
        {
            return Ok(await _service.GetAllBook2());
        }
    }
}
