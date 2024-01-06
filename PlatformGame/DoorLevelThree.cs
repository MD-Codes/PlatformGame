using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformGame
{
    internal class DoorLevelThree : Doors
    {
        public DoorLevelThree()
        {
            PosX = 15;
            PosY = 1;
            AddDoor(PosX, PosY);
        }
    }
}
