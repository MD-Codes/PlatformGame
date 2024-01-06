namespace PlatformGame
{
    internal class PlatformLevelThree : Platforms
    {
        public PlatformLevelThree()
        {
            BottomPlatform();

            for (int i = 0; i < 4; i++)
            {
                PosX = 8 + i;
                PosY = 12;
                AddPlatform(PosX, PosY);
            }

            for (int i = 0; i < 4; i++)
            {
                PosX = 11 + i;
                PosY = 9;
                AddPlatform(PosX, PosY);
            }

            for (int i = 0; i < 4; i++)
            {
                PosX = 2 + i;
                PosY = 9;
                AddPlatform(PosX, PosY);
            }

            for (int i = 0; i < 2; i++)
            {
                PosX = 6 + i;
                PosY = 5;
                AddPlatform(PosX, PosY);

            }
            for (int i = 0; i < 3; i++)
            {
                PosX = 13 + i;
                PosY = 2;
                AddPlatform(PosX, PosY);

            }
            
        }
    }
}
