using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtyLab1
{
    internal class Player2
    {
        private bool[] arrMove;
        public void SequenceOfMoves(int countMove)
        {
            arrMove = new bool[countMove];
            Random random = new Random();

            for (int i = 0; i < countMove; i++)
            {
                if (random.Next(0, 2) == 1)
                    arrMove[i] = true;
                else
                    arrMove[i] = false;
            }
        }

        public void OutputMoves()
        {
            for (int i = 0; i < arrMove.Length; i++)
                Console.WriteLine(i + 1 + " ход - " + arrMove[i]);
        }

        public bool[] GetMove()
        {
            return arrMove;
        }

        public void ChangeSequence((int move, bool moveOption) changeMade)
        {
            arrMove[changeMade.move - 1] = changeMade.moveOption;
        }

    }
}
