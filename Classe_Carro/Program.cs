// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crie uma classe Carro com os atributos: modelo, marca, cor e placa.\n"+ " Crie um método para definir os atributos, \n "+"outro método para ligar o carro e outro método para desligar o carro.");

string modelo, marca, cor, placa;
Carro c = new Carro();
Console.WriteLine("Vamos adicionar um carro na classe?");

Console.WriteLine("Modelo: ");
modelo = Console.ReadLine().ToUpper();
Console.WriteLine();

Console.WriteLine("Marca: ");
marca = Console.ReadLine().ToUpper();
Console.WriteLine();

Console.WriteLine("Cor: ");
cor = Console.ReadLine().ToUpper();
Console.WriteLine();

Console.WriteLine("Placa: ");
placa = Console.ReadLine().ToUpper();

c.Inserir(modelo, marca, cor, placa);

c.ligar();
Console.WriteLine("Modelo: " + c.modelo);
Console.WriteLine("Marca: " + c.marca);
Console.WriteLine("Cor: " + c.cor);
Console.WriteLine("Placa: " + c.placa);
c.desligar();

class Carro
{
    public string modelo;
    public string marca;
    public string cor;
    public string placa;

    public bool ligado;

    public void Inserir(string modelo, string marca, string cor, string placa)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.cor = cor;
        this.placa = placa;
    }

    public void ligar()
    {
        Console.WriteLine("Carro ligado");
        ligado = true;
    }

    public void desligar()
    {
        Console.WriteLine("Carro desligado");
        ligado = false;
    }
}
