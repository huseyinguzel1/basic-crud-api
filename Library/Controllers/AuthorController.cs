using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        IAuthorService _authorManager;

        public AuthorController(IAuthorService authorService) => _authorManager = authorService;

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _authorManager.GetAll();
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public ActionResult GetById(int id)
        {
            var result = _authorManager.GetById(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public ActionResult Add(Author author)
        {
            _authorManager.Add(author);
            return Ok();
        }
        [HttpPut("update")]
        public ActionResult Update(Author author)
        {
            _authorManager.Update(author);
            return Ok();
        }
        [HttpDelete("delete")]
        public ActionResult Delete(Author author)
        {
            _authorManager.Delete(author);
            return Ok();
        }
    }
}
