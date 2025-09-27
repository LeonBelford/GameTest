using UiGame.Data.Miner;

namespace UiGame.Data.Player
{
    public class PlayerValue
    {
        public double Money { get; set; }
        public double Income { get; set; }
        public List<MinerValue>? Miners { get; set; }
        public double Costs { get; set; }
        public int Coal { get; set; }
        public int Iron { get; set; }
        public int Sand { get; set; }
        public int Gold { get; set; }
        List<MinerValue> miner = new();
        public List<MKResource> mKResources = new();
        public int[] CISGNums
        {
            get { return Miners != null ? CISGnumsCount(Miners) : new int[4]; }
        }


       
        public static int[] CISGnumsCount(List<MinerValue> minerValues)
        {
       
            int[] nums = new int[4];
            foreach (var r in minerValues)
            {
                switch (r.MinerResource)
                {
                    case MinerValue.Resources.Coal:
                        nums[0] += 1;
                        break;

                    case MinerValue.Resources.Iron:
                        nums[1] += 1;
                        break;

                    case MinerValue.Resources.Sand:
                        nums[2] += 1;
                        break;

                    case MinerValue.Resources.Gold:
                        nums[3] += 1;
                        break;
                }
            }
            return nums;
        }




    }
}
