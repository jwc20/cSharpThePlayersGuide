using System;

namespace RepairingTheClockTower
{
  internal class Program
  {
    public static void Main(string[] args)
      {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 1)
          Console.WriteLine("Tick");
        else
          Console.WriteLine("Tock");
      }
  }
}