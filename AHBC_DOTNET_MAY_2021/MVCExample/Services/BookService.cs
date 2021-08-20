using MVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExample.Services
{
    public class BookService
    {
        //private CalculatorService _calculatorService;
        //private LoggerService loggerService;
        //private EvaluationService evaluationService;
        //public BookService(CalculatorService calculatorService, 
        //                    EvaluationService evaluationService, 
        //                    LoggerService loggerService)
        //{

        //}
        public List<Book> Books { get; set; }
        public LibraryViewModel CreateLibraryModel()
        {
            SetBooks();
            var libraryVm = new LibraryViewModel();
            libraryVm.Id = 1;
            libraryVm.Name = "Detroit Library";
            libraryVm.Books = Books;

            return libraryVm;
        }

        public void SetBooks()
        {
            Books =  new List<Book>()
            {
                new Book
                {
                    Id =1,
                    Name  = "Clean Code",
                    Author = "Uncle Bob"
                },
                new Book
                {
                    Id =2,
                    Name  = "Clean Arc",
                    Author = "Uncle Bob"
                },
                new Book
                {
                    Id =3,
                    Name  = "Cracking the coding Interview",
                    Author = "Uncle Bob"
                },
                new Book
                {
                    Id =4,
                    Name  = "Test Driven development",
                    Author = "Kent Beck"
                },
            };
        }
    }
}
