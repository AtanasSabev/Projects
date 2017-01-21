using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++) {

                //first part
                for (int j = 0; j < 3 * input; j++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                string tireMejduZvezdichkite = new String('-', i);                
                Console.Write(tireMejduZvezdichkite);
                Console.Write("*");
                string tireSledZvezdìchkite = new String('-', input * 5 - (input * 3 + 2 + i));
                Console.Write(tireSledZvezdìchkite);
                Console.WriteLine();       
            }

            // second part
            for (int i = 0; i < input /2; i++)
            {
                for (int j = 0; j < input * 3; j++)
                {
                    Console.Write("*");

                }
                Console.Write("*");
                string tireSledZvezdichka2 = new string('-', input - 1);
                Console.Write(tireSledZvezdichka2);
                Console.Write("*");
                Console.Write(tireSledZvezdichka2);
                Console.WriteLine();
            }

            // third part
            for (int i = 0; i < input /2; i++)
            {
                string chertichki = new string('-', 3 * input - i);
                string chertichkiMejdu = new string('-', (input - 1) + 2 * i);
                string zvezdichkiMejdu = new string('*', (input - 1) + 2 * i);
                string chertichkiSled = new string('-', input - i -1);
                Console.Write(chertichki);
                Console.Write("*");
                if (i == input / 2 - 1)
                {
                    Console.Write(zvezdichkiMejdu);
                }
                else {
                    Console.Write(chertichkiMejdu);
                }              
                Console.Write("*");
                Console.Write(chertichkiSled);
                Console.WriteLine();

            }
        }
    }
}
