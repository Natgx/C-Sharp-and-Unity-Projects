using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide varDiv = new Divide();
            Console.WriteLine("Hello give me a whole number to divide it by 2.");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is the result after dividing your given number by 2:");
            varDiv.Division(givenNumber);

            int timesDivided = 0;
            Console.WriteLine("Now give me 2 numbers, one will be the number we're dividing and the other one will be how many times we're dividing it by 2.");
            int twoNumbers1 = Convert.ToInt32(Console.ReadLine());
            int twoNumbers2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is the result: ");
            varDiv.Division(twoNumbers1, out timesDivided, twoNumbers2);
            Console.WriteLine("As a reminder, this is how many times you wanted us to divide your given number: " + timesDivided);
            Console.ReadLine();
        }
    }
}
