using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            FictionBook fiction = new FictionBook("1984", "George Orwell", 1949, 500, "Dystopian");
            NonFictionBook nonFiction = new NonFictionBook("Sapiens", "Yuval Noah Harari", 2011, 800, "History");
            TextBook textbook = new TextBook("Mathematics for 10th grade", "V. Ivanov", 2020, 350, "10th grade");

            library.AddBook(fiction);
            library.AddBook(nonFiction);
            library.AddBook(textbook);

            library.DisplayBooks();
            Console.Read();
        }
    }
}
