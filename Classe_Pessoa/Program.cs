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

Console.WriteLine("Qual a sua idade: ");
idade = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Qual o seu telefone:");
telefone = int.Parse(Console.ReadLine());


p.Inserir(nome, email, idade, telefone);

p.ativo();
Console.WriteLine("Nome: "+ p.nome);
Console.WriteLine("Email: "+p.email);
Console.WriteLine("Idade: "+p.idade);
Console.WriteLine("Telefone "+p.telefone);
p.sedentario();

    public class Pessoa
    {
    public string nome;
    public string email;
    public int idade = 0;
    public int telefone = 0;

    public bool ativado;

    

    public void Inserir (string nome, string email, int idade, int telefone)
    {
    this.nome = nome;
    this.email = email; 
    this.idade = idade;
    this.telefone = telefone;
    }

    public void ativo()
    {
    Console.WriteLine("Pessoa Ativa");
    ativado = true;
    } 

    public void sedentario()
    {
    Console.WriteLine("Pessoa sedentaria");
    ativado = false;
    }
}