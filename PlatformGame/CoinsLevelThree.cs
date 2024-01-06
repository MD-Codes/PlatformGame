using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformGame
{
    internal class CoinsLevelThree : Coins
    {
        public CoinsLevelThree()
        {
            for (int i = 0; i < 2; i++)
            {
                PosX = 9 + i;
                PosY = 11;
                AddCoin(PosX, PosY);
            }

            for (int i = 0; i < 2; i++)
            {
                PosX = 12 + i;
                PosY = 8;
                AddCoin(PosX, PosY);
            }

            for (int i = 0; i < 2; i++)
            {

                PosX = 3 + i;
                PosY = 8;
                AddCoin(PosX, PosY);


            }

            for (int i = 0; i < 2; i++)
            {
                PosX = 2 + i;
                PosY = 4;
                AddCoin(PosX, PosY);
            }

           
        }
    }
}
