using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformGame
{
    internal class CoinsLevelTwo : Coins
    {
        public CoinsLevelTwo()
        {
            for (int i = 0; i < 2; i++)
            {
                PosX = 11+ i;
                PosY = 11;
                AddCoin(PosX, PosY);
            }

            for (int i = 0; i < 2; i++)
            {
                PosX = 5 + i;
                PosY = 9;
                AddCoin(PosX, PosY);
            }

            for (int i = 0; i < 2; i++)
            {

                PosX = 10 + i;
                PosY = 6;
                AddCoin(PosX, PosY);


            }            
        }
    }
}
