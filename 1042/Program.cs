using System;

class URI{

    static void Main(string[] args){

        string[] entrada = Console.ReadLine().Split(' ');

        int A = int.Parse(entrada[0]);
        int B = int.Parse(entrada[1]);
        int C = int.Parse(entrada[2]);

        int[] ordem = {1, 2, 3};

        // Se A for maior 
        if ((A < B) && (A < C)){
            
            ordem[0] = A;

            if ((B < C)){
                ordem[1] = B;
                ordem[2] = C;
            }

            else if (C < B){
                ordem[1] = C;
                ordem[2] = B;
            }
        }
        // Se B for o maior
        if ((B < A) && B < C){

            ordem[0] = B;

            if (A < C){
                ordem[1] = A;
                ordem[2] = C;
            }
            else if (C < A){
                ordem[1] = C;
                ordem[2] = A;
            }

        }
        else if ((C < A) && (C < B)){
            ordem[0] = C;

            if (B < A){
                ordem[1] = B;
                ordem[2] = A;
            }
            else if (A < B){
                ordem[1] = A;
                ordem[2] = B;
            }

        }
        // Saída 1: 
        Console.WriteLine(ordem[0]);
        Console.WriteLine(ordem[1]);
        Console.WriteLine(ordem[2]);

        Console.WriteLine();
        // Saída 2:
        Console.WriteLine(entrada[0]);
        Console.WriteLine(entrada[1]);
        Console.WriteLine(entrada[2]);
    }
}