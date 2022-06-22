using System;

namespace ExceptionHandlingInCSharp
{
    public class CalculationException : Exception
    {
        private const string DefaultMessage = "A custome message saying, an error has occured please make sure the value are in expected range.";

        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a predefined message.
        /// </summary>

        public CalculationException() : base(DefaultMessage)
        {
            

        }
        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with user supplied message.
        /// </summary>
        public CalculationException(string message) : base(message)
        {

        }
        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a predefined message and a wrapper inner exception.
        /// </summary>

        public CalculationException(Exception innerException) : base(DefaultMessage,innerException)
        {

        }
        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with a user-supplied message and a wrapper inner exception.
        /// </summary>
        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
