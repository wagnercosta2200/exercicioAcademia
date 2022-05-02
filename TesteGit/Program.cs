
// See https://aka.ms/new-console-template for more information
Console.WriteLine("6: Escreva um programa em C# e no Visual Studio que leia os dados\n" + " para o parafuso A e para o parafuso B,isto é, o código,\n" + " a quantidade de peças e o valor unitário de cada parafuso\n" + " e a porcentagem de IPI(única) a ser acrescentada. ");


double k1;
double k2;
double Litro;
double mediaLitro;
double KmRodados;
Console.WriteLine("Digite Km Inicial: ");
k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite Km final:");
k2 = double.Parse(Console.ReadLine());


Console.WriteLine("Digite quantidade de litros abastecidos");
Litro = double.Parse(Console.ReadLine());

KmRodados = k1 - k2;
mediaLitro = (k1 - k2) / Litro;

Console.WriteLine("Rodamos km:" + KmRodados);

Console.WriteLine("A media de combustivel e´: " + mediaLitro);
