// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escreva uma classe Pessoa contendo todos os atributos de uma pessoa. \n "+"Faça métodos para apresentar os dados");


string nome;
string email;
int idade;
int telefone;

Pessoa p = new Pessoa();
Console.WriteLine("Adcionar Pessoa na classe?");
Console.WriteLine();

Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Qual o seu e-mail:");
email = Console.ReadLine().ToUpper();
Console.WriteLine();
public class Pessoa
{
    public string nome;
    public string email;
    public int idade = 0;
    public int telefone = 0;

    public bool ativo;

}