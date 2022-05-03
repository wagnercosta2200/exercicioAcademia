// See https://aka.ms/new-console-template for more information
Console.WriteLine("8: Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. \n " +"A fórmula da conversão é F = (9 * C + 160) / 5.");


double C = 0;
double f = 0; 

Console.WriteLine("Digite a temperatura");
C= double.Parse(Console.ReadLine());



f = (9 * C + 160) / 5;

Console.WriteLine("O valor da temperatura em Fahrenheit é : " + f);

