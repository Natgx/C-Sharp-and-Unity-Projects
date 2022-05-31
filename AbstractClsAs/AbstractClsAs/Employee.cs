using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClsAs
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Here is the full name of the employee:");
            base.SayName();
        }
        

        
    }
}
