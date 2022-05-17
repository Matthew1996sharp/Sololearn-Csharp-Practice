using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Расчёт годового дохода по месячной зарплате
            Console.WriteLine("Input your salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(salary * 12);
        }
    }
}
