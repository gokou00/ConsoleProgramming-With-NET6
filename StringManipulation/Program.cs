// See https://aka.ms/new-console-template for more information
using static System.Console;

string firstName = "John";
string lastName = "Smith";
DateTime date = DateTime.Now;

//concatenation
WriteLine(firstName + " " + lastName);
WriteLine($"My full name is {firstName} {lastName}");

//String length

int length = firstName.Length;
WriteLine($"The length of firstname is: {length}");

//Replace string parts
string newName = firstName.Replace('J', 'F');
WriteLine($"Your new first name is {newName}");



//Append to other string variable

string fullName = firstName + " " + lastName;
WriteLine($"Your full name is {fullName}");

//Split String

string[] splitName = fullName.Split(' ');
foreach(var name in splitName)
{
    WriteLine($"{name}");
}

//compare strings
string nullString = null;
string emptyString = "";
string whiteSpaceString = " ";

if (string.IsNullOrEmpty(nullString))
{
    WriteLine("String is null");
}

if(firstName == lastName)
{
    WriteLine("Names are equal");
}

if(firstName != lastName)
{
    WriteLine("Name are not equal");
}

int comparionResult = string.Compare(firstName, lastName, StringComparison.OrdinalIgnoreCase);

if(comparionResult == 0)
{
    WriteLine("Names are equal");
}
else
{
    WriteLine("Names are not equal");
}


//Convert to String

string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();

WriteLine($"The converted number is {convertedString}");

