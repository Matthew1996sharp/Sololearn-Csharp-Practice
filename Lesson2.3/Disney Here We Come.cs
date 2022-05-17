using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._3
{
    internal class Program
    {
        // Вы работаете на карусели в Disney.
        // Вы должны сосчитать от 3 до 0 на экране,
        // прежде чем запускать карусель.
        static void Main(string[] args)
        {
            int number = 3;
            while (number > -1)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}
