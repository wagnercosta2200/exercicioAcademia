// See https://aka.ms/new-console-template for more information
Console.WriteLine("Switch");

/// <summary>
/// Caso simple de Switch para encontrar o nome correto indicado na variavel.
/// Switch utilizado para multiplas tomadas de decisão eliminando assim a utilização de muitos If/Else
/// </summary>
string nome = "Paulo";

switch (nome)
{
    case "Joao": Console.WriteLine("Não é o cara");break;
    case "Marcelo": Console.WriteLine("Não é o cara");break;
    case "Paulo": Console.WriteLine("É este");break;
    default: Console.WriteLine("Não encontrei"); break;
}