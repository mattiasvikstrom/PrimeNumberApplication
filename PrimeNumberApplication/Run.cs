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
                Console.ResetColor();

                switch (menuChoice)
                {
                    case "1":
                        PrimeInputSection();
                        break;
                    case "2":
                        ListPrimeNumbers();
                        break;
                    case "3":
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
                var results = UserInput();
                if (VerifyIfPositive(results))
                {
                    var check = CheckPrime(results);
                    if (check)
                    {
                        validated = true;
                    }
                }
                else
                {
                    validated = false;
                }
            } while (!validated);
        }
    }
}
