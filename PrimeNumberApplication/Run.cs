using System;
using static PrimeNumberApplication.Prime.PrimeInputs;
using static PrimeNumberApplication.Verify.Verify;

namespace PrimeNumberApplication
{
    class Run
    {
        /// <summary>
        /// Initializes the main menu
        /// </summary>
        public static void Menu()
        {
            var activeProgram = false;
            do
            {
                Console.WriteLine("\n**************************************\n" +
                                  "* 1. Enter numbers\n" +
                                  "* 2. List prime numbers\n" +
                                  "* 3. Give me the next prime number\n" +
                                  "* 5. Exit\n" +
                                  "**************************************\n");
                Console.Write(">> ");
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.Clear();
                        PrimeInputSection();
                        break;
                    case "2":
                        Console.Clear();
                        ListPrimeNumbers();
                        break;
                    case "3":
                        Console.Clear();
                        LocateHighestPrimeInList();
                        break;
                    case "5":
                        activeProgram = true;
                        break;
                }
                
            } while (!activeProgram);
        }
        /// <summary>
        /// section for user inputs.
        /// </summary>
        private static void PrimeInputSection()
        {
            bool validated = false;
            do
            {
                Console.WriteLine("Enter number");
                var userInput = Console.ReadLine();
                var results = UserInput(userInput);
                if (results < int.MaxValue)
                {
                    var check = CheckPrime(results);
                    if (check)
                    {
                        validated = true;
                    }
                }
            } while (!validated);
        }
    }
}
