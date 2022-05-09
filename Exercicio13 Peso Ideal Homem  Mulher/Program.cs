// See https://aka.ms/new-console-template for more information
Console.WriteLine("13 - Tendo como dado de entrada a altura (h) de uma pessoa,\n"+" construa um programa no VS que calcule seu peso ideal, utilizando as seguintes fórmulas: ");

//Declaração das variaveis
double homem, mulher;
double h;



Console.WriteLine("Informe a sua altura: ");
h = double.Parse(Console.ReadLine());


//Calculo das alturas

homem = (72.7 * h) - 58;
mulher = (62.1 * h) - 44.7;

Console.WriteLine("O peso ideal de uma mulher é: " + mulher);
Console.WriteLine("O peso ideal de um homem é: " + homem);



