// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escreva um algoritmo leia pelo teclado um valor inteiro \n " + " chamado x, e então mostre na tela todos os números de 0 a 100, \n " + "pulando de x em x.");


int i, x;

Console.WriteLine("Digite x: ");
x = int.Parse(Console.ReadLine());

for ( i = 0; i <= 100; i = i + x)

{
    Console.WriteLine("i vale " +  i );

}
