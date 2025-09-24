using UiGame.Data.Miner;
using UiGame.Data.Player;

namespace UiGame.Models.Shop
{
    public class MinerShop
    {
        public static PlayerValue BuyMiner(PlayerValue playerValue)
        {
            PlayerValue p = playerValue;
            MinerValue.Resources resources = MinerValue.Resources.Coal;

            Console.Clear();
            Console.WriteLine("Buying Miner.. huh :3");

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo Key = Console.ReadKey(true);
                switch (Key.KeyChar)
                {
                    



                }
            }









            return p;

        }



    }



}