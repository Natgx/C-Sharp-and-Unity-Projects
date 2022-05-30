using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAs
{
    public class Divide
    {
        public void Division(int num1)
        {


            int newNum = num1 / 2;
            Console.WriteLine(newNum);
        }

        public void Division(int num2, out int timesDivided, int times = 1)
        {
            timesDivided = 0;
            for(int i = 0; i < times; i++)
            {
                timesDivided++;
                int newNum = num2 / 2;
                Console.WriteLine(newNum);
            }

        }
    }
}
