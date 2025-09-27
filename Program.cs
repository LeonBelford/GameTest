using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

using UiGame.Data;
using UiGame.Data.Miner;
using UiGame.Data.Player;
using UiGame.Models.Shop;

namespace UiGame;

public class Game
{

    public static void Main(string[] args)
    {
        bool stop = false;
        // implements a new Player Objekt 'p' :D
        PlayerValue p = new PlayerValue();
        // impletments a List with the Miner Properties and initializes a new Miner :3 
        List<MinerValue> miners = new();
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
                        // p.Miners = Data.Miner.MinerValue.AddMiner();
                        p = UiGame.Models.Shop.MinerShop.BuyMiner(p);
                        break;
                    // Shop here you can sell ure goods :D 
                    case 's':
                        p = Models.Shop.SellingShop.SellingGoods(p);
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Costs: {0}\nIncome: {1}\nMiners {2}", p.Costs, p.Money.ToString("F2"), p.Miners?.Count);
            Thread.Sleep(50);
        }
    }








}