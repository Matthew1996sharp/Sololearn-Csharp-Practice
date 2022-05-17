using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //примите имя в качестве пользовательского ввода
            Console.WriteLine("Input your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}. Welcome to our event", name);
            Console.ReadKey();
        }
    }
}
