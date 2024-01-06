using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformGame
{
    internal class DoorLevelOne : Doors
    {
        public DoorLevelOne()
        {
            PosX = 2;
            PosY = 0;
            AddDoor(PosX, PosY);
        }
    }
}
