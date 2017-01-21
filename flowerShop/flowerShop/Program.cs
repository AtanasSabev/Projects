using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double magnolii = double.Parse(Console.ReadLine());
            double zumbul = double.Parse(Console.ReadLine());
            double rose = double.Parse(Console.ReadLine());
            double cactus = double.Parse(Console.ReadLine());
            double priceOfPresent = double.Parse(Console.ReadLine());

            double magnoliiPrice = magnolii * 3.25;
            double zumbulPrice = zumbul * 4;
            double rosePrice = rose * 3.50;
            double cactusPrice = cactus * 8;
            double mariqMoney = magnoliiPrice + zumbulPrice + rosePrice + cactusPrice;
            double tax = mariqMoney * 5 / 100;
            double totalMariqMoney = mariqMoney - tax;
            double present = totalMariqMoney - priceOfPresent;

            if (present >= 0)
            {
                
                double abv = Math.Floor(present);
                Console.WriteLine("She is left with {0} leva.", abv);
            }
            else
            {
                double presenttotal = present * -1;
                double btv = Math.Ceiling(presenttotal);
                Console.WriteLine("She will have to borrow {0} leva.", btv);
            }

        }
    }
}
