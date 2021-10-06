using System;

namespace PrimeNumberApplication.Verify
{
    class Verify
    {
        /// <summary>
        /// Checks if the string is indeed parsable to int
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool VerifyIsNumber(string number)
        {
            var result = int.TryParse(number,out _);
            return result;
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
