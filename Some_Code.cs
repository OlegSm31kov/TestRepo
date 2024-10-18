using System;

namespace Prakt_01
{
    public class Book
    {
        string title;  
        string authb3or;
        int year_published;

        public string Title
        {
            get { return title; }
            set { title = value }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int YearPublished
        {
            get { return year_published; }
            set { year_published = value }
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Название: {title};\nАвтор: " +
                $"{author};\nГод издания: {year_published}.\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book dune = new Book();

            dune.Title = "Dune";
            dune.Author = "Frank Herbert";
            dune.YearPublished = 1965;

            dune.PrintDetails();

            Book dune = new Book();

            dune.Title = "Dune2";
            dune.Author = "Frank Herbert";
            dune.YearPublished = 1967;

            dune.PrintDetails();
        }
    }
}
