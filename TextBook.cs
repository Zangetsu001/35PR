using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class TextBook:Book
    {
        public string GradeLevel { get; set;  }
        public TextBook(string title, string author, int year, double price, string gradelevel)
           : base(title, author, year, price)
        {
            GradeLevel = gradelevel;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Название произведения:{Title}\nАвтор:{Author}\nГод производства:{Year}\nЦена:{Price}\nУровень обучения:{GradeLevel}");
        }
    }
}
