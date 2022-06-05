using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAs
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;
            Console.WriteLine("This is the current date and time: " + timeNow);
            Console.WriteLine("Now give me a number.");
            int givenNum = int.Parse(Console.ReadLine());
            DateTime timeGiven = timeNow.AddHours(givenNum);
            Console.WriteLine("Here is the date and time after adding the number you gave me to the hours of the current date: \n" + timeGiven);
            Console.ReadLine();
        }
    }
}
