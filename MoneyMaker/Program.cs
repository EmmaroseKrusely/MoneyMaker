using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Give a number: ");
            string totalNum = Console.ReadLine();
            double numDouble = Convert.ToDouble(totalNum);

            Console.WriteLine($"{totalNum} is equal to.. ");
            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(numDouble / goldValue);
            double remainder = numDouble % goldValue;

            double silverCoins = Math.Floor(numDouble / silverValue);
            double remainder2 = numDouble % silverValue;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");

            Console.ReadKey();
        }
    }
}
