using UiGame.Data.Player;
using UiGame.Data.Miner;

namespace UiGame.Models.UpGrade
{
    class MinerUpgrade
    {

        public static PlayerValue UpGrade(PlayerValue p)
        {
            int[] coalMKs = new int[p.Miners.Count];
            int[] IronMKs = new int[p.Miners.Count];
            int[] SandMKs = new int[p.Miners.Count];
            int[] GoldMKs = new int[p.Miners.Count];

            Console.Clear();
            Console.WriteLine("UpGrading Miner.. huh :3");
            Console.WriteLine($"Miners:\n[C]oal [{p.CISGNums[0]}] \n[I]ron [{p.CISGNums[1]}]" +
                                $"\n[S]and [{p.CISGNums[2]}] \n[G]old [{p.CISGNums[3]}]");
            foreach (var m in p.Miners)
            {
                p.mKResources.Add(new MKResource
                {
                    MinerMk = m.MinerMk,
                    MinerResource = m.MinerResource
                });

                switch (m.MinerResource)
                {
                    case MinerValue.Resources.Coal:
            
                        break;

                    case MinerValue.Resources.Iron:

                        break;

                    case MinerValue.Resources.Sand:

                        break;

                    case MinerValue.Resources.Gold:

                        break;
                }


            }


            if (Console.KeyAvailable)
            {
                int amount = 0;
                ConsoleKeyInfo k = Console.ReadKey(true);



                switch (k.KeyChar)
                {

                }
            }
            Thread.Sleep(50);





            return p;
        }











    }


}