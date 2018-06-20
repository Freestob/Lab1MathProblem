using System;

namespace Lab1MathProblem
{
    class Program
    {   
        // The purpose of this program is to Check if each corresponding place in the two numbers (ones, tens, hundreds, …)
        // sums to the same total.   
        static void Main(string[] args)
        {   
            // This portion of code calls upon the functoin to assign the value to the two ints
            
            int vEntryOne = GetNumberInput();
            int vEntryTwo = GetNumberInput();

            Console.WriteLine(vEntryOne + vEntryTwo);
            
        }
            static int GetNumberInput()
        {
            string userInput;
            int userNumber;

            Console.WriteLine("Please input a number.");
            userInput = Console.ReadLine();
            bool success = int.TryParse(userInput, out userNumber);

            if (success == true)
            {
                return userNumber;
            }
            else
            {
                Console.WriteLine("Please input a valid number.");
                return GetNumberInput();
            }

        }
            




    }
}
