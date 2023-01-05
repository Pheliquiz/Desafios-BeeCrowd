using System;
using System.Globalization;


string[] input1 = Console.ReadLine().Split(' ');
string[] input2 = Console.ReadLine().Split(' ');
        
double x1 = double.Parse(input1[0]);
double x2 = double.Parse(input2[0]);
double y1 = double.Parse(input1[1]);
double y2 = double.Parse(input2[1]);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine(distance.ToString("F4", CultureInfo.InvariantCulture));
