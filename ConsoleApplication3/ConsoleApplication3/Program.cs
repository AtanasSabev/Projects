using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine());
            double chinese = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double bitcoinInBGN = bitcoin * 1168;
           // Console.WriteLine(bitcoinInBGN);

            double chineseInUSD = chinese * 0.15;
            //Console.WriteLine(chineseInUSD);
            double chineseInUSDtoBGN = chineseInUSD * 1.76;
            //Console.WriteLine(chineseInUSDtoBGN);
            double moneyInEUR = (chineseInUSDtoBGN + bitcoinInBGN) / 1.95;
            //Console.WriteLine(moneyInEUR);
            double income = (moneyInEUR * tax) / 100;
            //Console.WriteLine(income);
            double total = moneyInEUR - income;
            Console.WriteLine(total);




    
        }
    }
}