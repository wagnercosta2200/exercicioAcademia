// See https://aka.ms/new-console-template for more information
Console.WriteLine("5: Escreva um programa em C# e no Visual Studio para calcular o consumo média de um automóvel (medido em Km / l),\n" + " sendo que são conhecidos a distância total percorridae o volume de combustível consumido\n" + " para percorrê - la(medido em l).");



double k1;
double k2;
double Litro;
double mediaLitro;
double KmRodados;
Console.WriteLine("Digite Km Inicial: " );
k1= double.Parse(Console.ReadLine());

Console.WriteLine("Digite Km final:");
k2= double.Parse(Console.ReadLine());


Console.WriteLine("Digite quantidade de litros abastecidos");
Litro = double.Parse(Console.ReadLine());

KmRodados = k1 - k2;

mediaLitro = (k1 - k2) / Litro;

Console.WriteLine("Rodamos km:"+ KmRodados);

Console.WriteLine("A media de combustivel e´: " + mediaLitro);


