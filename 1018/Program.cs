
int input = int.Parse(Console.ReadLine());
int inicial = 0;
inicial += input;

int nota100 = 0;
int nota50 = 0;
int nota20 = 0;
int nota10 = 0;
int nota5 = 0;
int nota2 = 0;
int nota1 = 0;

if (input > 100)
{
    nota100 = input / 100;
    input -= nota100 * 100;
    

}

if (input > 50);
{
    nota50 = input / 50;
    input -= nota50 * 50;
    
}

if (input > 20)
{
    nota20 = input / 20;
    input -= nota20 * 20;
    
}

if (input > 10);
{
    nota10 = input / 10;
    input -= nota10 * 10;
}

if (input > 5)
{
    nota5 = input / 5;
    input -= nota5 * 5;
}

if (input > 1)
{
    nota2 = input/2;
    input -= nota2 * 2;
}

if ((input > 0) && (input < 2))
{
    nota1 = input/1;
    input -= nota1 * 1;
    
}

Console.WriteLine(inicial);
Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
Console.WriteLine($"{nota1} nota(s) de R$ 1,00");

