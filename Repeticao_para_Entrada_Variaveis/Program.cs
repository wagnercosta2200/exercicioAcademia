// See https://aka.ms/new-console-template for more information
Console.WriteLine("Repetição para validar entradas em variaveis");


float notaBimestral;

do {

    Console.Clear();
    Console.WriteLine("Digite uma nota válida [ 0 a 10];");
    notaBimestral = float.Parse(Console.ReadLine());
    
    if (notaBimestral < 0 || notaBimestral > 10) 
    {
        Console.WriteLine("Nota invalida... presta atenção notas de 0 a 10!:");
        Console.ReadKey();
    }
} while (notaBimestral < 0 || notaBimestral > 10);

Console.WriteLine("Parabens... Voce digitou uma nota valida:");
