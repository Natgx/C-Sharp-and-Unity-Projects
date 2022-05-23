using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int cpageNumber = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything ? Please answer “true” or “false.”");
            string needHelp = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            int choursStudy = Convert.ToInt32(hoursStudy);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This is the end of the program.");
            Console.ReadLine();
        }
    }
}
