using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee() { firstName = "Sample ", lastName = "Student", Id = 4 };
            person.SayName();

            // Start of Polymorphism assignment
            //Console.WriteLine("\nHere is the name of one employee that quitted yesterday: ");
            //IQuittable quit = new Employee() { firstName = "I ", lastName = "Quit", Id = 5 };
            //quit.Quit();
            // End of Polymorphism assignment

            // Overloading operators assignment
            Employee person2 = new Employee() { firstName = "John ", lastName = "Cena", Id = 10 };
            person2.SayName();
            Console.WriteLine("\nDo the ID's of these two employees stated above match?");
            bool truth = person.Id == person2.Id;
            Console.WriteLine(truth);
            // End of Overloading operators assignment

            // Start of Generic Parameters Assignment
            //Employee<string> stringList = new Employee<string>();
            //stringList.things = new List<string>() { "These", "are", "strings" };
            //Employee<int> intList = new Employee<int>();
            //intList.things = new List<int>() { 1, 2, 3 };
            //foreach(string word in stringList.things)
            //{
            //    Console.WriteLine(word);
            //}
            //foreach(int number in intList.things)
            //{
            //    Console.WriteLine(number);
            //}
            // End of Generic Parameters Assignment

            //Start of Parsing Enums Assignment
            try
            {
                Console.WriteLine("\nPlease enter the current day of the week.");
                DaysofTheWeek newVar = (DaysofTheWeek)Enum.Parse(typeof(DaysofTheWeek), Console.ReadLine());

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
        public enum DaysofTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
