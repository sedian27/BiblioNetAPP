using BiblioNetAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookModel Book) 
        {
            if (!ModelState.IsValid) 
            { 
                return View(Book);
            }

            return View();
        }
    }
}
