using System;

namespace Lab1MathProblem
{
    class Program
    {
        static void Main(string[] args)

        // The purpose of this program is to Check if each corresponding place in the two numbers (ones, tens, hundreds, …)
        //sums to the same total.        

        {   // This is the string holding what the users input into the console prompt.
            string numberOne, numberTwo;
            // This section takes what the user has entered for the numbers and displays them back to the user.
            Console.WriteLine("Please enter the first number");
            numberOne = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            numberTwo = Console.ReadLine();

            Console.WriteLine("The numbers you entered are {0} and {1}.", numberOne, numberTwo);
        }





    }
}
