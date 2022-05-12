// See https://aka.ms/new-console-template for more information
Console.WriteLine("Urna Eletronica");


string voto;
int totalVotosZeca = 0;
int totalVotosJoao = 0;
int totalVotosBrancos = 0;

do
{
    Console.WriteLine("Digite o nome do seu candidato, ou BRANCO, ou FIM para encerrar:");
    voto = Console.ReadLine().ToUpper();

    switch (voto)
    {
        case "JOÂO":
            totalVotosJoao++;
            break;

        case "ZECA":
            totalVotosZeca++;
            break;
        case "BRANCO":
            totalVotosBrancos++;
            break;
        case "FIM":
            Console.WriteLine("Programa encerrado:");
            break;
        default:
            Console.WriteLine("Cqandidato inexistente:");
            break;

    }
    Console.WriteLine("Obrigado por votar nessas eleições");
    Console.ReadLine();

} while (voto != "FIM");


Console.WriteLine("Total de votos para o ZECA: "+ totalVotosZeca);
Console.WriteLine("Total de votos para o JOÂO: "+ totalVotosJoao);
Console.WriteLine("Total de vosta em brancos: "+ totalVotosBrancos);
