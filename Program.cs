using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using Values;
namespace MainGame;

public class MainGame(string[] args)
{

    public static void Main()
    {
        bool stop = false;



        // implements a new Player Objekt 'p' :D
        Player p = new Player();
        p.Money = 500;
        p.Coal = 100;

        // impletments a List with the Miner Properties and initializes a new Miner :3 
        List<Miners> miners = new();


        while (!stop)
        {
            //if statement checks if a key ist Availiable :3
            if (Console.KeyAvailable)
            {
                //converts the key if providet to the readkey method
                //without Pausing the LOOP >.<!!!!
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.KeyChar)
                {
                    case 'b':
                        miners.Add(new Miners
                        {
                            MinerNum = miners.Count + 1,
                            MinerMk = 1,
                            MinerLvl = 1,
                            MinerResource = Miners.Resources.Coal
                        });
                        p.Miners = miners;

                        break;
                    // Shop here you can sell ure goods :D 
                    case 's':
                        bool s = true;
                        int amount = 5;
                        double Sp;
                        Miners.Resources resources = Miners.Resources.Coal;
                        while (s)
                        {
                            Console.Clear();
                            Console.WriteLine("Sell Resources :3 \t\t Money {0}", p.Money);
                            Console.WriteLine("\n[C]oal: {0} \n[I]ron: {1} \n[S]and: {2} \n[G]old: {3}", p.Coal, p.Iron, p.Sand, p.Gold);
                            Console.WriteLine("/// Selling- [{0}] \\\\\\ - /// Amount [{1}] \\\\\\", resources.ToString(), amount);
                            Console.WriteLine("selling at {0}", Miners.SellingPoint(resources) * amount);
                            Console.WriteLine("\nu - Amount Up \td - Amount Down \tx - Sell Amount [{0}]", amount);

                            if (Console.KeyAvailable)
                            {
                                ConsoleKeyInfo k = Console.ReadKey(true);

                                switch (k.KeyChar)
                                {
                                    case 'u':
                                        amount += 5;
                                        break;

                                    case 'd':
                                        amount -= 5;
                                        break;
                                    case 'x':

                                        switch (resources)
                                        {
                                            case Miners.Resources.Coal:
                                                if (p.Coal >= amount)
                                                {
                                                    p.Coal -= amount;
                                                    p.Money = +Values.Miners.SellingPoint(resources) * amount;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("NOOO GOODS TO SELL :c \n Sowwy :(");
                                                }

                                                break;

                                            case Miners.Resources.Iron:

                                                break;

                                            case Miners.Resources.Sand:

                                                break;

                                            case Miners.Resources.Gold:
                                                break;

                                        }
                                        break;


                                    case 'c':
                                        resources = Miners.Resources.Coal;
                                        break;
                                    case 'i':
                                        resources = Miners.Resources.Iron;
                                        break;
                                    case 's':
                                        resources = Miners.Resources.Sand;
                                        break;
                                    case 'g':
                                        resources = Miners.Resources.Gold;
                                        break;






                                }


                            }
                            Thread.Sleep(50);
                        }
                        ;

                        break;



                }
            }
            Console.Clear();
            Console.WriteLine("Costs: {0}\nIncome: {1}\nMiners {2}", p.Costs, p.Money.ToString("F2"), p.Miners?.Count);
            Thread.Sleep(50);


        }
    }



    public static double Costs(double Miners, int TimesBought)
    {
        double _costs = 75;
        _costs = Miners * (1.5 * TimesBought);
        return _costs;
    }

    public static double Money(double Money, double Costs, List<Miners> miner)
    {

        foreach (var m in miner)
        {
            switch (m.MinerResource)
            {
                case Miners.Resources.Coal:
                    Money += (2.5 * m.MinerMk) * m.MinerLvl;
                    break;

                case Miners.Resources.Iron:
                    Money += (5 * m.MinerMk) * m.MinerLvl;
                    break;

                case Miners.Resources.Sand:
                    Money += (2 * m.MinerMk) * m.MinerLvl;
                    break;

                case Miners.Resources.Gold:
                    Money += (9 * m.MinerMk) * m.MinerLvl;
                    break;
            }
        }
        Money -= Costs;

        return Money;
    }






}