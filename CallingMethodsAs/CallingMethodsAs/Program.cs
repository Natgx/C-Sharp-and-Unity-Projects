using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, give me a number to do a math operation on.");
            int numChosen = Convert.ToInt32(Console.ReadLine());
            int totalAdd = Math.Addition(numChosen);
            int totalSub = Math.Subtraction(numChosen);
            int totalMul = Math.Multiplication(numChosen);
            Console.WriteLine("Here is the solution when we added the number you gave with 10.");
            Console.WriteLine(totalAdd + "\n");
            Console.WriteLine("Here is the solution when we subtracted the number you gave with 10.");
            Console.WriteLine(totalSub + "\n");
            Console.WriteLine("Here is the solution when we multiplied the number you gave with 10");
            Console.WriteLine(totalMul);
            Console.ReadLine();
        }
    }
}
