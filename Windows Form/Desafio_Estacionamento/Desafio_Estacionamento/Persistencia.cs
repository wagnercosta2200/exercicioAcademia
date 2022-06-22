using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Estacionamento
{
    internal class Persistencia
    {
        /// <summary>
        /// método que a partir da lista persiste os dados no arquivo dos veículos que estão na garagem
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        public static void gravarNoArquivoEntrada(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosEntrada.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + "  ;  " + i.DataEntrada + "  ;  " + i.HoraEntrada);
                escritor.Flush();
            }
            escritor.Close();
        }

        /// <summary>
        /// método que a partir da lista persiste os dados no arquivo dos veículos que passaram pela garagem
        /// </summary>
        /// <param name="lista">lsita de veículos</param>
        public static void gravarNoArquivoSaida(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosSaida.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa +  "  ;  " + i.DataEntrada + "  ;  " + i.HoraEntrada + "  ;  " + i.DataSaida + "  ;  " + i.HoraSaida + "  ;  " + i.TempoPermanecia + "  ;  " + i.ValorCobrado);
                escritor.Flush();
            }
            escritor.Close();
        }

        /// <summary>
        /// método que popula a lista de veículos de estão na garagem a partir do arquivo base
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        public static void lerArquivoEntrada(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("veiculosEntrada.dat");
            string linha;
            string[] vetorLinha;

            do
            {
                linha = leitor.ReadLine();
                if (linha !=null)
                {
                    vetorLinha = linha.Split(';');
                    lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2]));
                }
                
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        /// <summary>
        /// método que popula a lista de veículos de passaram pela garagem a partir do arquivo base
        /// </summary>
        /// <param name="lista">lista veículos</param>
        public static void lerArquivoSaida(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("veiculosSaida.dat");
            string linha;
            string[] vetorLinha;

            do
            {
                linha = leitor.ReadLine();
                if(linha != null)
                {
                    vetorLinha = linha.Split(';');
                    lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2], vetorLinha[3],
                        vetorLinha[4], int.Parse(vetorLinha[5]), double.Parse(vetorLinha[6])));
                }

            } while (!leitor.EndOfStream);
            leitor.Close();

            
        }
    }
}