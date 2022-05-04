// See https://aka.ms/new-console-template for more information
/// <summary>
/// Informar se o numero é divisivel por 2, 4 ou 8
/// </summary>

int num;
Console.WriteLine("Digite um numero: ");
num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Divisivel por 2");
}
 if (num % 4 == 0)
{
    Console.WriteLine("Divisivel por 4");
}
 if (num % 8 == 0)
    {
    Console.WriteLine("Divisivel por 8");
}

