// See https://aka.ms/new-console-template for more information
using static System.Console;

//try catch block

Write("Enter first num: ");
int num1 = int.Parse(Console.ReadLine());

Write("Enter second num: ");
int num2 = int.Parse(Console.ReadLine());
int quotient = 0;
try
{
    quotient = num1 / num2;
    WriteLine($"The quotient is {quotient}");
}
catch(DivideByZeroException ex)
{
    WriteLine($"ILLEGAL OPERATION: {ex.Message}");
}

catch(Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("This is the finally block and end of the program");
}



