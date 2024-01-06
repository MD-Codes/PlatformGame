namespace PlatformGame
{
    internal class PlatformsLevelOne : Platforms
    {
        public PlatformsLevelOne()
        {
            BottomPlatform();

            for (int i = 0; i < 4; i++)
            {
                PosX = 2 + i;
                PosY = 13;
                AddPlatform(PosX, PosY);
            }

            for (int i = 0; i < 4; i++)
            {
                PosX = 6 + i;
                PosY = 10;
                AddPlatform(PosX, PosY);
            }

            for (int i = 0; i < 4; i++)
            {
                PosX = 2 + i;
                PosY = 7;
                AddPlatform(PosX, PosY);
            }

            for (int i = 0; i < 4; i++)
            {
                PosX = 6 + i;
                PosY = 4;
                AddPlatform(PosX, PosY);
            }

            for (int i = 0; i < 4; i++)
            {
                PosX = 2 + i;
                PosY = 1;
                AddPlatform(PosX, PosY);
            }
        }
    }
}
