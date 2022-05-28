using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAs
{
    public class Math
    {
        public static int Addition(int num1)
        {
            int newNum = num1 + 10;
            return newNum;
        }
        public static int Subtraction(int num2)
        {
            int newNum = num2 - 10;
            return newNum;
        }
        public static int Multiplication(int num3)
        {
            int newNum = num3 * 10;
            return newNum;
        }
    }
}
