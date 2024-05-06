using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;


            Console.WriteLine("The Area of the rectangle is: \n" + area);
            Console.ReadLine();

        }
    }
}
