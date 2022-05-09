// See https://aka.ms/new-console-template for more information
Console.WriteLine("11 - Faça um programa no VS que receba uma hora,\n"+" dividida em 2 variáveis (uma para hora e outra para minutos).\n" + "O programa deve exibir se a hora digitada está ou não válida.\n"+"Lembre que usaremos o padrão de hora com 24h, de 0 a 23.");

//Declaração da Variaveis

int horas, minutos;

Console.WriteLine("iforme a hora:");
horas = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Informe os minutos:");
minutos = int.Parse(Console.ReadLine());

Console.WriteLine();

if ((horas>=0 && horas <=23) && (minutos>=0 && minutos <=59))
{
    Console.WriteLine("A hora informada é valida: " + horas + ":" + minutos);

}
else
{
    Console.WriteLine("A hora informada não é valida.");
}