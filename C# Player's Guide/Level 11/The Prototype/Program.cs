using System;

Random rnd = new Random();
int airshipLocation = rnd.Next(100); // random int entre 0 et 100

int guess;
Console.WriteLine("Guess the airship location (integer between 0 and 100).");

// do while pour éviter d'avoir à assigner une valeur bidon à guess
// et laisser le premier input de l'utilisateur s'en charger
do
{
    Console.Write("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess < airshipLocation) Console.WriteLine(guess + " is too low.");
    else if (guess > airshipLocation) Console.WriteLine($"{guess} is too high.");
}
while (guess != airshipLocation);

Console.WriteLine("You found the airship!");