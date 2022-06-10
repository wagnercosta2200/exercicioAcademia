using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Form_Lista_Aquivos
{
    internal class Persistencia
    {
        public static void gravarNoArquivo(List<Pessoa> lista)
        {
            StreamWriter escritor = new StreamWriter("pessoas.dat");

            foreach (Pessoa i in lista)
            {
                escritor.WriteLine(i.NomeCompleto + ";" + i.Email);
                escritor.Flush();
            }
            escritor.Close();
        }

       /* public static void trazerDoArquivo(List<Pessoa> lista)
        {
            StreamReader leitor = new StreamReader("pessoas.dat");
            string linha; //   WAGNER COSTA ;wagner.costa@ufn.edu.br
            string[] vetorDados; //[WAGNER COSTA][wagner.costa@ufn.edu.br]

            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(";");
                lista.Add(new Pessoa(vetorDados[0], vetorDados[1]));
            } while (!leitor.EndOfStream);
            leitor.Close();
        }*/
    }
}