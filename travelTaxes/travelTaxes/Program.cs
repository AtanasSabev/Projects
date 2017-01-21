using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            if (distance < 20)
            {
                if (dayTime == "day")
                {
                    Console.WriteLine("Taxi:{0}", distance * 0.79 + 0.70); 
                }
                else
                {
                    Console.WriteLine("Taxi:{0}", distance * 0.90 + 0.70);
                }
            }
            else if (distance > 20)
            {
                Console.WriteLine("Bus:{0}", distance * 0.09);
            }
            else
            {
                Console.WriteLine("Train:{0}", distance * 0.06);
            }
        }
    }
}
