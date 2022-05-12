// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nome de pessoas");

//Criação da lista Pessoas
List<string> ListaPessoas = new List<string>();
string nome;

do
{
    Console.WriteLine("Digite um nome de pessoas ou a palavra sair pra encerrar o programa:");
    nome = Console.ReadLine().ToUpper();
  

    if (nome == "sair")
    {
        break; // encerra a repetição
    }
    ListaPessoas.Add(nome);
} while (true);

//ListaPessoas = [0 ,1,2, 3, ....,n]

for (int i =0; i < ListaPessoas.Count; i = i + 1)
{
    Console.WriteLine(ListaPessoas[i]);
}