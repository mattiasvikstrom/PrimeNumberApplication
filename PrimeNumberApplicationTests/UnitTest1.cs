using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberApplicationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        [DataTestMethod]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(5)]
        [DataRow(97)]
        public void CheckPrimeIsTrueTest(int prime)
        {
            var result = PrimeNumberApplication.Prime.PrimeInputs.CheckPrime(prime);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        [DataTestMethod]
        [DataRow(10)]
        [DataRow(1)]
        [DataRow(default)]
        [DataRow(null)]
        public void CheckPrimeIsFalseTest(int prime)
        {
            var result = PrimeNumberApplication.Prime.PrimeInputs.CheckPrime(prime);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        [DataTestMethod]
        [DataRow("0")]
        [DataRow("-1")]
        [DataRow(default)]
        [DataRow(null)]
        public void UserInputNotEqualTest(string number)
        {
            var result = PrimeNumberApplication.Prime.PrimeInputs.UserInput(number);
            Assert.AreNotEqual(number, result);

        }
        [TestMethod()]
        [DataTestMethod]
        [DataRow("11")]
        [DataRow("10")]
        [DataRow("5")]
        [DataRow("97")]
        public void UserInputEqualTest(string number)
        {
            int convert = int.Parse(number);
            var result = PrimeNumberApplication.Prime.PrimeInputs.UserInput(number);
            Assert.AreEqual(convert, result);
            
        }

    }
}
