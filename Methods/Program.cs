// See https://aka.ms/new-console-template for more information
using static System.Console;
//void methods

void PrintName()
{
    WriteLine("John Smith");
}

void Addition(int num1 , int num2)
{
    WriteLine($"{num1} + {num2} = {num1 + num2}");
}
Addition(3, 5);
Write("Enter num1 :");
int num1 = int.Parse(ReadLine());
Write("Enter num2 :");
int num2 = int.Parse(ReadLine());
Addition(num1, num2);

PrintName();



//Methods returning values

int largestNumber(int num1, int num2, int num3)
{
    return Math.Max(num1, Math.Max(num2,num3));
}

Write("Enter num1 :");
num1 = int.Parse(ReadLine());
Write("Enter num2 :");
num2 = int.Parse(ReadLine());
Write("Enter num3: ");
int num3 = int.Parse(ReadLine());

WriteLine($"The largest number is {largestNumber(num1, num2, num3)}");



