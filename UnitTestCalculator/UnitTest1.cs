using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethodWithTwoPositiveNumbers()
        {
            string z = "a";
            double x = 2.0;
            double y = 3.0;
            double answer = x + y;
            double methodReturn = CalculatorLibrary.Calculator.DoOperation( x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestAddMethodWithTwoNegativeNumbers()
        {
            string z = "a";
            double x = -2.0;
            double y = -3.0;
            double answer = x + y;
            double methodReturn = CalculatorLibrary.Calculator.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestSubtractMethodWithTwoPositiveNumbers()
        {
            string z = "s";
            double x = 2.0;
            double y = 3.0;
            double answer = x - y;
            double methodReturn = CalculatorLibrary.Calculator.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestSubtractMethodWithTwoNegativeNumbers()
        {
            string z = "s";
            double x = -2.0;
            double y = -3.0;
            double answer = x - y;
            double methodReturn = CalculatorLibrary.Calculator.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestMultiplyMethodWithTwoPositiveNumbers()
        {
            string z = "m";
            double x = 2.0;
            double y = 3.0;
            double answer = x * y;
            double methodReturn = CalculatorLibrary.Calculator.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestMultiplyMethodWithTwoNegativeNumbers()
        {
            string z = "m";
            double x = -2.0;
            double y = -3.0;
            double answer = x * y;
            double methodReturn = CalculatorLibrary.Calculator.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestDivideMethodWithTwoPositiveNumbers()
        {
            string z = "d";
            double x = 2.0;
            double y = 3.0;
            double answer = x / y;
            double methodReturn = CalculatorLibrary.Calculator.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestDivideMethodWithTwoNegativeNumbers()
        {
            string z = "d";
            double x = -2.0;
            double y = -3.0;
            double answer = x / y;
            double methodReturn = CalculatorLibrary.Calculator.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestMultiplyMethodWithPositiveNumberAndZero()
        {
            string z = "m";
            double x = 2.0;
            double y = 0.0;
            double answer = x * y;
            double methodReturn = CalculatorLibrary.Calculator.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestDivideMethodWithZeroAsDividendAndPositiveNumber()
        {
            string z = "d";
            double x = 0.0;
            double y = 3.0;
            double answer = x / y;
            double methodReturn = CalculatorLibrary.Calculator.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
    }
}
