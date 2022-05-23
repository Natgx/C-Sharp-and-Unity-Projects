using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate = Console.ReadLine();
            int chourlyRate = Convert.ToInt32(hourlyRate);
            Console.WriteLine("Hours worked per week?");
            string hoursWorked = Console.ReadLine();
            int choursWorked = Convert.ToInt32(hoursWorked);
            Console.WriteLine("\n");
            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            int chourlyRate2 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("Hours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            int choursWorked2 = Convert.ToInt32(hoursWorked2);
            Console.WriteLine("\n");
            int annualSalary1 = ((chourlyRate * choursWorked) * 4) * 12;
            Console.WriteLine("Annual Salary of Person 1:\n" + annualSalary1);
            int annualSalary2 = ((chourlyRate2 * choursWorked2) * 4) * 12;
            Console.WriteLine("\n");
            Console.WriteLine("Annual Salary of Person 2:\n" + annualSalary2);
            Console.WriteLine("\n");
            bool trueFalse = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + trueFalse.ToString());
            Console.ReadLine();
        }
    }
}
