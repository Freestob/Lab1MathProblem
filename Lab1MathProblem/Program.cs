using System;
using System.Collections.Generic;

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

            //Console.WriteLine(vEntryOne + vEntryTwo);

            int[] arrayOne = UserNumberToArray(vEntryOne);
            int[] arrayTwo = UserNumberToArray(vEntryTwo);

            int numberOne = arrayOne[0] + arrayTwo[0];
            // I have two arrays. I need to find the sum of each digit in the arrays
            // "123", "321"
            // [1, 2, 3]
            // [3, 2, 1]
            //  4  4  4

            // "545", "7232"
            //    [5, 4, 5]
            // [7, 2, 3, 2]
            //  7  7  7  7




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
                if (userNumber < 0)
                {
                    Console.WriteLine("Please input a positve number");
                    return GetNumberInput();
                }

                return userNumber;
            }
            else
            {
                Console.WriteLine("Please input a valid number.");
                return GetNumberInput();
            }

        }
        // This function takes the user entered number and separates it into an array.

        static int[] UserNumberToArray(int number)
        {
            // The number runs through a loop that ends when the number eventually equals zero. While running through the loop the
            // function saves the remainder of each number when it is divided by 10. It then sets the new value of the number to 
            // be equal to itselve divded by 10 and removing the remainder. This works because int does not store numbers in the 
            // decimal place.

            List<int> numberArray = new List<int>();
            while (number > 0)
            {
                numberArray.Add(number % 10);
                number /= 10;
            }
            return numberArray.ToArray();
        }



    }
}
