using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem2
{
    internal class Configurar
    {
        int tamanhoGaragem = 50;
        double valorHora = 5.00;
      

        public Configurar()
        {

        }
        public Configurar(int tamanhoGaragem, double valorHora)
        {
            this.TamanhoGaragem = tamanhoGaragem;
            this.ValorHora = valorHora;
        }

        public void gravarConfiguracao()
        {

            StreamWriter escritor = new StreamWriter("configuracao.dat");
            escritor.WriteLine(tamanhoGaragem + ";" + valorHora);
            escritor.Flush();
            escritor.Close();

            MessageBox.Show("Configuracao gravada com sucesso.", "Informativo:");
        }

        public void lerConfiguracao()
        {
            StreamReader leitor;
            string linha; 
            string[] vetorLinha;
            //  StreamReader leitor = new StreamReader("configuracao.dat");
            try
            {
                if (File.Exists("Saida.dat"))
                {
                    leitor = new StreamReader("Saida.dat");
                    {


                        linha = leitor.ReadLine();
                        if (linha != null)
                        {
                            vetorLinha = linha.Split(';');
                            this.TamanhoGaragem = int.Parse(vetorLinha[0]);
                            this.ValorHora = double.Parse(vetorLinha[1]);
                        }
                    } while (!leitor.EndOfStream) ;
                  
                    leitor.Close();
                }

                else
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Continue");
            }

        }
        public int TamanhoGaragem { get => tamanhoGaragem; set => tamanhoGaragem = value; }
        public double ValorHora { get => valorHora; set => valorHora = value; }
    }

}
