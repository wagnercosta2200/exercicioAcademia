using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Cenario
    {
        // guarda adescriçãpo cenário
 
        string descricao;

      
        // guarda a data de criação do cenário
      
        DateTime data_criacao;

        // guarda a altura do cenário
       
        float altura;

   
        // propriedade de acesso  da descrição
       
        public string Descricao { get => descricao; set => descricao = value; }

        // propriedade de acesso da data de Criação
       
        public DateTime Data_criacao { get => data_criacao; set => data_criacao = value; }

        /// <summary>
        /// propriedade de acesso da altura
        /// </summary>
        public float Altura { get => altura; set => altura = value; }

        // método construtor básico
       
        public Cenario()
        {

        }

    
        ////método construtor do cenário com todos atributos
       
        public Cenario(string descricao, DateTime data_criacao, float altura)
        {
            this.descricao = descricao;
            this.data_criacao = data_criacao;
            this.altura = altura;
        }

        // método que mostra os dados do cenário na tela do usuário
  
        public void exibirDados()
        {
            Console.WriteLine("Exibindo dados...");
            Console.WriteLine(Descricao + "|" + Data_criacao.ToString("d") + "|" + Altura);
        }

      
        // método que calcula o intervalo de tempo entre a data de criação e a data atual
        
        public TimeSpan calcularTempo()
        {
            //TimeSpan intervalo;~//não precis a de variável
            //intervalo = DateTime.Now.Subtract(Data_criacao);
            //intervalo = DateTime.Now - Data_criacao;
            //return intervalo;
            return DateTime.Now.Subtract(Data_criacao);
           
        }

        public void imprimirCenario()
        {
            string arquivo = "teste.txt";
            string caminho = @"C:\temp\";
            string fullPath = System.IO.Path.Combine(caminho, arquivo);
            Console.BackgroundColor = ConsoleColor.Green;
            //StreamPrint
            //printDocument1.DocumentName = arquivo;
            //stringToPrint = System.IO.File.ReadAllText(fullPath);
        }
    }
}