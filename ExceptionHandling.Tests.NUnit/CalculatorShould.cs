using NUnit.Framework;

namespace ExceptionHandlingInCSharp.Tests.NUnit
{
    public class CalculatorShould
    {

        [Test]
        // we are testing here that calculator throws an Unsupported Operation Exception.
        public void ThrowWhenUnsupportedOperation()
        {
            // new instances of Calculator class for test.
            // sut - system under test.
            var sut = new Calculator();
            Assert.That(() => sut.Calculate(10, 2, "+"),
                Throws.TypeOf<CalculationOperationNotSupportedException>());

            // testing the thrown Exception has correct property.
            Assert.That(() => sut.Calculate(10, 2, "+"),
                Throws.TypeOf<CalculationOperationNotSupportedException>()
                .With
                .Property("Operation").EqualTo("+"));

            // checking exceptions was thrown but also get access to exception object, making further asserts against it.
            var ex = Assert.Throws< CalculationOperationNotSupportedException > (() => sut.Calculate(10, 2, "+"));
            // checking that the operation is equals to +.
            Assert.That(ex.Operation, Is.EqualTo("+"));

            // Note: Exception type has to match.

            // Throws.InstanceOf will pass if the exception is specified exception or derived type.
            // This takes an account of exceptions inheritance hierarchy.
            Assert.That(() => sut.Calculate(10, 2, "+"),
                Throws.InstanceOf<CalculationException>());
        }
    }
}