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
            Employee person = new Employee() { firstName = "Sample ", lastName = "Student" };
            person.SayName();

            // Start of Polymorphism assignment
            Console.WriteLine("\nHere is the name of one employee that quitted yesterday: ");
            IQuittable quit = new Employee() { firstName = "I ", lastName = "Quit" };
            quit.Quit();
            // End of Polymorphism assignment
            Console.ReadLine();
        }
    }
}
