using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int MoneyGift = 10;
            int totalToysGifted = 0;
            int totalMoneySaved = 0;
            int LillysCurrentAge = int.Parse(Console.ReadLine());
            double WashingMaschinePrice = double.Parse(Console.ReadLine());
            int ToyPrice = int.Parse(Console.ReadLine());

            for (int LillysAge = 0; LillysAge <= LillysCurrentAge; LillysAge++)
            {
                if (LillysAge % 2 == 0)
                {
                    
                    totalMoneySaved += (MoneyGift - 1);
                    MoneyGift += 10;

                }
                else
                {
                    totalToysGifted++;
                }
                int ToysTotalPrice = totalToysGifted + ToyPrice;
                totalMoneySaved += ToysTotalPrice;

                double difference = totalMoneySaved - WashingMaschinePrice;
                if (difference >= 0)
                {
                    Console.WriteLine("Yes!{0:F2}", difference);
                }
                else
                {
                    Console.WriteLine("No! {0:F2}", Math.Abs (difference));
                }
            }
        }
    }
}
