using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformGame
{
    internal class DoorLevelTwo : Doors
    {
        public DoorLevelTwo()
        {
            PosX = 2;
            PosY = 0;
            AddDoor(PosX, PosY);
        }
    }
}
