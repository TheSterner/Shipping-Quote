using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("Please enter the weight of the package you are shipping.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Your package is to heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Please enter the package width.");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length.");
            int length = Convert.ToInt32(Console.ReadLine());
            int dimentions = (width + height + length);
            if (dimentions > 50)
            {
                Console.WriteLine("The package is to big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            int total = ((dimentions * packageWeight) / 100);
            Console.WriteLine("Your estimated total for shipping this package is: $" + total);
            Console.WriteLine("Thank you.");
            Console.ReadLine();

        }
    }
}
