// See https://aka.ms/new-console-template for more information
Console.WriteLine("17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo\n"+" (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo.\n" +" Para que os ladosformem um triângulo, todos os lados devem \n" +"ser menores ou iguais a soma dos outros dois lados.Caso os lados formem um triangulo,\n" + " diga se o mesmo é equilátero(todosos lados iguais), \n"+"isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).");

/// <summary>
/// Declaração de variaveis
/// </summary>
double a,b,c;
Console.WriteLine("\nInforme tres numeros: ");

a=double.Parse(Console.ReadLine());
b=double.Parse(Console.ReadLine());
c=double.Parse(Console.ReadLine());

/// <summary>
/// Condicionamento dos triângulos
/// </summary>
if (a < (b + c) && b < (a + c) && c < (a + b))
{
    Console.WriteLine("\nÉ um triângulo");

    if (a == b && b == c)
    {
        Console.WriteLine(" Triângulo Equilatero");
    }
    else if (a == b || a == c || b == c)
    {
        Console.WriteLine(" Triângulo Isosceles");
    }
    else
    {
        Console.WriteLine("Trinagulo Escaleno");
    }
}
else
{
    Console.WriteLine("\n Não é um triângulo");
}


