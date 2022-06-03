using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClsAs
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        // public List<T> things { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Here is the full name of one of the employees:");
            Console.WriteLine(firstName + lastName);
        }
        
        public void Quit()
        {
            Console.WriteLine(firstName + lastName + " quitted yesterday.");
        }
        public static bool operator== (Employee Id, Employee Id2)
        {
            bool truth = Id.Id == Id2.Id;
            return truth;
        }
        public static bool operator!= (Employee Id, Employee Id2)
        {
            bool whut = Id.Id != Id2.Id;
            return whut;
        }
    }
}
