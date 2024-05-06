using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first N terms of the Fibonacci Series: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First " + n + " terms of the Fibonacci Series");
            Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciRecursive(i) +" ");
                Console.ReadLine();

            }
        }
        static int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            else
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
