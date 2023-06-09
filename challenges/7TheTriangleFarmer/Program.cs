// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string baseOfTriangleString;
string heightOfTriangleString;


Console.WriteLine("Enter the base of triangle: ");
baseOfTriangleString = Console.ReadLine();
int baseOfTriangle = Convert.ToInt32(baseOfTriangleString);

Console.WriteLine("Enter the base of triangle: ");
heightOfTriangleString = Console.ReadLine();
int heightOfTriangle = Convert.ToInt32(heightOfTriangleString);

float area = (baseOfTriangle * heightOfTriangle) / 2;

Console.WriteLine(area);