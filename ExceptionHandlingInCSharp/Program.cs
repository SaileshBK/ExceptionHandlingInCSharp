using System;
using static System.Console;
namespace ExceptionHandlingInCSharp
{
    class Program 
    {
        static void Main(string[] args)
        {
            // here we have used using static System.Console; to get access to console prefix.
            WriteLine("Please enter first number:");
            int number1 = int.Parse(ReadLine());

            WriteLine("Please enter second number:");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter Operation:");
            string operation = ReadLine().ToUpperInvariant();

            var calculator = new Calculator();
            
            try
            {
                int result = calculator.calclator(number1, number2, operation);
                DisplayResult(result);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                //Log.Error(ex);
                WriteLine($"Opration is not supported. {ex}");
            }
            catch (ArgumentNullException ex)
            {
                //Log.Error(ex);
                WriteLine($"operation was not provided. {ex}");
            }
            catch (Exception ex)
            {
                WriteLine($"Sorry, Something went wrong. {ex}");

            }
            // The use of finally block is to make sure we clean up anything whether not an exception occurs.
            finally
            {
                WriteLine("...Finally...");
            }
            

            WriteLine("Press enter to exit.");
            ReadLine();

            
        }

        private static void DisplayResult(int result) => WriteLine($"The result is : {result}");
        
    }
}
