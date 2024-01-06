using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformGame
{
    internal class PlatformLevelTwo : Platforms
    {
        public PlatformLevelTwo()
        {
            BottomPlatform();

            for (int i = 0; i < 4; i++)
            {
                PosX = 10 + i;
                PosY = 12;
                AddPlatform(PosX, PosY);
            }

            for (int i = 0; i < 4; i++)
            {
                PosX = 4 + i;
                PosY = 10;
                AddPlatform(PosX, PosY);
            }

            for (int i = 0; i < 4; i++)
            {
                PosX = 9 + i;
                PosY = 7;
                AddPlatform(PosX, PosY);
            }

            PosX = 6;
            PosY = 5;
            AddPlatform(PosX, PosY);

            PosX = 4;
            PosY = 3;
            AddPlatform(PosX, PosY);

            PosX = 2;
            PosY = 1;
            AddPlatform(PosX, PosY);            
        }
    }
}
