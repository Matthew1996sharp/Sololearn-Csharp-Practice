using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._2
{
    internal class Program
    {
        // Вы создаете игру, в которой игрок выбирает уровень сложности:
        // 1 - Легко
        // 2 - Средний
        // 3 - Жесткий
        // Вам предоставляется программа, которая принимает число в качестве входных данных.
        // Завершите программу так, чтобы она выдала соответствующий уровень сложности.
        // Если пользователь ввел неверный номер, программа должна вывести "Invalid option".
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Easy");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Medium");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Hard");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option");
                        break;
                    }
            }
        }
    }
}
