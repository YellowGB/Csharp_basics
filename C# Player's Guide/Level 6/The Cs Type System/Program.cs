using System;

byte _byte = 230;
sbyte _sbyte = -32;
short _short = -32000;
ushort _ushort = 65000;
int _int = 0xFF00FF;
uint _uint = 4_000_000;
long _long = -9000000000;
ulong _ulong = 12_000_000_000;

char _char = '\u0061'; // 'a' Unicode
string _string = "string";

float _float = 0.001f; // Si on ne précise pas 'f' à la fin, il sera pris en compte par le système comme un "double"
double _double = -3.5623;
decimal _decimal = 6.022e23m; // Comme pour float, 'm' pour forcer l'utilisation du "decimal", 'e' = exponentiel (10 puissance 23)

bool _bool = true;

// DISPLAY
Console.WriteLine("byte: " + _byte);
Console.WriteLine("sbyte: " + _sbyte);
Console.WriteLine("short: " + _short);
Console.WriteLine("ushort: " + _ushort);
Console.WriteLine("int: " + _int);
Console.WriteLine("uint: " + _uint);
Console.WriteLine("long: " + _long);
Console.WriteLine("ulong: " + _ulong);

Console.WriteLine("char: " + _char);
Console.WriteLine("string: " + _string);

Console.WriteLine("float: " + _float);
Console.WriteLine("double: " + _double);
Console.WriteLine("decimal: " + _decimal);

Console.WriteLine("bool: " + _bool);

//UPDATE
_byte = 0;                      // Minimum d'un type byte
_sbyte = -128;                  // Minimum d'un type sbyte
_short = -32767;                // Maximum d'un type short
_ushort = 65535;                // Maximum d'un type ushort
_int = -2147483648;             // Minimum d'un type int
_uint = 4294967295;             // Maximum d'un type uint
_long = -9223372036854775808;   // Minimum d'un type long
_ulong = 0;                     // Minimum d'un type ulong

_char = 'b';
_string = "bli bli bli";

_float = 1.0e-45f;              // Minimum d'un type float
_double = 1.7e308;              // Maximum d'un type double
_decimal = 7.9e28m;             // Maximum d'un type decimal

_bool = false;

//DISPLAY
Console.WriteLine("\nbyte: " + _byte);
Console.WriteLine("sbyte: " + _sbyte);
Console.WriteLine("short: " + _short);
Console.WriteLine("ushort: " + _ushort);
Console.WriteLine("int: " + _int);
Console.WriteLine("uint: " + _uint);
Console.WriteLine("long: " + _long);
Console.WriteLine("ulong: " + _ulong);

Console.WriteLine("char: " + _char);
Console.WriteLine("string: " + _string);

Console.WriteLine("float: " + _float);
Console.WriteLine("double: " + _double);
Console.WriteLine("decimal: " + _decimal);

Console.WriteLine("bool: " + _bool + "\n");

// TYPE INFERENCE
/*  Doit se faire sous la forme qui suit ce commentaire,
    avec l'assignation sur la même ligne que la déclaration.

    var message;
    message = "Hellow World";
    ne compilera pas.

    Tout comme il est impossible de changer le type par la suite !
    ici le compiler va déduire que message doit être de type string,
    la variable sera donc de type string pour le programme,
    ce n'est pas une variable à type "flottant" comme on peut en trouver
    en python par exemple, et donc on ne pourra pas donner la valeur
    -32 à 'message' par la suite, il y aura une erreur de compilation
    car la valeur a été typée string par le compiler et n'acceptera pas un int */
var message = "Infered type message\n";

Console.WriteLine(message);

// THE CONVERT CLASS
// Liste de toutes les methods de la class Convert page 44 du livre
Console.WriteLine("What is your favorite number?");

string favoriteNumberText = Console.ReadLine();
int favoriteNumber = Convert.ToInt32(favoriteNumberText);

Console.WriteLine(favoriteNumber + " is a great number!");