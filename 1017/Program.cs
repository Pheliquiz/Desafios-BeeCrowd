using System;
using System.Globalization;

int trip = int.Parse(Console.ReadLine());
double hour = double.Parse(Console.ReadLine());

Console.WriteLine(((trip * hour)/12).ToString("F3", CultureInfo.InvariantCulture));