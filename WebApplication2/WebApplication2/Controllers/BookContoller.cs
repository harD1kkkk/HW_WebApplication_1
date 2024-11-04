using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")] // api/v1/book
    public class BookContoller : Controller
    {
        private static List<Book> books = new List<Book>()
        {
            new Book{Id=1,Author="Author1",Title="Name1",Price=100},
            new Book{Id=2,Author="Author2",Title="Name2",Price=200},
            new Book{Id=3,Author="Author3",Title="Name3",Price=300},
        };
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(books);
        }
        [HttpGet("{id}")]
        public ActionResult<Book> GetBookByID(int id) 
        {
            foreach (Book book in books)
            {
                if(book.Id == id)
                {
                    return Ok(book);
                }

            }
            return Ok("Not found");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
