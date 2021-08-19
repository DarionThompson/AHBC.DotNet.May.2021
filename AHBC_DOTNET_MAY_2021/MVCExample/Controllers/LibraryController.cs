using Microsoft.AspNetCore.Mvc;
using MVCExample.Models;
using MVCExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExample.Controllers
{
    public class LibraryController : Controller
    {
        private BookService _bookService = new BookService();
        public IActionResult Index()
        {
            //Model Hydrate ? 
            var librayModel = _bookService.CreateLibraryModel();
            
            return View(librayModel);
        }

        [Route("library/returnbook/{id}")]
        public IActionResult ReturnBook(int id)
        {
            return Content($"You have returned a book ID: {id}");
        }

        [Route("library/viewbook/{id}")]
        public IActionResult ViewBook(int id)
        {
            //Other ways to pass data aside from model 
            ViewData["LocationId"] = "Detriot, MI";
            ViewBag.LocationId = "Detroit, MI";
            TempData["LocationId"] = "Brooklyn";
            _bookService.SetBooks();
            var book = _bookService.Books.FirstOrDefault(x => x.Id == id);
            return View(book);
        }
    }
}
