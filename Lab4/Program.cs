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
            //design a program that prompts the user to enter an integer between 1 and 10

            //input
            int Input, response;

            Console.WriteLine("Please enter an integer between 1 and 10:");
            Input = int.Parse(Console.ReadLine()); //reads user's input and parses 

            //processing
            for (int i = Input; i >= 1; i--) ; // example: 5! = 5*4*3*2*1 (n! = n*(n-1)...*1)
            response = (Input * Input); //*1 from comment above
            {
                if (Input >= 1 && Input <= 10) //ensure integer is in range
                { 
                Console.WriteLine("The factorial of " + Input + " is " + response);
                } 
                else
                
                    Console.WriteLine("That is not a valid integer. Please run again."); //find a way to loop? Do while with for?
               
            }
        }
    }
}
