using System.Data.Common;

Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy to: ");


Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("(" + targetRow + ", " + (targetColumn - 1) + ")");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("(" + (targetRow - 1) + ", " + targetColumn + ")");
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("(" + targetRow + ", " + (targetColumn + 1) + ")");
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("(" + (targetRow + 1) + ", " + targetColumn + ")");

//Console.WriteLine($"({row}, {column - 1})");
//Console.WriteLine($"({row - 1}, {column})");
//Console.WriteLine($"({row}, {column + 1})");
//Console.WriteLine($"({row + 1}, {column})");

Console.Beep();

