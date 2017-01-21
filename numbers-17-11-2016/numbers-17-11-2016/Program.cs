using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_17_11_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            if (symbol == "+" || symbol == "-" || symbol == "*")
            {
                int result = 0;
                string NumberType = string.Empty;

                if (symbol == "+")
                {
                    result = num1 + num2;

                }
                else if (symbol == "-")
                {
                    result = num1 - num2;

                }
                else
                {
                    result = num1 * num2;
                }

                if (result % 2 == 0)
                {
                    NumberType = "even";
                }
                else
                {
                    NumberType = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}",
                    num1, symbol, num2, result, NumberType);
            }
            else
            {
                if (num2 != 0)
                {
                    double result = 0;
                    if(symbol == "/")
                    {
                        result = num1 / (double) num2;

                    }
                    else
                    {
                        result = num1 % num2;
                    }
                    Console.WriteLine("{0} {1} {2} = {3 : 0.##}",
                    num1, symbol, num2, result);
                }
                else
                {
                    Console.WriteLine("Cannot devide {0} by 0", num1);
                }


            }
            }
        }
    }

