using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        // variáveis
        double[] notas = {100, 50, 20, 10, 5, 2};
        double[] moedas = {1, 50, 25, 5, 1, 1};
        double resto;
        // input
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        resto = valor;
        // process

        notas[0] = resto/100;
        resto %= 100;

        notas[1] =  resto/50;
        resto %= 50;

        notas[2] = resto/20;
        resto %= 20;

        notas[3] = resto/10;
        resto %= 10;

        notas[4] = resto/5;
        resto %= 5;

        notas[5] = resto/2;
        resto %= 2;

        moedas[0] = resto / 1;
        resto %= 1;

        moedas[1] = resto / 0.5;
        resto %= 0.5;

        moedas[2] = resto / 0.25;
        resto %= 0.25;

        moedas[3] = resto / 0.10;
        resto %= 0.10;

        moedas[4] = resto/ 0.05;
        resto %= 0.05;

        moedas[5] = resto/0.01;
        resto %= 0.01;

        // output
        Console.WriteLine("NOTAS:");
        Console.WriteLine((int) notas[0]  + " nota(s) de R$ 100.00");
        Console.WriteLine( (int) notas[1] + " nota(s) de R$ 50.00");
        Console.WriteLine( (int) notas[2] + " nota(s) de R$ 20.00");
        Console.WriteLine((int) notas[3] + " nota(s) de R$ 10.00");
        Console.WriteLine((int) notas[4] + " nota(s) de R$ 5.00");
        Console.WriteLine((int) notas[5]+ " nota(s) de R$ 2.00");

        Console.WriteLine("MOEDAS:");
        Console.WriteLine((int) moedas[0] + " moeda(s) de R$ 1.00");
        Console.WriteLine((int) moedas[1] + " moeda(s) de R$ 0.50");
        Console.WriteLine((int) moedas[2] + " moeda(s) de R$ 0.25");
        Console.WriteLine((int) moedas[3] + " moeda(s) de R$ 0.10");
        Console.WriteLine((int) moedas[4] + " moeda(s) de R$ 0.05");
        Console.WriteLine(Convert.ToInt32(moedas[5]) + " moeda(s) de R$ 0.01");


    }

}
