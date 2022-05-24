using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAs
{
    class Program
    {
        static void Main(string[] args)
        {
            // START OF STRING ARRAY
            //string[] stringArray = { "Ruby", "Emerald", "Sapphire" };
            //Console.WriteLine("Please select an index from the string array which are numbers 0-2.");
            //int arrayNumber1 = Convert.ToInt32(Console.ReadLine());
            //if(arrayNumber1 == 0 || arrayNumber1 == 1 || arrayNumber1 == 2)
            //{
            //    Console.WriteLine("Here is the string: " + stringArray[arrayNumber1]);
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Please type in a number from 0 to 2.");
            //}
            //Console.ReadLine();
            // END OF STRING ARRAY (I could have use while string on this as well)

            // START OF INT ARAY (Could have used while statement to do the job better)
            //int[] intArray = { 5, 10, 15 };
            //Console.WriteLine("Now please type an index from numbers 0 to 2 again, so that we could display an int from the intArray.");
            //int arrayNumber2 = Convert.ToInt32(Console.ReadLine());
            //if(arrayNumber2 == 0 || arrayNumber2 == 1 || arrayNumber2 == 2)
            //{
            //    Console.WriteLine("Here is the number: " + intArray[arrayNumber2]);
            //}
            //else
            //{
            //    Console.WriteLine("Please choose from numbers 0 to 2");
            //}
            //Console.ReadLine();
            // END OF INT ARRAY

            List<string> listString = new List<string>();
            listString.Add("Hello");
            listString.Add("Hi");
            listString.Add("How do you do.");
            Console.WriteLine("Choose from numbers 0 to 2 to display a string from the list \"listString\".");
            int listNumber = Convert.ToInt32(Console.ReadLine());
            if(listNumber == 0 || listNumber == 1 || listNumber == 2)
            {
                Console.WriteLine("Here is the string of your choosing: " + listString[listNumber]);
            }
            else
            {
                Console.WriteLine("Please type in the numbers from 0 to 2.");
            }
            Console.ReadLine();
        }
    }
}
