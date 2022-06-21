using System;

namespace ExceptionHandlingInCSharp
{
    public class Calculator
    {

        public int calculate(int number1, int number2, string operation)
        {
            string nonNullOperation =
                operation?? throw new ArgumentNullException(nameof(operation));
            //if (operation == null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}
            if (nonNullOperation == "/")
            {
                return Divide(number1, number2);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation),"The mathematical operator is not supported.");
                //Console.WriteLine("Unknown Operation.");
                //return 0;
            }
            
        }

        private int Divide(int number, int divisor) =>  number / divisor;

    }
}