using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAs
{
    public class ParamTry
    {
        public static int Addition(int num1, int num2 = 1)
        {
            int newNum = num1 + num2;
            return newNum;
        }
    }
}
