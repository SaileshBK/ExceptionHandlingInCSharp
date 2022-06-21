using System;
using static System.Console;
namespace ExceptionHandlingInCSharp
{
    class Program 
    {
        static void Main(string[] args)
        {

            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException
                += new UnhandledExceptionEventHandler(HandleException);

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
                int result = calculator.calculate(number1, number2, operation);
                DisplayResult(result);

            }

            catch (ArgumentOutOfRangeException ex)
            {
                //Log.Error(ex);
                WriteLine($"Opration is not supported. {ex}");
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                //Log.Error(ex);
                WriteLine($"Operation was not provided.{ex}");

            }
            catch (ArgumentNullException ex)
            {
                //Log.Error(ex);
                WriteLine($"An argument was null. {ex}");
            }
            //catch (Exception ex)
            //{
            //    WriteLine($"Sorry, Something went wrong. {ex}");

            //}
            // The use of finally block is to make sure we clean up anything whether not an exception occurs.
            finally
            {
                WriteLine("...Finally...");
            }
            

            WriteLine("Press enter to exit.");
            ReadLine();

            
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            WriteLine($"Sorry there was a problem and we need to close this program. Details : {e.ExceptionObject}");
        }

        private static void DisplayResult(int result) => WriteLine($"The result is : {result}");
        
    }
}
