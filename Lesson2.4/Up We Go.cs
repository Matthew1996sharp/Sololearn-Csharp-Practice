using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._4
{
    internal class Program
    {
        // Колибри Анны, которая сейчас считается самой быстрой птицей в мире
        // по сравнению со своими размерами, может развивать скорость 80 км в час.
        // Напишите программу для вывода количества километров,
        // которые он будет преодолевать каждый час в течение 5 часов полета.

        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(80 * i);
            }
        }
    }
}
