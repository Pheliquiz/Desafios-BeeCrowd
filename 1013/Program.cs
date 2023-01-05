string[] input1 = Console.ReadLine().Split(' ');
        
int A = int.Parse(input1[0]);
int B = int.Parse(input1[1]);
int C = int.Parse(input1[2]);

int maiorAB = ((A + B)+ Math.Abs(A-B))/2;
int maiorABC = ((maiorAB + C)+ Math.Abs(maiorAB-C))/2;

Console.WriteLine(maiorABC + " eh o maior");