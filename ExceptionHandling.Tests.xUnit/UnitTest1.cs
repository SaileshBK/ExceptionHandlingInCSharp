using System;
using Xunit;

namespace ExceptionHandlingInCSharp.Tests.xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(10, 5, "+"));

            // This fails because the Assert.Throws method expects the exact exception.
            //Assert.Throws<CalculationException>(() => sut.Calculate(10, 5, "+"));

            // This allows derived exception type.
            Assert.ThrowsAny<CalculationException>(() => sut.Calculate(10, 5, "+"));

            // can also perform additional Asserts against a variable.
            var ex = Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(10, 5, "+"));
            Assert.Equal("+", ex.Operation);
        }
    }
}
