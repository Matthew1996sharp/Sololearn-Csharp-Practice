using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._3
{
    internal class Program
    {
        // Наше графическое приложение должно сообщать,
        // что создание нового проекта успешно завершено после нажатия на кнопку "Create"
        // завершите данный класс, добавив конструктор,
        // который после выполнения операции выведет сообщение "Project created"

        static void Main(string[] args)
        {
            Project project = new Project();
        }

        class Project
        {
            public Project()
            {
                Console.WriteLine("Project created");
            }
        }
    }
}
