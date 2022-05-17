using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._6
{
    internal class Program
    {
        // Студенты должны иметь посещаемость не менее 95% и средний балл 80,
        // чтобы получить стипендию.
        // Напишите программу, которая будет принимать значения
        // посещаемости и среднего балла в качестве входных данных и выводить "Принято",
        // если заданные требования выполнены, и "Отклонено", если они не выполнены.

        static void Main(string[] args)
        {
            int attendance = Convert.ToInt32(Console.ReadLine());
            int avgScore = Convert.ToInt32(Console.ReadLine());
            
            if ((attendance >= 95) && (avgScore >= 80)) Console.WriteLine("Accepted");
            else Console.WriteLine("Denied");
        }
    }
}
