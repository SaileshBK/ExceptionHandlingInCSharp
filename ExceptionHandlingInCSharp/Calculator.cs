using System;

namespace ExceptionHandlingInCSharp
{
    public class Calculator
    {

        public int Calculate(int number1, int number2, string operation)
        {
            // had coding this exception to catch this exception.
            //throw new ArgumentNullException(paramName:nameof(operation));
            string nonNullOperation =
                operation?? throw new ArgumentNullException(nameof(operation));
            //if (operation == null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}
            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("....logging...");
                    //Log.Error(ex);

                    // example of correct way to re thrown exception.
                    //throw;
                    //throw new ArithmeticException("An error occured during calculation.",ex);
                    throw new CalculationException(ex);
                }
            }
            else
            {
                throw new CalculationOperationNotSupportedException(nonNullOperation);
                //throw new ArgumentOutOfRangeException(nameof(operation),"The mathematical operator is not supported.");
                //Console.WriteLine("Unknown Operation.");
                //return 0;
            }
            
        }

        private int Divide(int number, int divisor) =>  number / divisor;

    }
}