using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._7
{
    internal class Program
    {
        // Напишите программу, которая примет число N в качестве входных данных
        // и рекурсивно вычислит сумму всех чисел от 1 до N.

        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(number));
        }

        static int Sum(int num)
        {
            if (num == 1) return 1;
            return num + Sum(num - 1);
        }
    }
}
