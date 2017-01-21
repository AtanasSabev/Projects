using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBranchSimulatorVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи желаната сума");
            double MainSUM = double.Parse(Console.ReadLine());
            Console.WriteLine("100 лева");
            int hundredleva = int.Parse(Console.ReadLine());
            int hundretlevatotal = hundredleva * 100;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 100 лева:");
            Console.Write(hundretlevatotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.Write(hundretlevatotal);
            Console.WriteLine();
            Console.WriteLine("50 лева");
            int fiftyleva = int.Parse(Console.ReadLine());
            int fiftylevatotal = fiftyleva * 50;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 50 лева:");
            Console.Write(fiftylevatotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.WriteLine(hundretlevatotal + fiftylevatotal);
            Console.WriteLine("20 лева");
            int twentyleva = int.Parse(Console.ReadLine());
            int twentylevatotal = twentyleva * 20;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 20 лева:");
            Console.Write(twentylevatotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.WriteLine(hundretlevatotal + fiftylevatotal + twentylevatotal);
            Console.WriteLine("10 лева");
            int tenleva = int.Parse(Console.ReadLine());
            int tenlevatotal = tenleva * 10;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 10 лева:");
            Console.Write(tenlevatotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.WriteLine(hundretlevatotal + fiftylevatotal + twentylevatotal + tenlevatotal);
            Console.WriteLine("5 лева");
            int fiveleva = int.Parse(Console.ReadLine());
            int fivelevatotal = fiveleva * 5;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 5 лева:");
            Console.Write(fivelevatotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.Write(hundretlevatotal + fiftylevatotal + twentylevatotal + tenlevatotal + fivelevatotal);
            Console.WriteLine();
            Console.WriteLine("2 лева книжни");
            int twolevapaper = int.Parse(Console.ReadLine());
            int twolevapapertotal = twolevapaper * 2;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 2 лева книжни:");
            Console.Write(twolevapapertotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.WriteLine(hundretlevatotal + fiftylevatotal + twentylevatotal + tenlevatotal + fivelevatotal + twolevapapertotal);
            Console.WriteLine("2 лева монета");
            int twolevacoin = int.Parse(Console.ReadLine());
            int twolevacointotal = twolevacoin * 2;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 2 лева монета:");
            Console.Write(twolevacointotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.Write(hundretlevatotal + fiftylevatotal + twentylevatotal + tenlevatotal + fivelevatotal + twolevapapertotal + twolevacointotal);
            Console.WriteLine();
            Console.WriteLine("1 лев книжен");
            int onelevapaper = int.Parse(Console.ReadLine());
            int onelevapapertotal = onelevapaper * 1;
            if (onelevapaper > 0)
            {
                for (int i = 1; i < 20; i++)
                {
                    Console.WriteLine("НЯМА ВЕЧЕ КНИЖНИ ЛЕВОВЕ!!!");
                    Console.WriteLine("ОБЪРКА ЗАДАЧАТА! ПИШИ САМО НУЛИ И ПОЧВАЙ ПАК!");
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
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 1 лев монета:");
            Console.Write(onelevacointotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.WriteLine(levovepaper);
            Console.WriteLine();
            Console.WriteLine(("50 стотинки"));
            int fiftycoin = int.Parse(Console.ReadLine());
            double fiftycointotal = fiftycoin * 0.5;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 50 стотинки:");
            Console.Write(fiftycointotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.Write(levovepaper + fiftycointotal);
            Console.WriteLine();
            Console.WriteLine("20 стотинки");
            int twentycoin = int.Parse(Console.ReadLine());
            double twentycointotal = twentycoin * 0.2;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 20 стотинки:");
            Console.Write(twentycointotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.Write(levovepaper + fiftycointotal + twentycointotal);
            Console.WriteLine();
            Console.WriteLine("10 стотинки");
            int tencoin = int.Parse(Console.ReadLine());
            double tencointotal = tencoin * 0.10;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 10 стотинки:");
            Console.Write(tencointotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.Write(levovepaper + fiftycointotal + twentycointotal + tencointotal);
            Console.WriteLine();
            Console.WriteLine("5 стотинки");
            int fivecoin = int.Parse(Console.ReadLine());
            double fivecointotal = fivecoin * 0.05;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 5 стотинки:");
            Console.Write(fivecointotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.Write(levovepaper + fiftycointotal + twentycointotal + tencointotal + fivecointotal);
            Console.WriteLine();
            Console.WriteLine("2 стотинки");
            int twocoin = int.Parse(Console.ReadLine());
            double twocointotal = twocoin * 0.02;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 2 стотинки:");
            Console.Write(twocointotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.Write(levovepaper + fiftycointotal + twentycointotal + tencointotal + fivecointotal + twocointotal);
            Console.WriteLine();
            Console.WriteLine(("1 стотинка"));
            int onecoin = int.Parse(Console.ReadLine());
            double onecointotal = onecoin * 0.01;
            double cointotal = fiftycointotal + twentycointotal + tencointotal + fivecointotal + twocointotal + onecointotal;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Сума по 1 стотинки:");
            Console.Write(onecointotal);
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(' ');
            }
            Console.Write("Общо:");
            Console.Write(levovepaper + fiftycointotal + twentycointotal + tencointotal + fivecointotal + twocointotal + onecointotal);
            Console.WriteLine();
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
                    Console.WriteLine("ГРЕШКА!!! ЩЕ ТИ СКЪСАМ УШИТЕ!!!");
                }
            }
            Console.ReadLine();


        }
    }
}
        
    

