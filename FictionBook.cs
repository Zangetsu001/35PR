using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class FictionBook:Book
    {
        public string Genre { get; set;  }
        public FictionBook(string title, string author, int year, double price, string genre)
            :base(title, author, year, price)
        {
            Genre = genre;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Название произведения:{Title}\nАвтор:{Author}\nГод производства:{Year}\nЦена:{Price}\nЖанр:{Genre}");
        }
    }
}
