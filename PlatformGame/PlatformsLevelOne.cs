using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformGame
{
    internal class PlatformsLevelOne : Platforms
    {
        public PlatformsLevelOne()
        {
            BottomPlatform();
            BoardOne();
        }
        public void BoardOne()
        {
            for (int i = 0; i < 4; i++)
            {
                Platforms part = new Platforms
                {
                    PosX = 2 + i,
                    PosY = 13,
                };
                platformsList.Add(part);

            }

            for (int i = 0; i < 4; i++)
            {
                Platforms part = new Platforms
                {
                    PosX = 6 + i,
                    PosY = 10,
                };
                platformsList.Add(part);

            }

            for (int i = 0; i < 4; i++)
            {
                Platforms part = new Platforms
                {
                    PosX = 2 + i,
                    PosY = 7,
                };
                platformsList.Add(part);

            }

            for (int i = 0; i < 4; i++)
            {
                Platforms part = new Platforms
                {
                    PosX = 6 + i,
                    PosY = 4,
                };
                platformsList.Add(part);

            }

            for (int i = 0; i < 4; i++)
            {
                Platforms part = new Platforms
                {
                    PosX = 2 + i,
                    PosY = 1,
                };
                platformsList.Add(part);

            }

        }
    }
}
