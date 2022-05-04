static void Main(string[] args)
{
    int num;
    Console.WriteLine("Digite um numero: ");
    num = int.Parse(args[0]);

    if (num > 0)
    {
        Console.WriteLine("Positivo!");
    }
    else if (num < 0)
    {
        Console.WriteLine("Negativo!");
    }
    else
    {
        Console.WriteLine("Zero!");
    }
}
