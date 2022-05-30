using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClsAs
{
    public class voidMeth
    {
        public void twoNums(int num1, int num2)
        {
            int newNum = num1 - 1;
            Console.WriteLine("Here is the first number you gave me subtracted by one: " + newNum + "\nThis is the second number you gave me that I did nothing with: " + num2);
        }
    }
}
