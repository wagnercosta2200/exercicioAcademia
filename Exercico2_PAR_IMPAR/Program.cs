// See https://aka.ms/new-console-template for more information

Console.WriteLine("2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. ");

int numero;

Console.WriteLine("Digite um numero");
numero = Convert.ToInt32(Console.ReadLine());

/// <summary>
/// Para verificar se é par ou impar
/// </summary>

if (numero % 2 == 0)
    {
    Console.WriteLine("Esse número é par");
}
    else
{
    Console.WriteLine("Esse número é impar");
}
