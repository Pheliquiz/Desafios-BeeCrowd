using System;
using System.Globalization;

class URI{

    static void Main(string[] args){

        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // (0,25) (25,50) (50,75) (75,100)
        if ((numero < 0 ) || (numero > 100)){
            Console.WriteLine("Fora de intervalo");
        }

        if ((numero > 0) && (numero <= 25)){
            Console.WriteLine("Intervalo [0,25]");
        }

        if ((numero > 25) && (numero <= 50)){
            Console.WriteLine("Intervalo (25,50]");
        }

        if ((numero > 50) && (numero <= 75)){
            Console.WriteLine("Intervalo (50, 75]");
        }

        if ((numero > 75) && (numero <= 100)){
            Console.WriteLine("Intervalo (75,100]");
        }
    }
}