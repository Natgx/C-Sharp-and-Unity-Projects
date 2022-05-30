using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            voidMeth result = new voidMeth();
            Console.WriteLine("Please give me two numbers.\n");
            Console.WriteLine("What is the first number you would want to give me: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now what is the second number you would like to give me: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            result.twoNums(num1: firstNum, num2: secondNum);
            Console.ReadLine();
        }
    }
}
