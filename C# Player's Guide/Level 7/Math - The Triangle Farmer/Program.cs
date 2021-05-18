using System;

/*  /!\ ATTENTION, si la langue du système est en français,
    lors de l'input, il faut taper une virgule et non un point
    pour un nombre réel où le programme retournera une erreur ! */

Console.WriteLine("Taille de la base du triangle en centimètres :");
float _base = Convert.ToSingle(Console.ReadLine()); // Besoin de convertir la string en float

Console.WriteLine("Hauteur du triangle en centimètres :");
float _height = Convert.ToSingle(Console.ReadLine()); // Idem

float _area = _base * _height / 2;

Console.WriteLine("L'aire du triangle est de " + _area + "cm²");