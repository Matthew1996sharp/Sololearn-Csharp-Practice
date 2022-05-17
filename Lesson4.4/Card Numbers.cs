using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._4
{
    internal class Program
    {
        // Данная программа должна выводить номер банковской карты
        // Создайте get для доступа соответсвующего члена класса

        static void Main(string[] args)
        {
            Card card1 = new Card();
            Console.WriteLine(card1.AccountNum);
        }

        class Card
        {
            private string accountNum = "0011592048120";
            //create a property to get the account
            public string AccountNum
            {
                get { return accountNum; }
            }
        }
    }
}
