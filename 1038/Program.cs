using System; using System.Globalization;

class URI{

    static void Main(string[] args){

        var entrada = Console.ReadLine().Split(' ');

        int X = int.Parse(entrada[0]);
        int Y = int.Parse(entrada[1]);

        // 1 - cachorro quente R$4.00
        if (X == 1){
            Console.WriteLine("Total: R$ " + (Y * 4.00).ToString("F2", CultureInfo.InvariantCulture));
        }
        // 2 - X-Salada  R$4.50
        if (X == 2){
            Console.WriteLine("Total: R$ " + (Y * 4.50).ToString("F2", CultureInfo.InvariantCulture));
        }
        // 3 - X-Bacon R$5.00
        if (X == 3){
            Console.WriteLine("Total: R$ " + (Y * 5.00).ToString("F2", CultureInfo.InvariantCulture));
        }
        // 4 - Torrada simples R$2.00
        if (X == 4){
            Console.WriteLine("Total: R$ " + (Y * 2.00).ToString("F2", CultureInfo.InvariantCulture));
        }
        // 5 Refrigerante R$1.50
        if (X == 5){
            Console.WriteLine("Total: R$ " + (Y * 1.50).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}