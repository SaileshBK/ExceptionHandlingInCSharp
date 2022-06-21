using System;

namespace ExceptionHandlingInCSharp
{
    public class Calculator
    {

        public int calclator(int number1, int number2, string operation)
        {
            if (operation == "/")
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