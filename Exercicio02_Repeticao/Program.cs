// See https://aka.ms/new-console-template for more information
Console.WriteLine("2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja \n" +"informar um outro número.Caso positivo, o programa em VS deve ser repetido.");

int numero = 0, i = 0;


Console.WriteLine("Digite um numero: ");
numero = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"O numero escolhido´foi ; {numero}");

if (i < numero)
{
    for (i = 0; i <= numero; i++)
    {
        if (i % 2 == 0)

            Console.WriteLine($"\n Numero inteiro par : {i} ");
    }
}
