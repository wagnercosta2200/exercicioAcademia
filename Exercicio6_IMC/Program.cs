// See https://aka.ms/new-console-template for more information
Console.WriteLine("6 - Faça um programa em C# e no Visual Studio para receber\n"+" o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.\n"+"O programa deve calcular o Indice de Massa Corpórea(IMC), \n"+"exibi - lo ao usuário e informar sua situação conforme a tabela.O cálculo do imc = peso / (altura * altura)");

/// <summary>
/// Declaração das variaveis
/// </summary>
string nome ;
double altura;
double peso;
double imc;
string txt;


Console.WriteLine("Infome seu Nome : ");
nome = String.Format(Console.ReadLine());

Console.WriteLine("Informe sua altura: ");
altura = double.Parse(Console.ReadLine());

Console.WriteLine("Informe seu peso: ");
peso = double.Parse(Console.ReadLine());

imc = peso / (altura * altura);


if (imc < 18)
{
    Console.WriteLine("Peso Baixo");
}

    if (imc > 18 && imc < 25)
    {
        Console.WriteLine("Peso Normal");
    }
     if (imc > 25 && imc < 30)
    {
        Console.WriteLine("Sobrepeso");
    }
    if (imc > 30 && imc < 35)
    {
        Console.WriteLine("Obesidade");
    }

    if (imc > 35)
    {
    Console.WriteLine("Obesidade grau sério");

    }

txt = nome.ToUpper();
Console.WriteLine(txt + "Seu IMC é: "+imc);
