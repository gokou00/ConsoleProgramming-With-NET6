// See https://aka.ms/new-console-template for more information
using static System.Console;
Write("Enter a num: ");
int num1 = int.Parse(Console.ReadLine());
Write("Enter a another num: ");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2)
{
    WriteLine("num1 is greater than num2");
}else if(num2 > num1)
{
    WriteLine("num2 is greater than num1");
}
else
{
    WriteLine("Both are equal");
}

//switch statements

Write("Enter final grade");
int grade = int.Parse(ReadLine());

switch (grade)
{
    case int n when n >= 0 && n< 60:
        WriteLine("You failed");
        break;
    case int n when n >= 60 && n <= 100:
        WriteLine("You passed.");
        break;
    default:
        WriteLine("Invalid grade");
        break;
}

//ternary operator

var message = num1 > num2 ? "num1 is greater num2" : "num1 is not greater than num2";
WriteLine(message);