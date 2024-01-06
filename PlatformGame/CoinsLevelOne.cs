namespace PlatformGame
{
    internal class CoinsLevelOne : Coins
    {
        public CoinsLevelOne()
        {
            for (int i = 0; i < 2; i++)
            {
                PosX = 3 + i;
                PosY = 12;
                AddCoin(PosX, PosY);
            }

            for (int i = 0; i < 4; i++)
            {
                PosX = 6 + i;
                PosY = 9;
                AddCoin(PosX, PosY);
            }

            for (int i = 0; i < 2; i++)
            {

                PosX = 3 + i;
                PosY = 6;
                AddCoin(PosX, PosY);


            }

            for (int i = 0; i < 2; i++)
            {
                PosX = 7 + i;
                PosY = 3;
                AddCoin(PosX, PosY);
            }

            for (int i = 0; i < 2; i++)
            {
                PosX = 4 + i;
                PosY = 0;
                AddCoin(PosX, PosY);
            }
        }
    }
}

