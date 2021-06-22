using System;
namespace ClassesAndObjects
{
    public class Book
    {

        //Title, page count, author, genre, series, Book style

        public string Title { get; set; }

        public int PageCount { get; set; }

        public Author Author { get; set; }

        public string Genre { get; set; }

        public bool Series { get; set; }

        public string BookStyle { get; set; }

        public Book()
        {
        }

        public Book(string title,int pageCount, string genre)
        {

            Title = title;
            PageCount = pageCount;
            Genre = genre;
        }

        public Book(string title, int pageCount, Author author)
        {
            Title = title;
            PageCount = pageCount;
            Author = author;
        }
    }
}
