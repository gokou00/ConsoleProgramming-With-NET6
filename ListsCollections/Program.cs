// See https://aka.ms/new-console-template for more information
using static System.Console;

List<String> names = new();

//Add values to a list

string name = "";
//names[0] = "TestName";
names.Add("John Smith");
names.Remove("John Smith");
WriteLine("Enter names: ");

while (name != "-1")
{
    Write("Enter name: ");
    name = ReadLine();
    if (name == "-1" || string.IsNullOrEmpty(name)) break;
    names.Add(name);
    WriteLine($"Name {name} added successfully ");
}
//Print the list
WriteLine("Printing names in the list");
foreach(string item in names)
{
    WriteLine(item);
}



