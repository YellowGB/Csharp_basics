using System;

Console.WriteLine("The following items are available:\n" +
    "1 - Rope\n" +
    "2 - Torches\n" +
    "3 - Climbing Equipment\n" +
    "4 - Clean Water\n" +
    "5 - Machete\n" +
    "6 - Canoe\n" +
    "7 - Food Supplies\n");
Console.Write("What number do you want to see the price of? ");
double choice = Convert.ToDouble(Console.ReadLine());

Console.Write("What is your name? ");
string name = Console.ReadLine();

double discount = 1;
if (name == "Yellaw") discount = 2;

string response = choice switch
{
    1 => $"Rope costs {10 / discount} gold.",
    2 => $"Torches cost {15 / discount} gold.",
    3 => $"Climbing Equipment costs {25 / discount} gold.",
    4 => $"Clean Water costs {1 / discount} gold.",
    5 => $"Machete costs {20 / discount} gold.",
    6 => $"Canoe costs {200 / discount} gold.",
    7 => $"Food Supplies cost {1 / discount} gold.",
    _ => "This item is not available."
};

Console.WriteLine(response);