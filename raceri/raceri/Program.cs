using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            double junior = double.Parse(Console.ReadLine());
            double senior = double.Parse(Console.ReadLine());
            string trase = (Console.ReadLine());
            double racers = junior + senior;

            if (trase == "trail")
            {
                double juniortax = junior * 5.50;
                double seniortax = senior * 7;
                double totalTax = juniortax + seniortax;
                double tax = totalTax * 5 / 100;
                double totalIncome = totalTax - tax;
                Console.WriteLine("{0:F2}", totalIncome);
            }
            else if (trase == "cross-country")
            {
                if (racers >= 50)
                {

                    double juniortax = junior * 8;
                    double seniortax = senior * 9.50;
                    double totalTax = juniortax + seniortax;
                    double tax = totalTax * 5 / 100;
                    double totalIncome = totalTax - tax;
                    double extraTax = totalIncome - totalIncome * 25 / 100;
                    Console.WriteLine("{0:F2}", extraTax);

                }
                else
                {
                    double juniortax = junior * 8;
                    double seniortax = senior * 9.50;
                    double totalTax = juniortax + seniortax;
                    double tax = totalTax * 5 / 100;
                    double totalIncome = totalTax - tax;
                    Console.WriteLine("{0:F2}", totalIncome);
                }

            }
            else if (trase == "downhill")
            {
                double juniortax = junior * 12.25;
                double seniortax = senior * 13.75;
                double totalTax = juniortax + seniortax;
                double tax = totalTax * 5 / 100;
                double totalIncome = totalTax - tax;
                Console.WriteLine("{0:F2}", totalIncome);
            }
            else
            {
                double juniortax = junior * 20;
                double seniortax = senior * 21.50;
                double totalTax = juniortax + seniortax;
                double tax = totalTax * 5 / 100;
                double totalIncome = totalTax - tax;
                Console.WriteLine("{0:F2}", totalIncome);
            }
        }
    }
}
