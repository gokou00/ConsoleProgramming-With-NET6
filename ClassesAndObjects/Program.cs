// See https://aka.ms/new-console-template for more information
using static System.Console;



Person person1 = new();
string middleName = "";

Write("Enter the first name: ");
person1.FirstName = ReadLine();

Write("Enter the last name: ");
person1.LastName = ReadLine();

Write("Enter the person's age: ");
person1.Age = int.Parse(ReadLine());

Write("Enter the salary: ");
double salary = double.Parse(ReadLine());

Write("Enter middlename: ");
middleName = ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    WriteLine($"Full name is {person1.getFullName()}");
}
else
{
    WriteLine($"Full name is {person1.getFullName(middleName)} ");
}
person1.setSalary(salary);

//WriteLine($"First name is: {person1.FirstName}");
//WriteLine($"Last name is: {person1.LastName}");
//WriteLine($"Full name is: {person1.getFullName()} ");
WriteLine($"Age is: {person1.Age}");
WriteLine($"Your birth year is: {person1.getYearOfBirth()}");
WriteLine($"Your year of birth is: {DateUtil.YearOfBirth(person1.Age)}");

Write("Salary is: ");
WriteLine(person1.getSalary());





