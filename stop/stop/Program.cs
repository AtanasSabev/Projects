using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
            int MaxNum = int.MinValue;
            int numCount = int.Parse(Console.ReadLine());
            for (int cuurNum = 0; cuurNum < numCount; cuurNum++)
            {
                int userInput = int.Parse(Console.ReadLine());
                if (MaxNum < userInput)
                {
                    MaxNum = userInput;

                }
                Console.WriteLine(MaxNum);
            }
        }
    }

