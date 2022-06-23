using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem
{
    internal class Persistencia
    {
      public Persistencia()
        {

        }
        public static void gravarArquivoEntrada(List<Veiculo> lista)
        {

            StreamWriter escritor = new StreamWriter("entrada.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada + ";" + i.ValorHora);
                escritor.Flush();
            }
            escritor.Close();

        }
        public static void gravarArquivoSaida(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("saida.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataSaida + ";" + i.HoraSaida + ";" + i.PermanenciaMinuto + ";" + i.PermanenciaHora + ";" + i.ValorHora + ";" + i.ValorCobrado);
                escritor.Flush();
            }
            escritor.Close();
        }











        public static void lerArquivoEntrada(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("entrada.dat");
            string linha;
            string[] vetorLinha;

            do
            {
                linha = leitor.ReadLine();
                if(linha != null)
                {
                    vetorLinha = linha.Split(';');
                    lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2], double.Parse(vetorLinha[3])));

                }
               
            } while (!leitor.EndOfStream);
           // leitor.Close();
        }
        public static void lerArquivoSaida(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("saida.dat");
            string linha;
            string[] vetorLinha;
            do
            {
                linha = leitor.ReadLine();

                //ERRO - Ele dá erro se o arquivo estiver vazio qdo inicia o dia
                if (linha != null)
                {
                    vetorLinha = linha.Split(';');
                    lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2], int.Parse(vetorLinha[3]), int.Parse(vetorLinha[4]), double.Parse(vetorLinha[5]), double.Parse(vetorLinha[6])));

                }
               
            } while (!leitor.EndOfStream);
           // leitor.Close();
        }
       
       

    }
}
