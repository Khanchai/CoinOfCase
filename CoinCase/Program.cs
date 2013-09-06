using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCase
{
    class Program
    {
        static void Main(string[] args)
        {
                        var coincase = new CoinCase();
            while (true)
            {
                Console.WriteLine("Insert Coin(0.25,0.50,1,2,5,10)");
                Console.Write("> ");
                var coin = Console.ReadLine();

                if (coin == "exit") { break; }

                coincase.AddCoin(double.Parse(coin));
            }
            Console.WriteLine("Total of coin > "+coincase.GetAmount());
            Console.WriteLine("Count of coin 0.25 > "+coincase.GetCount(0.25));
            Console.WriteLine("Count of coin 0.50 > "+coincase.GetCount(0.50));
            Console.WriteLine("Count of coin 1 > "+coincase.GetCount(1));
            Console.WriteLine("Count of coin 2 > "+coincase.GetCount(2));
            Console.WriteLine("Count of coin 5 > "+coincase.GetCount(5));
            Console.WriteLine("Count of coin 10 > "+coincase.GetCount(10));
            Console.ReadKey();
        }
    }

    public enum CoinType { Stang025, Stang050, Bath1, Bath2, Bath5, Bath10 }

    class CoinCase
    {
        public CoinType CoinType { get; set; }

        public List<double> Coins = new List<double>();

        public void AddCoin(double coin)
        {
            Coins.Add(coin);
        }

        public double GetAmount()
        {
            return Coins.Sum();
        }

        public int GetCount(double type)
        {
            var coin = from i in Coins where i == type  select i;
            return coin.Count();
        }
    }
}
