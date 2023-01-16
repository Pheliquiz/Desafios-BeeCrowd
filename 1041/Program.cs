// Entrada de XY numa string, falar qual quadrante pertence q1, q2, q3, q4
// Q1 = (-X, +Y); Q2 = (+X, +Y); Q3 = (-X,-Y); Q4 = (+X,-Y0)

using System;
using System.Globalization;

class URI {

    static void Main(string[] args){


        string[] entrada = Console.ReadLine().Split(' ');


        double X = double.Parse(entrada[0],CultureInfo.InvariantCulture);
        double Y = double.Parse(entrada[1],CultureInfo.InvariantCulture);

        

        if ((X > 0) && (Y > 0)){
            Console.WriteLine("Q1");
        }

        if((X < 0)  && (Y > 0)){
            Console.WriteLine("Q2");
        }
        if((X < 0) && (Y < 0)){
            Console.WriteLine("Q3");
        }

        if((X > 0) && (Y < 0)){
            Console.WriteLine("Q4");
        }

        if ((X == 0) && (Y == 0)){
            Console.WriteLine("Origem");
        }

        else if (Y == 0)
            Console.WriteLine("Eixo X");
            
        else if (X == 0)
            Console.WriteLine("Eixo Y");
    }
}
