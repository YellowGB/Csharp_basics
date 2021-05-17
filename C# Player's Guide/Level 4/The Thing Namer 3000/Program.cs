using System;

Console.WriteLine("What kind of thing are taking about?");
// Name of the thing
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
/*  Description
    of the thing */
string b = Console.ReadLine();
/* Add "Doom" to the name of the thing */
string c = "Doom";
string d = "3000"; // Add "3000" to the name of the thing
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");