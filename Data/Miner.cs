namespace UiGame.Data.Miner
{
    public class MinerValue
    {


        public int MinerNum { get; set; }
        public int MinerMk { get; set; }
        public int MinerLvl { get; set; }
        public Resources MinerResource{ get; set; }

        public enum Resources
        {
            Coal,
            Iron,
            Sand,
            Gold
        }

        // determints the price of the selling goods
        public static double SellingPoint(MinerValue.Resources resources)
        {
            double amount = 0;
            switch (resources)
            {
                case MinerValue.Resources.Coal:
                    amount = 2.5;

                    break;

                case MinerValue.Resources.Iron:
                    amount = 5;
                    break;

                case MinerValue.Resources.Sand:
                    amount = 2;
                    break;

                case MinerValue.Resources.Gold:
                    amount = 8;
                    break;

            }

            return amount;
        }


        public static List<MinerValue> miner = new();
        //Creats a Minerlist and returs it with the given Configs
        public static List<MinerValue> AddMiner()
        {
            miner.Add(new MinerValue
            {
                MinerNum = miner.Count + 1,
                MinerMk = 1,
                MinerLvl = 1,
                MinerResource = MinerValue.Resources.Coal
            });
            // Add Miner to Player :D 
            return miner;
        }





    }
}