// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados "+
" \n" + " (informando se ele estiver errado e repetindo a solicitação até que esteja correto)."+
" \n" + "Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário."+

" \n" + "Exemplo:"+
" \n" + "Digite um número inteiro positivo: -8"+
" \n" + " Valor incorreto!"+
" \n" + "Digite um número inteiro positivo: 8"+
" \n" + "Numero digitado: 8"+
" \n" + " Números inteiros pares entre 1 e 8: 2, 4, 6.");


int numero =0, i = 0;


Console.WriteLine("Digite um numero: ");
numero = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Onumero escolhido´foi ; {numero}");

if (i < numero)
{
    for ( i = 0; i <=  numero; i++)
    {
        if(i % 2 ==0)

            Console.WriteLine($"\n Numero inteiro par : {i} ");
    }
}