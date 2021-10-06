using System;
using System.Collections.Generic;
using System.Linq;
using static PrimeNumberApplication.Verify.Verify;

namespace PrimeNumberApplication.Prime
{
    class PrimeInputs
    {
        private static List<int> Prime = new();
        /// <summary>
        /// Takes user input and checks for validity.
        /// </summary>
        /// <returns></returns>
        public static int UserInput()
        {
            Console.WriteLine("Enter number");
            var userInput = Console.ReadLine();
            var validation = VerifyIsNumber(userInput);
            return validation ? int.Parse(userInput ?? string.Empty) : default;
        }
        /// <summary>
        /// Checks if entered number is Prime.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CheckPrime(int number)
        {
            int i, m = 0;
            if (number is 0 or 1)
            {
                return false;
            }
            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i != 0) continue;
                Console.Write("Number is not Prime.");
                return false;
            }
            Console.Write("Number is Prime.");
            AddPrimeNumber(number);
            return true;
        }
        /// <summary>
        /// Located largest Prime number already added to list
        /// </summary>
        public static void LocateHighestPrimeInList()
        {
            var highestPrime = 0;
            if (Prime.Count > 0)
            {
                highestPrime = Prime.Max(t => t);
            }
            var nextPrime = NextPrimeNumber(highestPrime);
            AddPrimeNumber(nextPrime);
        }
        /// <summary>
        /// Proceeds to check for next avaliable Prime number from the largest avaliable number in list.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int NextPrimeNumber(int number)
        {
            while (true)
            {
                bool isPrime = true;

                number += 1;
                if (number == 1)
                {
                    isPrime = false;
                }
                if (number == 2)
                {
                    isPrime = true;
                }

                int squared = (int)Math.Sqrt(number);

                if (isPrime && number != 2)
                {
                    for (var i = 2; i <= squared; i++)
                    {
                        if (number % i != 0) continue;
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    return number;
            }
        }
        /// <summary>
        /// Adds Primary number to list if it does not already exist in said list.
        /// </summary>
        /// <param name="number"></param>
        private static void AddPrimeNumber(int number)
        {
            if(Prime.Contains(number))
                Console.WriteLine($"Prime number {number} is already in list");
            else
            {
                Prime.Add(number);
                Console.WriteLine($"{number} added");
            }
            Prime.Sort();
        }
        /// <summary>
        /// Prints list of current added Prime numbers from list.
        /// </summary>
        public static void ListPrimeNumbers()
        {
            foreach (var item in Prime)
            {
                Console.WriteLine($"{item}\n");
            }
        }
    }
}
