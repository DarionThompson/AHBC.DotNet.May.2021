using System;
using System.Collections.Generic;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PenExample

            var pen = new Pen
            {
                Color = "red",
                InkLevel = 10,
                TipType = "Fountain", 
                Brand = "Mont Blanc"
            };
            var newPen = new Pen
            {
                Color = "blue",
                InkLevel = 8,
                TipType = "Fountain",
                Brand = "Mont Blanc"
            };

            List<Pen> pens = new List<Pen>();
            pens.Add(pen);
            pens.Add(newPen);

            pen.Write();
            Console.WriteLine(pen.InkLevel);

            #endregion

            var book = new Book()
            {
                Title = "Child Theif",
                PageCount = 501,
                Author = new Author()
                {
                    FirstName = "Gelard",
                    LastName = "Brom",
                    Age = 56,
                    PenName = "Brom",
                    Gender = "Male"
                },
                Genre = "Fantasy",
                BookStyle = "Hardback",
                Series = false

            };
            var awesomeBook = new Book("Cat in the hat", 61, "Childrens");
            Console.WriteLine(awesomeBook.Author.PenName);
            Console.WriteLine(book.Author.LastName);
        }
    }
}

    