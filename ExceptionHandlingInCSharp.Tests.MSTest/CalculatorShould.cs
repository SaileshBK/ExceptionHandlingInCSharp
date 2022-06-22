using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExceptionHandlingInCSharp.Tests.MSTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void ThrowWhenUnsupportedOperation()
        {
            // new instances of Calculator class for test.
            // sut - system under test.
            var sut = new Calculator();

            Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(10, 5, "+"));

            // checking exceptions was thrown but also get access to exception object, making further asserts against it.
            var ex = Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(10, 5, "+"));
            // making addition Asserts, checking that the operation is equals to +.
            Assert.AreEqual("+", ex.Operation);
        }
    }
}
