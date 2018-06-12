using System;

namespace Lab1MathProblem
{
    class Program
    {
        static void Main(string[] args)

        // The purpose of this program is to Check if each corresponding place in the two numbers (ones, tens, hundreds, …)
        // sums to the same total.        

        {   // This is the string holding what the users input into the console prompt.
            string entryOne, entryTwo;

            // This section takes what the user has entered for the numbers and displays them back to the user.
            Console.WriteLine("Please enter the first number");
            entryOne = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            entryTwo = Console.ReadLine();

            Console.WriteLine("The numbers you entered are {0} and {1}.", entryOne, entryTwo);

            //This portion converts the numbers the user entered to actual numbers.

            var blockNumberOne = entryOne;
            var blockNumberTwo = entryTwo;

            //This portion selects the individual numbers in the var

            char cOneOne = entryOne[0];
            char cOneTwo = entryOne[1];
            char cOneThree = entryOne[2];

            char cTwoOne = entryTwo[0];
            char cTwoTwo = entryTwo[1];
            char cTwoThree = entryTwo[2];

            // This  portion converts the chars into ints

            var iOneOne = cOneOne - '0';
            var iOneTwo = cOneTwo - '0';
            var iOneThree = cOneThree - '0';

            var iTwoOne = cTwoOne - '0';
            var iTwoTwo = cTwoTwo - '0';
            var iTwoThree = cTwoThree - '0';

            Console.WriteLine(iOneOne+iTwoTwo);


                
            

           
        
            






        }





    }
}
