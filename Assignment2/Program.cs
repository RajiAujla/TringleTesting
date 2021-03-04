using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuValidate = false,inputValid = false;
            int side1, side2, side3;

            Console.WriteLine("Assignment 2 Solution");
            Console.WriteLine("-----------------------------------------\n");
            do
            {
                Console.WriteLine(" 1. Enter triangle dimensions: \n 2. Exit \n");
                Console.Write("Please select any option from menu: ");
                string menu = Console.ReadLine();
                int menuInteger;
                bool success = Int32.TryParse(menu, out menuInteger);

                if(success == true)
                {
                    if (menuInteger == 1 || menuInteger == 2)
                    {
                        menuValidate = true;
                        if (menuInteger == 1)
                        {
                            do
                            {
                                Console.Write("\n Enter triangle First Side: ");
                                string firstSide = Console.ReadLine();

                                Console.Write("\n Enter triangle Second Side: ");
                                string secondSide = Console.ReadLine();

                                Console.Write("\n Enter triangle Third Side: ");
                                string thirdSide = Console.ReadLine();

                                bool success1 = Int32.TryParse(firstSide, out side1);
                                bool success2 = Int32.TryParse(secondSide, out side2);
                                bool success3 = Int32.TryParse(thirdSide, out side3);

                                if (success1 == true && success2 == true && success3 == true)
                                {
                                    inputValid = true;
                                    string triangleOutput =  TriangleSolver.Analyze(side1, side2, side3);
                                    Console.WriteLine(triangleOutput);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("\nYou did a mistake!! please enter a integer value");
                                }
                            } while (inputValid == false);

                        }
                        else if (menuInteger == 2)
                            Environment.Exit(0);
                    }
                } else {
                    Console.WriteLine("\nYou did a mistake!! please enter a integer value for menu");
                } 
            } while (menuValidate == false);
        }
    } 
}
