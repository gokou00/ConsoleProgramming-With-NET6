// See https://aka.ms/new-console-template for more information
using static System.Console;


string fullName = string.Empty;
int age = 1;
double salary = 0.0;
char gender = 'M';
bool working = false;


Write("Please enter your full name: ");
fullName = ReadLine();

Write("Please enter your age: ");
age = int.Parse(ReadLine());

Write("Please enter your salary: ");
salary = double.Parse(ReadLine());

Write("Please enter your gender (M or F): ");
gender = char.Parse(ReadLine());

Write("Are you working (true or false) ? :");
working = bool.Parse(ReadLine());


WriteLine($"Hello {fullName} you are {age} years old and your salary is {salary} and you are a {gender}");
WriteLine($"Are you working {working}");



