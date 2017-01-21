using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBranchSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double MainSUM = double.Parse(Console.ReadLine());
            Console.WriteLine("100 лева");
            int hundredleva = int.Parse(Console.ReadLine());
            int hundretlevatotal = hundredleva * 100;
            Console.WriteLine("50 лева");
            int fiftyleva = int.Parse(Console.ReadLine());
            int fiftylevatotal = fiftyleva * 50;
            Console.WriteLine("20 лева");
            int twentyleva = int.Parse(Console.ReadLine());
            int twentylevatotal = twentyleva * 20;
            Console.WriteLine("10 лева");
            int tenleva = int.Parse(Console.ReadLine());
            int tenlevatotal = tenleva * 10;
            Console.WriteLine("5 лева");
            int fiveleva = int.Parse(Console.ReadLine());
            int fivelevatotal = fiveleva * 5;
            Console.WriteLine("2 лева книжни");
            int twolevapaper = int.Parse(Console.ReadLine());
            int twolevapapertotal = twolevapaper * 2;
            Console.WriteLine("2 лева монета");
            int twolevacoin = int.Parse(Console.ReadLine());
            int twolevacointotal = twolevacoin * 2;
            Console.WriteLine("1 лев книжен");
            int onelevapaper = int.Parse(Console.ReadLine());
            int onelevapapertotal = onelevapaper * 1;
            if (onelevapaper > 0)
            {
                for (int i = 1; i < 20; i++)
                {
                    Console.WriteLine("НЯМА ВЕЧЕ КНИЖНИ ЛЕВОВЕ!!!");
                }
                
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine("1 лев монета");
            int onelevacoin = int.Parse(Console.ReadLine());
            int onelevacointotal = onelevacoin * 1;
            int levovepaper = hundretlevatotal + fiftylevatotal + twentylevatotal + tenlevatotal + fivelevatotal + twolevapapertotal + twolevacointotal + onelevapapertotal + onelevacointotal;
            Console.WriteLine(("50 стотинки"));
            int fiftycoin = int.Parse(Console.ReadLine());
            double fiftycointotal = fiftycoin * 0.5;
            Console.WriteLine("20 стотинки");
            int twentycoin = int.Parse(Console.ReadLine());
            double twentycointotal = twentycoin * 0.2;
            Console.WriteLine("10 стотинки");
            int tencoin = int.Parse(Console.ReadLine());
            double tencointotal = tencoin * 0.10;
            Console.WriteLine("5 стотинки");
            int fivecoin = int.Parse(Console.ReadLine());
            double fivecointotal = fivecoin * 0.05;
            Console.WriteLine("2 стотинки");
            int twocoin = int.Parse(Console.ReadLine());
            double twocointotal = twocoin * 0.02;
            Console.WriteLine(("1 стотинка"));
            int onecoin = int.Parse(Console.ReadLine());
            double onecointotal = onecoin * 0.01;
            double cointotal = fiftycointotal + twentycointotal + tencointotal + fivecointotal + twocointotal + onecointotal;
            double totalsum = levovepaper + cointotal;
            if (MainSUM == totalsum)
            {
                for (int i = 1; i < 20; i++)
                {
                    Console.WriteLine("БРАВО!!! НАПРАВИ ГО ПАК!!!");
                }
            }
            else
            {
                for (int i = 1; i < 20; i++)
                {
                    Console.WriteLine("ЩЕ ТИ СКЪСАМ УШИТЕ!!!");
                }
            }
             


        }
    }
}
