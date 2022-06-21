using System;

namespace ExceptionHandlingInCSharp
{
    class CalculationExceptionNotSupportedException : CalculationException
    {
        private const string DefaultMessage = "Specified operation was out of range of valid values.";

        public string Operation { get; }

        /// <summary>
        /// Creates a new <see cref="CalculationExceptionNotSupportedException"/> with a predefined message.
        /// </summary>
        public CalculationExceptionNotSupportedException() : base(DefaultMessage)
        {

        }

        /// <summary>
        /// Creates a new <see cref="CalculationExceptionNotSupportedException"/> with a predefined message and a wrapper inner exception.
        /// </summary>
        public CalculationExceptionNotSupportedException(Exception innerException) : base(DefaultMessage, innerException)
        {

        }


        /// <summary>
        /// Creates a new <see cref="CalculationExceptionNotSupportedException"/> with a user supplied message and a wrapper inner exception.
        /// </summary>
        public CalculationExceptionNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {

        }

        /// <summary>
        /// Creates a new <see cref="CalculationExceptionNotSupportedException"/> with a default message and a operation that is not supported.
        /// </summary>
        public CalculationExceptionNotSupportedException(string operation) : base(DefaultMessage) => Operation = operation;

        /// <summary>
        /// Creates a new <see cref="CalculationExceptionNotSupportedException"/> with a operation that is not supported and a user supplied message.
        /// </summary>
        public CalculationExceptionNotSupportedException(string operation, string message) : base(message) => Operation = operation;

        // we can also override the ToString() method.

        public override string ToString()
        {
            if (Operation == null)
            {
                return base.ToString();
            }
            return base.ToString() + Environment.NewLine + $"Unsupported operation: {Operation}";
        }





    }
}







