// See https://aka.ms/new-console-template for more information
Console.WriteLine("1) Fazer um programa em VS que gere uma lista com n valores randômicos\n"+" e inteiros para glicemia (entre 45 a 500). O progrma deve calcular média, valor mínimo,\n"+" valor máximo e mediana.Sugere - se criar um menu como: ");

//1) Fazer um programa em VS que gere uma lista com n valores randômicos e inteiros para glicemia (entre 45 a 500). 
//O progrma deve calcular média, valor mínimo, valor máximo e mediana.
//Sugere-se criar um menu como:

//MENU
//1 - Gerar lista
//2 - Exibir lista
//3 - Mostrar medidas centrais(média, valores min e max e mediana)
//4 - Sair
//Opção: ____

//Observação, toda vez que a opção 1 for acionada, o usuário deve definir quantos números serão gerados na lista

List<int> ListaGlicemia = new List<int>();

// Opcção é o obejeto da classe string, logo tem atributos e métodos vindos da classe: Toupper(), Length, Split()
string opcao = "";

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1- Gerar lista");
    Console.WriteLine("2 - - Exibir lista");
    Console.WriteLine("3- Mostrar medidas centrais(média, valores min e max e mediana)");
    Console.WriteLine("4- Sair");
    Console.WriteLine("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            // gerar Lista aleatoria
            Console.WriteLine("Lista sendo populada");
            int quantidadeNumeros = 0;
            Console.WriteLine("Quantos numeros quer gerar?");
            quantidadeNumeros = int.Parse(Console.ReadLine());
            Random gerador = new Random();
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                ListaGlicemia.Add(gerador.Next(45, 500));
            }
            break;

        case "2":
            //exibir lista aleatoria
            Console.WriteLine("Exibindo a lista de valores glicêmicos");

            if listaglicemia{
                Console.WriteLine()
            }

            for (int i = 0; i < ListaGlicemia.Count; i++)
            {
                Console.WriteLine(ListaGlicemia[i]);
            }

            //foreach(int i in ListaGlicemia)
            //{
            //    Console.WriteLine(i);
            //}

            break;

        case "3":
            //mostrar medidas centrais
            float media;
            int min;
            int max;
            float mediana;
           
            List<int> listaTmp = new List<int>();
            listaTmp.AddRange(ListaGlicemia);
            listaTmp.Sort();
            min = listaTmp[0];
            max = listaTmp[listaTmp.Count - 1];
            int soma = 0;

            foreach(int i in listaTmp)
            {
                //soma = soma + i;
                soma += i;

            }
            media = soma / listaTmp.Count;

            int meio = (int)listaTmp.Count / 2;

            if (listaTmp.Count % 2 != 0)// lista tem  tamanho impar
            {
              
                mediana = listaTmp[meio];

            }else// lista tem tamanho par
            {
                mediana = listaTmp[meio] + listaTmp[meio - 1] / 2;
            }
            Console.WriteLine("A media de valores da lista é: " + media);
            Console.WriteLine("ovalor  min da lista é: " + min);
            Console.WriteLine("O valor max da lista é : " + max);
            break;
        case "4":
            Console.WriteLine("obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção invaálida!");



    }


}