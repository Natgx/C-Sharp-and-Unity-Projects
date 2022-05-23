using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int cyourAge = Convert.ToInt32(yourAge);
            Console.WriteLine("Have you ever had a DUI?");
            string hadDUI = Console.ReadLine();
            bool trueFalse = Convert.ToBoolean(hadDUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine();
            int cspeedingTickets = Convert.ToInt32(speedingTickets);
            bool qualified = cyourAge > 15 && trueFalse == false && cspeedingTickets <= 3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
