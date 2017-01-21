using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string(i == 0 || i == n - 1 ? '*' : ' ', n - 2));
        }
    }
}
    
