using System;

namespace WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
           double requestedHouris = double.Parse(Console.ReadLine());
           double days = double.Parse(Console.ReadLine());
           double employersWhoCanWorkExtra = double.Parse(Console.ReadLine());
 
           double workHours = (days * 8) - ((days * 8)* 10) / 100;
           double extraHours = employersWhoCanWorkExtra * (2 * days);
           double totalWorkHours = workHours + extraHours;

  

            double diff = requestedHouris - totalWorkHours;

            double result =  Math.Ceiling(diff);

            if (result <= 0)
            {
                result = result * -1;
                Console.WriteLine("Yes!{0} hours left.", result);
            }
            else {
                Console.WriteLine("Not enough time!{0} hours needed.", result);
            }

        }
    }
}
