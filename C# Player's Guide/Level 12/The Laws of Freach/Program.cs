using System;

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentMinimum = int.MaxValue;
foreach (int index in array)
    if (index < currentMinimum)
        currentMinimum = index;

Console.WriteLine(currentMinimum);

int total = 0;
foreach (int index in array)
    total += index;

float average = (float)total / array.Length;
Console.WriteLine(average);

/* Code page 90
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentMinimum = int.MaxValue; // Start higher than anything in the array
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentMinimum)
        currentMinimum = array[index];
}

Console.WriteLine(currentMinimum);

int total = 0;
for (int index = 0; index < array.Length; index++)
    total += array[index];

float average = (float)total / array.Length;
Console.WriteLine(average);
*/