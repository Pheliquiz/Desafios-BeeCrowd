using System;
using System.Globalization;

int X = int.Parse(Console.ReadLine());
double Y = double.Parse(Console.ReadLine());

double kmL = X / Y;

Console.WriteLine(kmL.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
