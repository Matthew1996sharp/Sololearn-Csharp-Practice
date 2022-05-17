using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._1
{
    internal class Program
    {
        // Авиакомпании проводят специальную акцию для подростков
        // и предлагают kindles для использования во время полета.
        // Напишите программу, которая будет принимать возраст пассажиров
        // в качестве входных данных и выводить "Возьмите свой kindle",
        // если возраст меньше или равен 19.

        static void Main(string[] args)
        {
            //используйте возраст в качестве вводных данных
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 19) Console.WriteLine("Take your kindle");
        }
    }
}
