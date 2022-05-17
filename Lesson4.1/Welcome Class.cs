using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._1
{
    internal class Program
    {
        // Определите класс Welcome, который имеет один открытый метод,
        // называемый Welcome Message(), и при вызове должен выводить "Добро пожаловать в ООП".
        
        static void Main(string[] args)
        {
            //создайте объект Welcome с таким же именем
            Welcome welcome = new Welcome();
            welcome.WelcomeMessage();
            Console.ReadKey();
        }

        class Welcome
        {
            //завершите класс и добавьте функцию WelcomeMessage()
            public void WelcomeMessage()
            {
                Console.WriteLine("Welcome to OOP");
            }
        }
    }
}
