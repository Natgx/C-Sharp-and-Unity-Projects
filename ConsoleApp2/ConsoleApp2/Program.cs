using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            // START OF STEP 1
            string[] stringArray = new string[] { "This", "is", "a", "string" };
            Console.WriteLine("Please input a text to add to each word in the array: ");
            string addedWord = Console.ReadLine();
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += addedWord;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Here are the new contents of the array: ");
            foreach (string each in stringArray)
            {
                Console.WriteLine(each);
            }
            Console.ReadLine();
            // END OF STEP 1

            // START OF STEP 2
            // Start of Infinite Loop
            //Console.WriteLine("This is an infinite loop.");
            //bool infinite = false;
            //while(infinite == false)
            //{
            //    Console.WriteLine("Let's Gooooooooooooooo");
            //}
            // End of Infinite Loop

            // Fixed Infinite Loop
            Console.WriteLine("This is not an infinite loop.");
            bool infinite = false;
            while (infinite == false)
            {
                Console.WriteLine("Let's Gooooooooooooooo?");
                break;
            }
            Console.ReadLine();
            // END OF STEP 2

            // START OF STEP 3
            string[] stringArray1 = { "Nat", "Tan", "Mat", "Ton" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stringArray1[i]);
            }
            Console.ReadLine();

            int[] intArray = { 1, 2, 3, 4, 5 };
            for (int n = 0; n <= 2; n++)
            {
                Console.WriteLine(intArray[n]);
            }
            Console.ReadLine();
            // END OF STEP 3

            // START OF STEP 4
            List<string> stringList = new List<string> { "This", "list", "of", "strings", "is", "unique" };
            Console.WriteLine("Pick a text from this list of strings(follow the capitalization): \n 1.This\n 2.list \n 3.of \n 4.strings \n 5.is \n 6.unique");
            string stringPicked = Console.ReadLine();
            bool trueOrFalse = false;
            foreach (string pick in stringList)
                while (!trueOrFalse)
                {
                    {
                        if (stringPicked == "This" || stringPicked == "list" || stringPicked == "of" || stringPicked == "strings" || stringPicked == "is" || stringPicked == "unique")
                        {
                            Console.WriteLine(stringList.IndexOf(stringPicked));
                            trueOrFalse = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please only pick one of the choices listed above, make sure your capitalization is right.\n Please pick again:");
                            stringPicked = Console.ReadLine();
                            break;
                        }
                    }
                }
            Console.ReadLine();

            // END OF STEP 4

            // START OF STEP 5
            List<string> stringList1 = new List<string> { "This", "list", "is", "a", "string", "list" };
            Console.WriteLine("Pick a word from these choices(Follow the capitalization):");
            foreach (string each in stringList1)
            {
                Console.WriteLine("- " + each);
            }
            Console.WriteLine("What is your choice:");
            string choice = Console.ReadLine();
            if (!stringList1.Contains(choice))
            {
                Console.WriteLine("Please choose from the choices above and follow the right capitalization.");
            }
            else
            {


                for (int i = 0; i < stringList1.Count; i++)
                {
                    if (choice == stringList1[i])
                    {
                        Console.WriteLine("The index of your chosen word in the list is: " + stringList1.IndexOf(choice));
                    }
                    else if (choice == "list")
                    {
                        Console.WriteLine("The indeces of your chosen word in the list is: " + stringList1.IndexOf(choice) + " and " + stringList1.LastIndexOf(choice));
                        break;
                    }
                }
            }
            Console.ReadLine();
            // END OF STEP 5

            // START OF STEP 6
            List<string> stringList2 = new List<string> { "Oh", "no", "Oh" };
            List<string> stringList3 = new List<string> { };
            foreach (string each in stringList2)
            {
                if (stringList3.Contains(each))
                {
                    Console.WriteLine("This has appeared in the list already");
                }
                else
                {
                    Console.WriteLine("This has not appeared in the list yet.");
                    stringList3.Add(each);
                }
            }
            Console.ReadLine();
            // END OF STEP 6
        }
    }
}
