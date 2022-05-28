using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAs
{
    public class Math
    {
        public static int Multiplication(int num1)
        {
            int newNum = num1 * 50;
            return newNum;
        }
        public static decimal Division(decimal num2)
        {
            decimal newNUm = num2 / 5;
            return newNUm;
        }
        public static int Addition(string num3)
        {
            int newNum = Convert.ToInt32(num3);
            int newNum2 = newNum + 5;
            return newNum2;
        }
    }
}
