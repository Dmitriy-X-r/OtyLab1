using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtyLab1
{
    internal class Game
    {
        Player1 player1 = new Player1();
        public void GameProcess(bool[] arrMove)
        {
            int lvl = 0;
            Console.WriteLine("Положения игрока 2: \t\tПредложения игрока 1:");
            for(int i = 0; i < arrMove.Length; i++)
            {
                bool player1sMove = player1.ChoiseMOve();
                if (player1sMove == arrMove[i])
                    lvl++;
                else if ((player1sMove != arrMove[i]) && (lvl > 1))
                    lvl--;

                Console.WriteLine(i + 1 + " ход - " + lvl + " уровень \t\t" + (i + 1) + " ход - " + player1sMove);
                if (lvl == 5)
                {
                    Console.WriteLine("Игрок вышел из лабиринта");
                    break;
                }             
            }

            if (lvl != 5)
                Console.WriteLine("Поражение. Ходы закончились.");
        }
    }
}
