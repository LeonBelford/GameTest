using UiGame.Data.Miner;
using UiGame.Data.Player;

namespace UiGame.Models.Shop
{
    public class SellingShop
    {
        public static PlayerValue SellingGoods(PlayerValue playerValues)
        {
            PlayerValue p = new();
            p = playerValues;
            p.Coal = 500;

            bool s = true;
            int amount = 5;
            double Sp;

            MinerValue.Resources resources = MinerValue.Resources.Coal;

            while (s)
            {
                Console.Clear();
                Console.WriteLine("Sell Resources :3 \t\t Money {0}", p.Money);
                Console.WriteLine("\n[C]oal: {0} \n[I]ron: {1} \n[S]and: {2} \n[G]old: {3}", p.Coal, p.Iron, p.Sand, p.Gold);
                Console.WriteLine("/// Selling- [{0}] \\\\\\ - /// Amount [{1}] \\\\\\", resources.ToString(), amount);
                Console.WriteLine("selling at {0}", Data.Miner.MinerValue.SellingPoint(resources) * amount);
                Console.WriteLine("\nu - Amount Up \td - Amount Down \tx - Sell Amount [{0}] \tq - quit", amount);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo k = Console.ReadKey(true);

                    switch (k.KeyChar)
                    {
                        case 'u':
                            //HIer auf jeden fall noch hinzufuregenb dass der amount nicht  ueber die echten amount geht
                            amount += 5;
                            break;

                        case 'd':
                            amount -= 5;
                            break;
                        case 'x':

                            switch (resources)
                            {
                                case MinerValue.Resources.Coal:
                                    if (p.Coal >= amount)
                                    {
                                        p.Coal -= amount;
                                        p.Money = +Data.Miner.MinerValue.SellingPoint(resources) * amount;

                                    }
                                    else
                                    {
                                        Console.WriteLine("NOOO GOODS TO SELL :c \n Sowwy :(");
                                        Console.ReadLine();
                                    }

                                    break;

                                case MinerValue.Resources.Iron:

                                    break;

                                case MinerValue.Resources.Sand:

                                    break;

                                case MinerValue.Resources.Gold:
                                    break;

                            }
                            break;


                        case 'c':
                            resources = MinerValue.Resources.Coal;
                            break;
                        case 'i':
                            resources = MinerValue.Resources.Iron;
                            break;
                        case 's':
                            resources = MinerValue.Resources.Sand;
                            break;
                        case 'g':
                            resources = MinerValue.Resources.Gold;
                            break;
                        case 'q':
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