using System;

// SETTINGS
Console.Title = "Defense of Consolas";
int consoleCenter = Console.WindowWidth/2;

// Input
Console.WriteLine("\n" + "INCOMING!".PadLeft(consoleCenter + "INCOMING!".Length/2) + "\n");
Console.WriteLine("Press any key when you're ready to fence off the attack!".PadLeft(consoleCenter + "Press any key when you're ready to fence off the attack!".Length/2));
Console.ReadKey(true);

Console.Write("Target Row? ".PadLeft(consoleCenter + "Target Row? ".Length/2));
int targetRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ".PadLeft(consoleCenter + "Target Column? ".Length / 2));
int targetCol = Convert.ToInt32(Console.ReadLine());

// Compute
int left, right, up, down;

left    = targetCol - 1;
right   = targetCol + 1;
up      = targetRow + 1;
down    = targetRow - 1;

// Display
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Red;
Console.Clear();

Console.WriteLine("\n" + "Deploy to:".PadLeft(consoleCenter + "Deploy to:".Length/2));
Console.WriteLine($"({targetRow}, {left})".PadLeft(consoleCenter + "(x, x)".Length/2));
Console.WriteLine($"({down}, {targetCol})".PadLeft(consoleCenter + "(x, x)".Length / 2));
Console.WriteLine($"({targetRow}, {right})".PadLeft(consoleCenter + "(x, x)".Length / 2));
Console.WriteLine($"({up}, {targetCol})".PadLeft(consoleCenter + "(x, x)".Length / 2));

Console.Beep(440, 600);
Console.Beep(500, 600);
Console.Beep(440, 2000);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;