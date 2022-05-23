using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAs
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the while statement
            //Console.WriteLine("Let's play a game, guess my favorite color.");
            //string color = Console.ReadLine();
            //bool rightColor = color == "green";
            //while(!rightColor)
            //{
            //    switch(color)
            //    {
            //        case "blue":
            //            Console.WriteLine("Nope blue is not the one.");
            //            break;
            //        case "red":
            //            Console.WriteLine("Nah red is not my favorite color");
            //            break;
            //        case "yellow":
            //            Console.WriteLine("Nope yellow is my second favorite color sorry.");
            //            break;
            //        case "green":
            //            Console.WriteLine("Yup that's the one!");
            //            break;
            //        default:
            //            Console.WriteLine("Keep Guessing");
            //            break;
            //}
            // End of while statement

            // This is the do while statement
            Console.WriteLine("Let's play a game, guess my favorite color.\n");
            bool rightColor = false;
            do
                {
                Console.WriteLine("What is it?");
                string color = Console.ReadLine();
                switch (color)
                    {
                        case "blue":
                            Console.WriteLine("Nope blue is not the one.\n");
                            break;
                        case "red":
                            Console.WriteLine("Nah red is not my favorite color\n");
                            break;
                        case "yellow":
                            Console.WriteLine("Nope yellow is my second favorite color sorry.\n");
                            break;
                        case "green":
                            Console.WriteLine("Yup that's the one!");
                            rightColor = true;
                            break;
                        default:
                            Console.WriteLine("Keep Guessing\n");
                            break;
                    }
                } 
                while (!rightColor);
                Console.ReadLine();
            }
        }
    }
// End of do while statement
