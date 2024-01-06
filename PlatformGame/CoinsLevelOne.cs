using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformGame
{
    internal class CoinsLevelOne : Coins
    {
        public CoinsLevelOne()
        {
            BoardOne();
        }
        private void BoardOne()
        {
            for (int i = 0; i < 4; i++)
            {
                Coins coin = new Coins
                {
                    PosX = 8 + i,
                    PosY = 12,
                };
                coins.Add(coin);

            }

            for (int i = 0; i < 4; i++)
            {
                Coins coin = new Coins
                {
                    PosX = 12 + i,
                    PosY = 9,
                };
                coins.Add(coin);

            }

            for (int i = 0; i < 4; i++)
            {
                Coins coin = new Coins
                {
                    PosX = 8 + i,
                    PosY = 6,
                };
                coins.Add(coin);

            }

            for (int i = 0; i < 4; i++)
            {
                Coins coin = new Coins
                {
                    PosX = 12 + i,
                    PosY = 3,
                };
                coins.Add(coin);

            }

            for (int i = 0; i < 4; i++)
            {
                Coins coin = new Coins
                {
                    PosX = 8 + i,
                    PosY = 0,
                };
                coins.Add(coin);

            }
        }
    }
}
