// See https://aka.ms/new-console-template for more information
Console.WriteLine("14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um \n " + "link de Internet(em Mbps).Em seguida, calcule e informe o tempo aproximado de download \n " + "do arquivo usando este link(em minutos).");


double tamanhoArquivo, velocidadeInternet, tempoDownloadMinutos;

Console.Write("Informe o tamanho do aqruivo (em MB - megabytes): ");
tamanhoArquivo = double.Parse(Console.ReadLine());

Console.Write("Informe a velocidade da internet (em Mbps - Megabits por segundo): ");
velocidadeInternet = double.Parse(Console.ReadLine());

tempoDownloadMinutos = tamanhoArquivo / (velocidadeInternet / 8.0) / 60;

Console.WriteLine();
Console.WriteLine("A velocidade de download do arquivo em minutos é de " + tempoDownloadMinutos.ToString("F1") + "min.");