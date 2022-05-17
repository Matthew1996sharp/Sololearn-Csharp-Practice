using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._3
{
    internal class Geometry
    {
        // Вы пишете программу для вычисления площади прямоугольника.
        // В настоящее время он принимает длину и высоту в качестве входных данных.
        // Завершите данный метод, чтобы принять их в качестве аргументов,
        // затем вычислите и верните площадь.

        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Area(length, height));
        }

        static int Area(int length, int height)
        {
            return length * height;
        }
    }
}
