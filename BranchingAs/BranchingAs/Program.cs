using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int pckweight = Convert.ToInt32(Console.ReadLine());
            if (pckweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int pckwidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int pckheight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int pcklength = Convert.ToInt32(Console.ReadLine());
                int total = pckwidth + pckheight + pcklength;
                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    decimal combined = Convert.ToDecimal(((pckheight * pckwidth * pcklength) * pckweight) / 100.00);
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + combined + " \nThank you!");                    
                }
            }
            Console.ReadLine();
        }
    }
}
