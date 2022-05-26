using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>() { 100, 200, 300, 400, 500 };
                Console.WriteLine("Write in a number to divide each number in the list with that number.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < intList.Count; i++)
                {
                    Console.WriteLine(intList[i] / userNumber);
                }
                Console.ReadLine();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a whole number, not a string.");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Don't divide these numbers by zero please.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and has continued on with program execution.");
                Console.ReadLine();
            }
        }
    }
}
