using System; 

class URI {

    static void Main(string[] args) { 

        // input
        int dias = int.Parse(Console.ReadLine());


        // inicio
        int ano = dias / 365;
        int meses = (dias - 365 * ano)/30;
        int diasrest = (dias - 365 * ano) - (meses * 30);
        
        // output
        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{diasrest} dia(s)");

    }

}