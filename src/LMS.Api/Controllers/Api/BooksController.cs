using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers.Api;

[Route("api/books")]
[ApiController]
public sealed class BooksController : ControllerBase
{
    public BooksController()
    {
    }



    [HttpPost]
    public ActionResult<Book> CreateBook([FromBody] Book model)
    {
        // code here to save the reesource

        return Created(string.Empty, model);
    }

    [HttpGet]
    public ActionResult<IReadOnlyList<object>> GetBooks([FromQuery] int skip)
    {
        var book1 = new { BookName = "Mowgli", PublishedOn = DateTime.Now };
        var book2 = new { BookName = "ASB", PublishedOn = DateTime.Now };
        var book3 = new { BookName = "ZXY", PublishedOn = DateTime.Now };


        return Ok(new[] { book1, book2, book3 });
    }

    [HttpGet("{id:int}")]
    public ActionResult<Book> GetById([FromRoute] int id)
    {
        // code here to save the reesource
        var book1 = new { Id = 1, BookName = "Mowgli", PublishedOn = DateTime.Now };
        return Ok(book1);
        //return NotFound();
    }

    [HttpPut("{id:int}")]
    public ActionResult UpdateBook([FromRoute] int id, [FromBody] Book model)
    {
        // code here to save the reesource
        var updatedModel = model;
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public ActionResult DeleteBook([FromRoute] int id)
    {
        // code here to save the reesource
        return NoContent();
    }


    public class Book
    {
        public int Id { get; set; }
        public string Name { get; init; } = null!;
        public decimal Price { get; set; }
    }


}