// See https://aka.ms/new-console-template for more information
using static System.Console;

/*
for(int i = 0; i < 5; i++)
{
    WriteLine("I'm in a loop");
    WriteLine($"Counter value: {i}");
}
WriteLine("Finished");
*/

//while loop
/*
int n  = 0;
while(n < 5)
{
    WriteLine("I'm in a while loop");
    Write("Enter a number: ");
    n = int.Parse(Console.ReadLine());
    WriteLine($"You entered {n}");
}
WriteLine("while loop finished");
*/

//do while

int n = 0;

do
{
    Write("Enter a number: ");
    n = int.Parse(Console.ReadLine());
    WriteLine($"You entered {n}");
    WriteLine("In a do while loop");
} while (n < 5);