using System;

int result = AskForNumber("What is the airspeed veloccity of an unladen swallow?");

result = AskForNumberInRange("Give a number between 6 and 12.",6,12);

int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

/// <summary>
/// Display the text parameter and return only if the entered number is between the min and max. Otherwise, ask again.
/// </summary>
/// <param name="text">The question to display.</param>
/// <param name="min">The minimum expected.</param>
/// <param name="max">The maximum expected.</param>
int AskForNumberInRange(string text, int min, int max)
{
    int number;
    do
    {
        Console.Write(text + " ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    while (number < min || number > max);

    return number;
}