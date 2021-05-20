using System;

string blastType;
int fireTurn, electricTurn;

for (int i = 1; i <= 100; i++)
{
    fireTurn = i % 3;
    electricTurn = i % 5;
    if (fireTurn == 0 && electricTurn == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        blastType = "Electric and Fire";
    }
    else if (fireTurn == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        blastType = "Fire";
    }
    else if (electricTurn == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        blastType = "Electric";
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        blastType = "Normal";
    }

    Console.WriteLine($"{i}: {blastType}");
}