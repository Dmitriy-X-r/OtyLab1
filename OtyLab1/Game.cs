using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OtyLab1
{
    internal class Game
    {
        Player1 player1 = new Player1();
        public int countWin{  get; private set; }
        public int countLose { get; private set; }
        public int lengthGame { get; private set; }
        public void GameProcess(bool[] arrMove)
        {           
            lengthGame = 0;
            int lvl = 0;
            for(int i = 0; i < arrMove.Length; i++)
            {
                bool player1sMove = player1.ChoiseMOve();
                if (player1sMove == arrMove[i])
                    lvl++;
                else if ((player1sMove != arrMove[i]) && (lvl > 1))
                    lvl--;

                if (lvl == 5)
                {
                    countWin++;
                    lengthGame = i+1;
                    break;
                }             
            }

            if (lvl != 5)
            {
                countLose++;
            }
                
        }
    }
}
