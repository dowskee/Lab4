using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)

        {
            bool Continue = true;
            while (Continue == true)
            {
                //design a program that prompts the user to enter an integer between 1 and 10

                //input
                long i, Input, fact;

                Console.WriteLine("Please enter an integer between 1 and 10:");
                Input = long.Parse(Console.ReadLine()); //reads user's input and parses 
                Console.WriteLine("You entered " + Input);
                fact = Input;
                //processing
                for (i = Input - 1; i >= 1; i--)   // example: 5! = 5*4*3*2*1 (n! = n*(n-1)...*1)
                {
                    //output
                    fact = (fact * i);
                }

                Console.WriteLine("The factorial of " + Input + " is: " + fact);
                Console.ReadLine();

                string Choice;
                Console.WriteLine("Would you like to enter another number? Y/N?");
                Choice = Console.ReadLine();
                if (Choice == "n" || Choice == "N" || Choice == "no" || Choice == "No")
                {
                    Continue = false;
                }
            }
        }
    }
}
