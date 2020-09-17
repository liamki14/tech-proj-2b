//Author:Liam  K Kelly
//Date: 9/17/2020
//Description: Tech Project 2b. Using conditional statements

using System;

namespace Tech_Proj_2b
{
    class Program
    {
        static void Main(string[] args)
        {
                      
           
            Console.WriteLine("What grade do you expect to get in ISM 4300? Please enter an integer out of 100.");
            try
            {
                string input = Console.ReadLine();
                decimal grade = decimal.Parse(input);
                


                if (grade >= 90)
                {
                    Console.WriteLine("A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }

            }
            catch
            {
                Console.WriteLine("Please use an integer.");
            }
        }
    }
}
