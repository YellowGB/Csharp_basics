using System;

int[] array1 = new int[5];
int index;

for (index = 0; index < array1.Length; index++)
{
    Console.Write($"Please enter number {index + 1}: ");
    array1[index] = Convert.ToInt32(Console.ReadLine());
}

int[] array2 = new int[array1.Length];
index = 0;

while (index < array2.Length)
{
    array2[index] = array1[index];
    index++;
}

index = 0;
do
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine($"Number {index + 1} in array1: {array1[index]}");

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Number {index + 1} in array2: {array2[index]}");
    index++;
}
while (index < array1.Length);