using System;

// States
int hpManticore, hpManticoreMax, hpConsolas, hpConsolasMax, round, distanceManticore, playerShot;
bool hit;

hpManticore = hpManticoreMax    = 10;
hpConsolas  = hpConsolasMax     = 15;

round = 1;

// Manticore's location
Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
distanceManticore = ReadNumber();
Console.Clear();

// Player 2
Console.WriteLine("Player 2, it is your turn.");

while (hpManticore > 0 && hpConsolas > 0)
{
    Console.WriteLine("-------------------------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round} City: {hpConsolas}/{hpConsolasMax} Manticore: {hpManticore}/{hpManticoreMax}");

    playerShot = RoundDamage(round);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"The cannon is expected to deal {playerShot} damage this round.");
    Console.ForegroundColor = ConsoleColor.White;

    hit = PlayerShoot(distanceManticore);
    if (hit) hpManticore -= playerShot;
    hpConsolas--;

    round++;
}
if (hpConsolas <= 0)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("All is lost, the city of Consolas has been destroyed!");
    Console.BackgroundColor = ConsoleColor.Black;
}
else
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    Console.BackgroundColor = ConsoleColor.Black;
}

int ReadNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int RoundDamage(int round)
{
    if (round % 3 == 0 && round % 5 == 0)
        return 10;
    else if (round % 3 == 0 || round % 5 == 0)
        return 3;
    else return 1;
}
bool PlayerShoot(int location)
{
    Console.Write("Enter desired cannon range: ");
    int shot = ReadNumber();

    if (shot < location)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round FELL SHORT of the target.");
        Console.ForegroundColor = ConsoleColor.White;
        return false;
    }
    else if (shot > location)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round OVERSHOT the target.");
        Console.ForegroundColor = ConsoleColor.White;
        return false;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ForegroundColor = ConsoleColor.White;
        return true;
    }
}