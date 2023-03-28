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

    [HttpGet]
    public ActionResult<IReadOnlyList<object>> GetBooks(IEnumerable<object> list)
    {
        var book1 = new { BookName = "Mowgli", PublishedOn = DateTime.Now };
        var book2 = new { BookName = "ASB", PublishedOn = DateTime.Now };
        var book3 = new { BookName = "ZXY", PublishedOn = DateTime.Now };


        return Ok(new[] { book1, book2, book3 });
    }
}
