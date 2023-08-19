using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookManager;

        public BookController(IBookService bookManager) => _bookManager = bookManager;
        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _bookManager.GetAll();
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public ActionResult GetById(int id)
        {
            var result = _bookManager.GetById(id);
            return Ok(result);
        }
        [HttpPost("add")]
        public ActionResult Add(Book book)
        {
            _bookManager.Add(book);
            return Ok();
        }
        [HttpPut("update")]
        public ActionResult Update(Book book)
        {
            _bookManager.Update(book);
            return Ok();
        }

        [HttpDelete("delete")]
        public ActionResult Delete(Book book)
        {
            _bookManager.Delete(book);
            return Ok();
        }

        [HttpGet("getbyauthorid")]
        public ActionResult GetByAuthorId(int id)
        {
            var result = _bookManager.GetByAuthorId(id);
            return Ok(result);
        }
    }
}
