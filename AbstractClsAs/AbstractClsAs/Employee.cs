using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClsAs
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Here is the full name of one of the employee:");
            Console.WriteLine(firstName + lastName);
        }
        
        public void Quit()
        {
            Console.WriteLine(firstName + lastName + " quitted yesterday.");
        }
        
    }
}
