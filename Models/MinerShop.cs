using System.ComponentModel;
using UiGame.Data.Miner;
using UiGame.Data.Player;

namespace UiGame.Models.Shop
{
    public class MinerShop
    {
        public static PlayerValue BuyMiner(PlayerValue playerValue)
        {
            PlayerValue p = playerValue;
            bool s = true;
            // try
            // {
            //     p.CISGNums = Data.Player.PlayerValue.MinerResourceCount(p);
            // }
            // catch
            // {
            //     p.CISGNums = [0, 0, 0, 0];
            // }



            while (s)
            {
                Console.Clear();
                Console.WriteLine("Buying Miner.. huh :3");
                Console.WriteLine($"Miners:\n[C]oal [{p.CISGNums[0]}] \n[I]ron [{p.CISGNums[1]}]" +
                                    $"\n[S]and [{p.CISGNums[2]}] \n[G]old [{p.CISGNums[3]}]");

                if (Console.KeyAvailable)
                {
                    MinerValue.Resources r;
                    ConsoleKeyInfo Key = Console.ReadKey(true);
                    switch (Key.KeyChar)
                    {
                        case 'c':
                            r = MinerValue.Resources.Coal;
                            p.Miners = Data.Miner.MinerValue.AddMiner(r);
                            break;
                        case 'i':
                            r = MinerValue.Resources.Iron;
                            p.Miners = Data.Miner.MinerValue.AddMiner(r);
                            break;
                        case 's':
                            r = MinerValue.Resources.Sand;
                            p.Miners = Data.Miner.MinerValue.AddMiner(r);
                            break;
                        case 'g':
                            r = MinerValue.Resources.Gold;
                            p.Miners = Data.Miner.MinerValue.AddMiner(r);
                            break;
                        case 'e':
                            s = false;

                            break;
                    }
                }
                Thread.Sleep(50);
            }
            return p;
        }
    }
}