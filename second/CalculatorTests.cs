using NUnit.Framework;
using NUnit.Framework.Legacy;
using WindowsFormsApp_TPO_Lab_3;

namespace TestProject1
{
    [TestFixture]
    public class CalculatorTests
    {
        public Form1 calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Form1();
        }

        [Test]
        public void Add_AddsTwoNumbers_ReturnsCorrectSum()
        {
            double result = calculator.Add(5, 3);
            ClassicAssert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_SubtractsTwoNumbers_ReturnsCorrectDifference()
        {
            double result = calculator.Subtract(5, 3);
            ClassicAssert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_MultipliesTwoNumbers_ReturnsCorrectProduct()
        {
            double result = calculator.Multiply(5, 3);
            ClassicAssert.AreEqual(15, result);
        }

        [Test]
        public void Divide_DividesTwoNumbers_ReturnsCorrectQuotient()
        {
            double result = calculator.Divide(6, 3);
            ClassicAssert.AreEqual(2, result);
        }

        [Test]
        public void Divide_DivideByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
        }
    }
}