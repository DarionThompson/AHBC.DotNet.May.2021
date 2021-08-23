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
        private BookService _bookService;

        public LibraryController(BookService bookService)
        {
            _bookService = bookService;
            
        }
        public IActionResult Index()
        {
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
            var book = _bookService.Books.FirstOrDefault(x => x.Id == id);
            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult FormResult(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }
            var librayModel = _bookService.CreateLibraryModel();
            _bookService.Books.Add(book);
            return View("index", librayModel);
        }
    }
}
