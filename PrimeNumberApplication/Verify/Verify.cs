using System;

namespace PrimeNumberApplication.Verify
{
    class Verify
    {
        /// <summary>
        /// Checks if the string is indeed parable to int
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool VerifyIsNumber(string number)
        {
            return int.TryParse(number,out _);
        }
        /// <summary>
        /// Checks if number input is positive
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool VerifyIfPositive(int number)
        {
            return number >= 0;
        }
    }
}
