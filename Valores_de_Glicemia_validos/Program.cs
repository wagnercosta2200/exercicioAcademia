// See https://aka.ms/new-console-template for more information
Console.WriteLine("Valores de Glicemia Validos");

int valorGlicemia; //45 a 450
List<int> ListaGlicemia = new List<int>();

//Variavel maiuscula é uma constante (para ninguem alterar)
int TOTAL = 5;
for (int i = 0; i < TOTAL; i++) { 

    do {
        Console.WriteLine("Digite um valor de glicimia valido:");
        valorGlicemia = int.Parse(Console.ReadLine());
        if (valorGlicemia > 45 && valorGlicemia <= 450) {
            break;

        }else
        {
            Console.WriteLine("Valor invalido . Atente para 45 a 450!:");
        }

    } while (true);

    ListaGlicemia.Add(valorGlicemia);
}

for (int i = 0; i < ListaGlicemia.Count; i = i + 1)
{
    Console.WriteLine(ListaGlicemia[i]);
}