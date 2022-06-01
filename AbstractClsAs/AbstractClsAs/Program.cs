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
            Console.ReadLine();
        }
    }
}
