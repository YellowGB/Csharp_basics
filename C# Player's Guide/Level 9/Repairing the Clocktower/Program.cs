using System;

Console.WriteLine("Enter a number");
int numberClock = Convert.ToInt32(Console.ReadLine());

if (numberClock % 2 != 0)
    Console.WriteLine("Tick");
else
    Console.WriteLine("Tock");