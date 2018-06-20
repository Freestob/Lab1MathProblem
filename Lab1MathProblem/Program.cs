using System;
using System.Collections.Generic;

namespace Lab1MathProblem
{
    class Program
    {
        // The purpose of this program is to check if each corresponding place in the two numbers (ones, tens, hundreds, …)
        // sums to the same total.   
        static void Main(string[] args)
        {
            Console.WriteLine("This program will ask you to enter two numbers.");
            Console.WriteLine();
            Console.WriteLine("It will check to see if the corresponding number places (ones, tens, etc) sum to the same total");
            Console.WriteLine();
            // This portion of code calls upon the function to assign the value to the two ints

            int vEntryOne = GetNumberInput();
            int vEntryTwo = GetNumberInput();

            // This portion calls upon the function to transform the ints into an array
            int[] arrayOne = UserNumberToArray(vEntryOne);
            int[] arrayTwo = UserNumberToArray(vEntryTwo);

           
            // This portion sets a new int called sum to the 0th number in each array as the standard. It then has a new interger
            // that runs through a loop to compare itself to sum. If at anytime the two ints != each other the program prints false.
            // If the loop never returns false it prints true.
            int sum;
            sum = arrayOne[0] + arrayTwo[0];

            int index = 0;
            while (index < arrayOne.Length)
            {
                int nextSum = arrayOne[index] + arrayTwo[index];
                if (nextSum != sum)
                {
                    Console.WriteLine("False");
                    return;
                }

                index = index + 1;
                
            }
            Console.WriteLine("True");

        }

        // This function converts the string the user enters into an int. If the user inputs something that cannot be converted
        // into an int it asks the user to input a valid number. If the number is negative it also asks the user to input a positive
        // number.
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
