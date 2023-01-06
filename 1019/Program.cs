// entrada de dados
int A = int.Parse(Console.ReadLine());

// variáveis
int hh = 0;
int mm = 0;
int ss = 0;


// inicio
mm = A / 60; 
ss = A - mm * 60;
hh = mm / 60;
mm -= hh * 60;

// output
Console.WriteLine($"{hh}:{mm}:{ss}");