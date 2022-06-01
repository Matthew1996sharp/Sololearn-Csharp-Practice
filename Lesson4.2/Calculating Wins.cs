using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._2
{
    internal class Program
    {
        // Мы разрабатываем профильную систему для игроков онлайн игры
        // Программа берёт количество игр и побед в качестве входных данных и создаёт объект player
        // Завершите функцию GetWinRate() в данном классе Player
        // для расчёта и вывода в результат коэффициента выигрыша

        static void Main(string[] args)
        {
            int games = Convert.ToInt32(Console.ReadLine());
            int wins = Convert.ToInt32(Console.ReadLine());

            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            player1.GetWinRate();
        }
    }

    class Player
    {
        public int games;
        public int wins;
        private int winrate;

        public int Winrate
        {
            get { return winrate; }
            set { winrate = value; }
        }
        
        public void GetWinRate()
        {
            Console.WriteLine(wins * 100 / games);
        }
    }
}
