using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class NonFictionBook:Book
    {
        public string Subject { get; set;  }
        public NonFictionBook(string title, string author, int year, double price, string subject)
           : base(title, author, year, price)
        {
            Subject = subject;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Название произведения:{Title}\nАвтор:{Author}\nГод производства:{Year}\nЦена:{Price}\nПредмет, на котором ориентированна книга:{Subject}");
        }
    }
}
