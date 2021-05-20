using System;

Countdown(10);

/* Original loop
for (int x = 10; x > 0; x--)
    Console.WriteLine(x);
*/

void Countdown(int fromNumber)
{
    if (fromNumber == 0) return;
    Console.WriteLine(fromNumber);
    Countdown(fromNumber - 1);
}