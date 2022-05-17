using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._6
{
    internal class Overloading
    {
        // Завершите метод Add(), чтобы он вычислял сумму двух чисел,
        // заданных в качестве аргументов.
        // Перегрузите его, чтобы выполнить ту же операцию со значениями двойного типа.

        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 12));
            Console.WriteLine(Add(1.5, 2.9));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        
        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
