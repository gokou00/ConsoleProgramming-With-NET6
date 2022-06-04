// See https://aka.ms/new-console-template for more information
using static System.Console;



Write("Enter Length: ");
var length = double.Parse(ReadLine());

Write("Enter Width: ");
var width = double.Parse(ReadLine());

Write("Enter Height: ");
var height = double.Parse(ReadLine());


var cube = new Cube(width,height,length);
var triangle = new triangle() { Height = height, Length = length, Hypotenuese = 10};
var rectangle = new Rectangle() { Height = height, Length = length,Width = width};



WriteLine($"Cube area is {cube.getArea()}");
WriteLine($"Cube volume is {cube.getVolume()}");
WriteLine($"Triangle Area is: {triangle.getArea()}");
WriteLine($"Rectangle Area is {rectangle.getArea()}");