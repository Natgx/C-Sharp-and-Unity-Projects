using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Math operation = new Math();
            Console.WriteLine("Give me a number to do a math operation on.");
            int numChosen = Convert.ToInt32(Console.ReadLine());
            int totalMul = Math.Multiplication(numChosen);
            Console.WriteLine("Here is the result after multiplyinh your given number with fifty: " + totalMul + "\n");
            Math divOp = new Math();
            Console.WriteLine("Now give me another number to do another operation on.");
            decimal numChosen2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Here is the result after dividing your given number by five: " + Math.Division(numChosen2) + "\n");
            Math addOp = new Math();
            Console.WriteLine("Now give me one number or text to do one last opertion on.");
            string userString = Console.ReadLine();
            int totalAdd = Math.Addition(userString);
            // PLEASE LOOK AT THIS
            // int totalAdd = addOp.Addition(userString); Why doesn't this work? Even though I have instantiated it.
            Console.WriteLine("Here is the result when adding your number/text with the number five: " + totalAdd);
            Console.ReadLine();
        }
    }
}
