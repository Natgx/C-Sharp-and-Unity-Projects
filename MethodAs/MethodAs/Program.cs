using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAs
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamTry addMeth = new ParamTry();
            Console.WriteLine("Please give me two numbers to do a addition operation on, note that it is not required to give me the second number. \n");
            Console.WriteLine("What is the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now what is the second number:");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHere is the result when we add the number\\s you gave me:\n" + ParamTry.Addition(firstNum, secondNum));
            Console.ReadLine();
        }
    }
}
