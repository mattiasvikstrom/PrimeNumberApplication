using System;
using System.Collections.Generic;
using System.Linq;
using static PrimeNumberApplication.Verify.Verify;

namespace PrimeNumberApplication.Prime
{
    public class PrimeInputs
    {
        /// <summary>
        /// List for all validated Prime numbers
        /// </summary>
        private static List<int> Prime = new();
        /// <summary>
        /// Takes user input and checks for validity.
        /// </summary>
        /// <returns>int</returns>
        public static int UserInput(string userInput)
        {
            var validation = VerifyIsNumber(userInput);
            if (!validation) return 0;
            var val = int.Parse(userInput);
            return val >= 0 ? val : 0;
        }
        /// <summary>
        /// Checks if entered number is Prime.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CheckPrime(int number)
        {
            if (number <= 1)
            {
                Console.WriteLine("Input cannot be negative, letters, 1 or 0 or decimals. please try again.\n");
                return false;
            }
            int m = number / 2;
            for (int i = 2; i <= m; i++)
            {
                if (number % i != 0) continue;
                Console.Write("Number is not Prime.\n");
                return false;
            }
            Console.Write("Number is Prime.\n");
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
            AddPrimeNumber(NextPrimeNumber(highestPrime));
        }
        /// <summary>
        /// Proceeds to check for next available Prime number from the largest available number in list.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static int NextPrimeNumber(int number)
        {
            while (true)
            {
                bool isPrime = true;
                number++;
                switch (number)
                {
                    case 1:
                        {
                            isPrime = false;
                            break;
                        }
                    case 2:
                        {
                            isPrime = true;
                            break;
                        }
                }
                int squared = (int)Math.Sqrt(number);
                if (isPrime)
                {
                    for (var i = 2; i <= squared; i++)
                    {
                        if (number % i != 0) continue;
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    return number;
                }
            }
        }
        /// <summary>
        /// Adds Primary number to list if it does not already exist in said list.
        /// </summary>
        /// <param name="number"></param>
        private static void AddPrimeNumber(int number)
        {
            if (Prime.Contains(number))
            {
                Console.WriteLine($"Prime number {number} is already in list\n");
            }
            else
            {
                Prime.Add(number);
                Console.WriteLine($"Next prime number {number} added to list\n");
                Prime.Sort();
            }
        }
        /// <summary>
        /// Prints list of current added Primary numbers
        /// </summary>
        public static void ListPrimeNumbers()
        {
            var count = Prime.Count;
            if(Prime.Count > 0)
            {
                Console.WriteLine($"Number of entry's in list: {count}");
                foreach (var item in Prime)
                {
                    Console.WriteLine($"{item}\n");
                }
            }
            else
            {
                Console.WriteLine("No values yet in list");
            }
        }
    }
}
