using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem2
{
    internal class Persistencia
    {
        public Persistencia()
        {

        }
        public static void gravarArquivoEntrada(List<Veiculo> lista)
        {

            StreamWriter escritor = new StreamWriter("Entrada.dat");
          

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada );
                escritor.Flush();
            }
            escritor.Close();

        }
        public static void gravarArquivoSaida(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("Saida.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataSaida + ";" + i.HoraSaida + ";" + i.PermanenciaMinuto + ";" + i.PermanenciaHora + ";" + i.ValorHora + ";" + i.ValorCobrado);
                escritor.Flush();
            }
            escritor.Close();
        }


        public static void lerArquivoEntrada(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("Entrada.dat");
            string linha;
            string[] vetorLinha;

            do
            {
                linha = leitor.ReadLine();
                if (linha != null)
                {
                    vetorLinha = linha.Split(';');
                    lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2], double.Parse(vetorLinha[3])));

                }

            } while (!leitor.EndOfStream);
             leitor.Close();
        }



        public static void lerArquivoSaida(List<Veiculo> lista)
        {
            StreamReader leitor2;
            string linha;
            string[] vetorLinha;

            if (File.Exists("Saida.dat"))
            {
                leitor2 = new StreamReader("Saida.dat");
                do
                {
                    linha = leitor2.ReadLine();
                    if (linha != null)
                    {
                        vetorLinha = linha.Split(';');

                        lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2], int.Parse(vetorLinha[3]), int.Parse(vetorLinha[4]), double.Parse(vetorLinha[5]), double.Parse(vetorLinha[6])));
                    }
                } while (!leitor2.EndOfStream);
                leitor2.Close();






                //StreamReader leitor = new StreamReader("saida.dat");
                //string linha;
                //string[] vetorLinha;
                //do
                //{
                //    linha = leitor.ReadLine();

                //    //ERRO - Ele dá erro se o arquivo estiver vazio qdo inicia o dia
                //    if (linha != null)
                //    {
                //        vetorLinha = linha.Split(';');
                //        lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2], int.Parse(vetorLinha[3]), int.Parse(vetorLinha[4]), double.Parse(vetorLinha[5]), double.Parse(vetorLinha[6])));

                //    }

                //} while (!leitor.EndOfStream);
                //// leitor.Close();
            }



        }
    }
}