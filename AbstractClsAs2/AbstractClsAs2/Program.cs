using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClsAs2
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
            Employee person2 = new Employee() { firstName = "John ", lastName = "Cena ", Id = 5 };
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
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Start of Lambda Assignment
            Employee person3 = new Employee() { firstName = "Nathaniel ", lastName = "Noel ", Id = 23 };
            Employee person4 = new Employee() { firstName = "Pamela ", lastName = "Martinex ", Id = 15 };
            Employee person5 = new Employee() { firstName = "Michael ", lastName = "Jackson ", Id = 24 };
            Employee person6 = new Employee() { firstName = "Jacob ", lastName = "Borja ", Id = 25 };
            Employee person7 = new Employee() { firstName = "Faye ", lastName = "Garley ", Id = 26 };
            Employee person8 = new Employee() { firstName = "Ruby ", lastName = "Stone ", Id = 27 };
            Employee person9 = new Employee() { firstName = "John ", lastName = "Stewart ", Id = 28 };
            Employee person10 = new Employee() { firstName = "Joseph ", lastName = "Macarel ", Id = 29 };
            List<Employee> empList = new List<Employee>() { person, person2, person3, person4, person5, person6, person7, person8, person9, person10 };
            List<Employee> addedList = new List<Employee>();
            Console.WriteLine("Here I show you employees with the first name \"John\" using a foreach loop:");
            foreach (Employee pers in empList)
            {
                if (pers.firstName == "John ")
                {
                    addedList.Add(pers);
                }
            }
            foreach (Employee emp in addedList)
            {
                Console.WriteLine(emp.firstName + emp.lastName + emp.Id);
            }

            Console.WriteLine("\nHere I show you employees with the first name \"John\" using a Lambda Expression:");
            List<Employee> addedList2 = empList.Where(x => x.firstName == "John ").ToList();
            foreach (Employee pers in addedList)
            {
                Console.WriteLine(pers.firstName + pers.lastName + pers.Id);
            }

            Console.WriteLine("\nHere I show you all employees with a Id number greater than 5 while also using a Lambda Expression:");
            List<Employee> idList = empList.Where(x => x.Id > 5).ToList();
            foreach (Employee emp in idList)
            {
                Console.WriteLine(emp.firstName + emp.lastName + emp.Id);
            }

            // End of Lambda Assignment
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
}
