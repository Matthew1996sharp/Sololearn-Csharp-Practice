using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._4
{
    internal class Program
    {
        // Вы создаете свое собственное приложение для социальной сети.
        // Пользователи могут указать свои имена, возраст и предпочитаемый язык.
        // Если пользователь не задаст язык, по умолчанию будет установлен английский.
        // Заполните метод параметрами имени, возраста и языка
        // и примите во внимание опцию английского языка по умолчанию для языка,
        // чтобы правильно вывести информацию о предоставленных 2 пользователях.
        
            static void Main(string[] args)
        {
            Settings("James", 25, "Spanish");
            Settings("Tom", 36);
        }

        static void Settings(string name, int age, string lang = "English")
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Language: " + lang);
        }
    }
}
