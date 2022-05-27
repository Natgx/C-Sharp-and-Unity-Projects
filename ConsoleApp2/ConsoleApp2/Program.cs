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
            string[] stringArray = new string[5];
            Console.WriteLine("Type in a text to put in the array.");
            string putArray = Console.ReadLine();


            for(int i = 0; i < 5; i++)
            {
                stringArray[i] = putArray;
                Console.WriteLine("Add another text until you have added five texts.");
                putArray = Console.ReadLine();
            }
            for(int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
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
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(stringArray1[i]);
            }
            Console.ReadLine();

            int[] intArray = { 1, 2, 3, 4, 5 };
            for(int n = 0; n <= 2; n++)
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
            List<string> stringList1 = new List<string> { "This", "list", "of", "strings", "is", "strings" };
            Console.WriteLine("Pick a text from this list of strings(follow the capitalization): \n 1.This\n 2.list \n 3.of \n 4.strings \n 5.is \n 6.strings");
            string stringPicked1 = Console.ReadLine();
            bool trueOrFalse1 = false;
            foreach (string pick in stringList1)
                while (!trueOrFalse1)
                {
                    {
                        if (stringPicked1 == "This" || stringPicked1 == "list" || stringPicked1 == "of" || stringPicked1 == "strings" || stringPicked1 == "is" || stringPicked1 == "unique")
                        {
                            if (stringPicked1 != "strings")
                            {
                                Console.WriteLine("The index of the string you picked in the list is: " + stringList1.IndexOf(stringPicked1));
                                trueOrFalse1 = true;
                                break;
                            }
                            else if(stringPicked1 == "strings")
                            {
                                Console.WriteLine("The indeces of the string you picked is: " + stringList1.IndexOf(stringPicked1) + " and " + stringList1.LastIndexOf(stringPicked1));
                                trueOrFalse1 = true;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please only pick one of the choices listed above, make sure your capitalization is right.\n Please pick again:");
                            stringPicked1 = Console.ReadLine();
                            break;
                        }
                    }
                }
            Console.ReadLine();
            // END OF STEP 5

            // START OF STEP 6 (Not sure about this one, I feel that this has a mistake)
            List<string> stringList2 = new List<string>() {"Hello", "Hi", "Hello"};
            foreach(string find in stringList2)
            {
                if(find == "Hello")
                {
                    Console.WriteLine("This \"Hello\" appeared in the list 2 times.");
                }
                else if(find == stringList2[1])
                {
                    Console.WriteLine("This is the first time \"Hi\" appeared in the list.");
                }
            }
            Console.ReadLine();
            // END OF STEP 6
        }
    }
}
