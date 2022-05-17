using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._5
{
    internal class Program
    {
        // Руководство приняло решение увеличить общий бюджет заработной платы.
        // Предоставленная вам программа принимает в качестве входных данных
        // текущий бюджет заработной платы и процент повышения.
        // Он должен вывести бюджет заработной платы до повышения,
        // затем рассчитать и вывести бюджет с учетом повышений.
        // Исправьте программу, выполнив метод Increase()
        // (который должен рассчитать новый бюджет заработной платы) и вызвав его,
        // чтобы предоставленные выходные данные работали правильно.

        static void Main(string[] args)
        {
            int salaryBudget = Convert.ToInt32(Console.ReadLine());
            int percent = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Before the increase: " + salaryBudget);
            Increase(ref salaryBudget, percent);
            Console.WriteLine("After the increase: " + salaryBudget);
        }

        static void Increase(ref int salaryBudget, int percent)
        {
            salaryBudget += salaryBudget * percent / 100;
        }
    }
}
