using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._2
{
    internal class Program
    {
        // В магазине проводится акция: если общая цена покупки равна или превышает
        // 10000, цена будет снижена на 20%.
        // Программа, которую вам дают, принимает общую цену покупки в качестве входных данных.
        // Выполните данный метод, чтобы принять общую цену покупки в качестве аргумента,
        // а также рассчитать и вернуть цену со скидкой, если требование кампании выполнено.
        // Метод должен возвращать ту же цену, если скидка не указана.

        static void Main(string[] args)
        {
            int TotalPrice = Convert.ToInt32(Console.ReadLine());
            Discount(TotalPrice);
        }

        static void Discount(int TotalPrice)
        {
            if (TotalPrice >= 10000) Console.WriteLine(TotalPrice * 0.8);
            else Console.WriteLine(TotalPrice);
        }
    }
}
