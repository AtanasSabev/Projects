using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersTo1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kak se kazvash:");
            string name = (Console.ReadLine());
            if (name == "Mariq")
            {
                Console.WriteLine("Pak li gotvish limec? Answer Yes or No");
                string answer = (Console.ReadLine());
                if (answer == "Yes")
                {
                    Console.WriteLine("Stiga de! Napravi edna musaka!");
                }
                else
                {
                    Console.WriteLine("Napravi edna muska!");
                }
            }
            if (name == "Ani")
            {
                Console.WriteLine("Stiga gleda v monitora, a otivai da uchish! Answer Yes, sir or No, sir");
                string answer = (Console.ReadLine());
                if (answer == "Yes, sir")
                {
                    Console.WriteLine("Tova da se chuva!");
                }
                else
                {
                    Console.WriteLine("Nqma da ima Zara za teb!");
                }
            }
            if (name == "Marina")
            {
                Console.WriteLine("Raboti li baseina! Answer Yes or No");
                string answer = (Console.ReadLine());
                if (answer == "Yes")
                {
                    Console.WriteLine("Nedei da lajesh!");
                }
                else
                {
                    Console.WriteLine("Shte ti skasam ushite!");
                }
            }




        }
    }
}
