// See https://aka.ms/new-console-template for more information
using static System.Console;
//Empty Datetime

DateTime date = new DateTime();

//Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1984, 11, 30);
WriteLine("My Dob is: " + dateOfBirth);

//Create a DateTime from currect timestamp

DateTime now = DateTime.Now;

WriteLine($"The time now is: {now}");


//Create a Datetime from a String

DateTime dateFromString = DateTime.Parse("1/31/2021");
WriteLine($"The Datetime from string is {dateFromString}");

//Add Additional Time

//now.AddHours(1);
WriteLine($"One hour from now is {now.AddHours(1)}");


//Ticks from DateTime

WriteLine($"Time as a numeral: {now.Ticks}");


//Date Only

DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth.Date);
WriteLine($"The date only from datetime {dateOnlyOfBirth}");

//Time only

TimeOnly timeOnly = TimeOnly.FromDateTime(now);

WriteLine($"time only from now {timeOnly}");

