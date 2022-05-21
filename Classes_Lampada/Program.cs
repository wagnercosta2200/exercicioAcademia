// See https://aka.ms/new-console-template for more information
Console.WriteLine("Classe Lampada");


lampada l = new lampada();
//Console.WriteLine("");
l.potencia = 9;
l.ligar();

Console.WriteLine("Ligada? " +l.ligado+ " Potência =  "+ l.potencia);
l.desligar();

Console.WriteLine("Ligada? " + l.ligado + " Potência =  " + l.potencia);
double n;
n = l.retornaPotencia();
Console.WriteLine("A potencia da lampada cadastrada = "+ n);

l.ligar();
Console.WriteLine("Retorno da funão estaLigado = "+l.estaLigada());

if (l.estaLigada())
{
    Console.WriteLine("A lampada esta ligada!");
}
else
{
    Console.WriteLine("A lampada esta desligada!");
}

public class lampada
{
    //atributos
    public bool ligado;// aqui define se é true ou false - atributo
    public double potencia;

    //metodos

    //visibiliade (public ou private ou protected)
    // void é o tipo de retorno (o void retorna nada)
    // tipo de retorno int = retorna um inteiro
    //tipo de retorno double = 
    public void ligar()
    {
        Console.WriteLine("A lampada esta sendo ligada");
        ligado=true; 
    }
    public void desligar() 
    {
        Console.WriteLine("A lampada esta sendo desligada");
        ligado=false; 
    }
    // retorna a potencia da lampada
    public double retornaPotencia()
    {
        return potencia;
    }
    public bool estaLigada() // metodo
    { 
        return ligado;
    }
}