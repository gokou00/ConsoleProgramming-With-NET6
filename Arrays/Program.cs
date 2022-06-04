// See https://aka.ms/new-console-template for more information
using static System.Console;

//declare a fixed array

int[] grades = new int[5];

//add values to fixed sized array

//grades[0] = 55;
//grades[1] = 60;
//grades[2] = 70;
//grades[3] = 100;
//grades[4] = 77;

//int[] grades = new int[] { 1, 25, 38, 45, 54 };

for(int i = 0; i < grades.Length; i++)
{
    Write("Please enter in a grade: ");
    grades[i] = int.Parse(ReadLine());
}
//Print a fixed array

foreach(int grade in grades)
{
    WriteLine($"grade: {grade}");
}

//Declare variable sized array

string[] studentNames = new string[] {"Test","Student1","etc..."};


//add values to Variable Size array




