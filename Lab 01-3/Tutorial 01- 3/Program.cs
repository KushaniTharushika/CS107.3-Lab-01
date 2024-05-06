using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum =0;

            Console.Write("Enter a Positive number: ");
            number = int.Parse(Console.ReadLine());

            if (number > 0) 
            {
                for(int i=1; i <= number; i++) 
                {
                    sum = sum + i;
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
