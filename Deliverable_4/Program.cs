//Author:Gabby Herrick
//Date: 2/8/2023
//Description: Fibonacci spiral d-4
using System;
namespace Deliverable_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[25];
            // Initialize fibonacci series
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 0; i < fib.Length; i++)
            {
                if (i >= 2)
                {
                    fib[i] = fib[i - 1] + fib  [i - 2];
                }
            }
            // Printing the results in the console
            for (int i = 0; i < fib.Length; i++)
            {
                Console.WriteLine("The Fibonacci for (" + i + ") is equal to " + fib[i]);
            }
        }
    }
}