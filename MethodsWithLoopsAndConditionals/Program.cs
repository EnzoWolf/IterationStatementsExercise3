using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string runAgain;

            do
            {
                runAgain = PickAnOption();

            } while (runAgain == "y");

        }

        public static string PickAnOption()
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1: List all numbers between -1000 and 1000.");
            Console.WriteLine("2: Print all numbers in incremennts of 3 from 3 to 999.");
            Console.WriteLine("3: Compare two numbers to see if they are equal");
            Console.WriteLine("4: Check if a number is even or odd.");
            Console.WriteLine("5: Check if a number is negative or positive.");
            Console.WriteLine("6: Check if you're legal age to vote!");
            Console.WriteLine("7: Check if your number is between -10 and 10.");
            Console.WriteLine("8: Display the multiplication table of the entered number up to 12.\n");
            var userChoice = Convert.ToString(Console.ReadLine());

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("\nYou selectioned option 1: List all numbers between -1000 and 1000.\n");
                    PrintIncrementsOfThree(); // Call method to print all numbers from -1000 to 1000 in console
                    break;
                case "2":
                    Console.WriteLine("\nYou selectioned option 2: Print all numbers in incremennts of 3 from 3 to 999.\n");
                    PrintIncrementsOfThree(); // Call method to print numbers in increments of three up to 999 in console
                    break;
                case "3":
                    Console.WriteLine("\nYou selectioned option 3: Compare two numbers to see if they are equal\n");
                    CompareParameters(); // Call method to compare two numbers and check if they are equal or not
                    break;
                case "4":
                    Console.WriteLine("\nYou selectioned option 4: Check if a number is even or odd.\n");
                    CheckEvenOrOdd();
                    break;
                case "5":
                    Console.WriteLine("\nYou selectioned option 5: Check if a number is negative or positive.\n");
                    CheckNegativeOrPositive();
                    break;
                case "6":
                    Console.WriteLine("\nYou selectioned option 6: Check if you're legal age to vote!\n");
                    CheckVotingAge();
                    break;
                case "7":
                    Console.WriteLine("\nYou selectioned option 7: Check if your number is between -10 and 10.\n");
                    CheckRange();
                    break;
                case "8":
                    Console.WriteLine("\nYou selectioned option 8: Display the multiplication table of the entered number up to 12.\n");
                    MultiplicationTable();
                    break;
                default:
                    Console.WriteLine("\nYour entry is invalid.\n");
                    break;
            }

            Console.WriteLine("\nWould you like to pick another option? Y/N\n");
            var runProgram = Console.ReadLine();

            return runProgram.ToLower();

        }

        // Write a method that will print to the console all numbers 1000 through -1000.
        public static void PrintThousandsRange()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");

            }
        }

        // Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void PrintIncrementsOfThree()
        {
            for (int numThree = 3; numThree <= 999; numThree += 3)
            {
                Console.WriteLine(numThree);
            }


        }

        // Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void CompareParameters()
        {
            // Get the first number from the user and assign a variable to it
            Console.WriteLine("Enter a number: ");
            var firstNum = Convert.ToDouble(Console.ReadLine());

            // Get a second number from the user and assign a variable to it
            Console.WriteLine("Enter another number: ");
            var secondNum = Convert.ToDouble(Console.ReadLine());

            // Compare the numbers and output if its equal to or not
            var compareResults = (firstNum == secondNum) ? $"\r\n{firstNum} is equal to {secondNum}" : $"\r\n{firstNum} is not equal to {secondNum}";

            Console.WriteLine(compareResults);

        }

        // Write a method to check whether a given number is even or odd.
        public static void CheckEvenOrOdd()
        {
            Console.WriteLine("Enter a number:");
            var userNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine((userNumber % 2 == 0) ? $"{userNumber} is even." : $"{ userNumber} is odd.");

        }

        // Write a method to check whether a given number is positive or negative.
        public static void CheckNegativeOrPositive()
        {
            Console.WriteLine("Enter a number: ");
            var userNumber = Convert.ToDouble(Console.ReadLine());

            if (userNumber == 0)
            {
                Console.WriteLine($"{userNumber} is neither negative nor positive!");
            }
            else
            {
                Console.WriteLine((userNumber > 0) ? $"{userNumber} is positive" : $"{userNumber} is negative");
            }


        }

        // Write a method to read the age of a candidate and determine whether they can vote.
        // Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        public static void CheckVotingAge()
        {
            Console.WriteLine("How old are you?\n");
            int.TryParse(Console.ReadLine(), out int userAge);

            Console.WriteLine((userAge < 18) ? "\nYou are not old enough." : "\nYou're old enough to vote.");

        }

        // Write a method to check if an integer (from the user) is in the range -10 to 10.
        public static void CheckRange()
        {
            Console.WriteLine("Enter a number: \n");
            int.TryParse(Console.ReadLine(), out int userNumber);

            Console.WriteLine((userNumber <= 10 && userNumber >= -10) ? $"\n{userNumber} is within -10 and 10." : $"\n{userNumber} is not within -10 and 10.");

        }

        // Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter a number: \n");
            double.TryParse(Console.ReadLine(), out double userNumber);

            Console.WriteLine();

            for (int m = 1; m < 13; m++)
            {
                Console.WriteLine($"{m} * {userNumber} = {m * userNumber}");
            }

        }
    }
}
