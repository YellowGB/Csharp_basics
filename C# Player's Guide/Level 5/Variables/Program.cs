﻿using System;

// PETITS TRUCS CONCERNANT LES VARIABLES EN C#

// Ce qui suit
int x;
x = 10;

// Est la même chose que ce qui suit
int y = 10;

// On peut déclarer plusieurs variables du même type à la fois
int a, b, c;

// Et on peut assigner la même valeur à plusieurs variables du même type de la façon suivante
a = b = c = 10;

// C# accepte les formes de nombre suivantes
int l = 1000000000;
l = 1_000_000_000; // Cette forme est plus facile à lire pour l'oeil humain (on peut placer les "_" où on veut)

Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("l = " + l);