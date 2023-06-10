int health = -10;
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(Math.Clamp(health, -5, 100));
// Console.Beep(440, 1000);

Console.WriteLine($"{Math.PI:0.000}");


Console.WriteLine("Press any key when you're ready to begin.");
Console.ReadKey(true);