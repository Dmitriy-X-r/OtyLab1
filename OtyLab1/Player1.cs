using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtyLab1
{
    internal class Player1
    {
        private bool move;
        public bool ChoiseMOve()
        {
            Random random = new Random();
            if (random.Next(0, 2) == 1)
                move = true;
            else
                move = false;
            return move;
        }
    }
}
