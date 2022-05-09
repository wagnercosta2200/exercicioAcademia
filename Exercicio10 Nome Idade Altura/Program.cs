// See https://aka.ms/new-console-template for more information
Console.WriteLine("10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).\n" + "O programa deve mostrar os dados do atleta mais novo e mais alto.");


//Declaração de Variaveis

double altura = 0;
double altura2 = 0 ;
int idade = 0;
int idade2 = 0;
string nome;
string nome2;

/// <summary>
/// Dados Atleta 1
/// </summary>

Console.WriteLine("Informe Nome do primeiro atleta: ");
nome= Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Informe idade do primeiro atleta: ");
idade= int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Informe a altura do primeiro atleta : ");
altura=double.Parse(Console.ReadLine());

//Dados atleta 2

Console.WriteLine("informe o nome do segundo atleta:");
nome2 = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Informe a idade do segundo atleta: ");
idade2 = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Informe a altura do segundo atleta:");
altura2 = double.Parse(Console.ReadLine());

if ((altura > altura2) && (idade < idade2))
{
    Console.WriteLine();
    Console.WriteLine("O atleta: " + nome + " é mais novo e mais alto.");
}
else if ((altura < altura2) && (idade > idade2))
{
    Console.WriteLine();
    Console.WriteLine("O atelta: " + nome2 + " é mais novo e mais alto.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Os atletas " + nome + "e " + nome2 +" tem a mesma altura" );
}