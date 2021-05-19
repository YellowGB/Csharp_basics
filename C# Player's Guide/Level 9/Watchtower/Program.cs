using System;

Console.Write("Enter the x coordinate of the enemy : ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the y coordinate of the enemy : ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

string message = xCoordinate == 0 && yCoordinate == 0 ? "The enemy is here" : "The enemy is to the ";
string xDirection = "";

if (xCoordinate < 0) xDirection = "west";
else if (xCoordinate > 0) { xDirection = "east"; }

if (yCoordinate > 0)
    message += "north";
else if (yCoordinate < 0)
{
    message += "south";
}

message += xDirection + "!";
Console.WriteLine(message);