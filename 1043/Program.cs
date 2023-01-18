using System;
using System.Globalization;

class URI{

    static void Main(string[] args){

        string[] entrada = Console.ReadLine().Split(' ');

        double A = double.Parse(entrada[0], CultureInfo.InvariantCulture);
        double B = double.Parse(entrada[1], CultureInfo.InvariantCulture);
        double C = double.Parse(entrada[2], CultureInfo.InvariantCulture);

        double perimetro, area, soma;

        perimetro = A + B + C;
        area = (A + B) *C /2;

        if ((A < B + C) && (B < A + C) && (C < A + B)){
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1",CultureInfo.InvariantCulture));
        }

        else{
            Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
        }



    }
}