using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> stringList = new Employee<string>();
            stringList.things = new List<string>() { "These", "are", "strings" };
            Employee<int> intList = new Employee<int>();
            intList.things = new List<int>() { 1, 2, 3 };
            foreach (string word in stringList.things)
            {
                Console.WriteLine(word);
            }
            foreach (int number in intList.things)
            {
                Console.WriteLine(number);
            }
            // End of Generic Parameters Assignment
            Console.ReadLine();

        }
    }
}
