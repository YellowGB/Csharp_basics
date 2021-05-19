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
int choice = Convert.ToInt32(Console.ReadLine());

// Switch statement
switch (choice)
{
    case 1:
        Console.WriteLine("Rope costs 10 gold.");
        break;
    case 2:
        Console.WriteLine("Torches cost 15 gold.");
        break;
    case 3:
        Console.WriteLine("Climbing Equipment costs 25 gold.");
        break;
    case 4:
        Console.WriteLine("Clean Water costs 1 gold.");
        break;
    case 5:
        Console.WriteLine("Machete costs 20 gold.");
        break;
    case 6:
        Console.WriteLine("Canoe costs 200 gold.");
        break;
    case 7:
        Console.WriteLine("Food Supplies cost 1 gold.");
        break;
    default:
        Console.WriteLine("This item is not available."); // Pas obligatoire avec un statement
        break;
}

// Switch expression
string response = choice switch
{
    1 => "Rope costs 10 gold.",
    2 => "Torches cost 15 gold.",
    3 => "Climbing Equipment costs 25 gold.",
    4 => "Clean Water costs 1 gold.",
    5 => "Machete costs 20 gold.",
    6 => "Canoe costs 200 gold.",
    7 => "Food Supplies cost 1 gold.",
    _ => "This item is not available." // "wildcard", obligatoire avec une expression
};

Console.WriteLine(response);