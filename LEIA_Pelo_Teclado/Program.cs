// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escreva um algoritmo leia pelo teclado os dois valores \n " + " inteiros chamados inicio e fim, e então mostre todos os números entre inicio e fim");

int i, inicio, fim;

Console.WriteLine("Digite o inicio: ");
inicio = int.Parse(Console.ReadLine());


Console.WriteLine("Digite o fim: ");
fim = int.Parse(Console.ReadLine());

if (inicio < fim)
{
    for (i = inicio; i <= fim; i++)
    {
        Console.WriteLine("i vale " + i);
    }
}
else if (inicio > fim)
{
    for (i = inicio; i >= fim; i--)
    {
        Console.WriteLine("i vale " + i);
    }
}
else
{
    Console.WriteLine("Os valores são iguais!:");
}