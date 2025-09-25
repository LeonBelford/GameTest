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

    }



}