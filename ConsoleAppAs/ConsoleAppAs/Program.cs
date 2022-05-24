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
            bool rightColor = false;
            
            
                Console.WriteLine("Let's play a game, guess my favorite color.");
                string color = Console.ReadLine();
                    while (!rightColor)
                    switch (color)
                            {
                                case "blue":
                                    Console.WriteLine("Nope blue is not the one.");
                                    color = Console.ReadLine();
                                    break;
                                case "red":
                                    Console.WriteLine("Nah red is not my favorite color");
                                        color = Console.ReadLine();
                                    break;
                                case "yellow":
                                    Console.WriteLine("Nope yellow is my second favorite color sorry.");
                                        color = Console.ReadLine();
                                    break;
                                case "green":
                                    Console.WriteLine("Yup that's the one!");
                                        color = Console.ReadLine();
                                    rightColor = true;
                                    break;
                                default:
                                    Console.WriteLine("Keep Guessing");
                                        color = Console.ReadLine();
                                    break;
                            }
                // End of while statement

                // This is the do while statement
                //Console.WriteLine("Let's play a game, guess my favorite color.\n");
                //bool rightColor = false;
                //do
                //    {
                //    Console.WriteLine("What is it?");
                //    string color = Console.ReadLine();
                //    switch (color)
                //        {
                //            case "blue":
                //                Console.WriteLine("Nope blue is not the one.\n");
                //                break;
                //            case "red":
                //                Console.WriteLine("Nah red is not my favorite color\n");
                //                break;
                //            case "yellow":
                //                Console.WriteLine("Nope yellow is my second favorite color sorry.\n");
                //                break;
                //            case "green":
                //                Console.WriteLine("Yup that's the one!");
                //                rightColor = true;
                //                break;
                //            default:
                //                Console.WriteLine("Keep Guessing\n");
                //                break;
                //        }
                //    } 
                //    while (!rightColor);
                //    Console.ReadLine();
            
        }
    }
}
// End of do while statement
