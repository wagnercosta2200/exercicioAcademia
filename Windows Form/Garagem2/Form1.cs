namespace Garagem2
{
    public partial class Form1 : Form
    {
        List<Veiculo> listaNaGaragem = new List<Veiculo>();
        List<Veiculo> listaSairam = new List<Veiculo>();
        int posicao;

        string placaSaida;
        string dataSaida;
        string horaSaida;
        int permanenciaMinuto;
        int permanenciaHora;
        double valorHora;
        double valorCobrado;

        private void popularNaGaragem(List<Veiculo> lista)
        {
            
            textBox_Estacionados.Text = "";
            listBox_Estacionados.Items.Clear();
            int contador = 0;
            foreach (Veiculo i in lista)
            {
                contador++;
               
                textBox_Estacionados.AppendText(i.Placa + "   -   " + i.DataEntrada + "   -   " + i.HoraEntrada +Environment.NewLine);
            }
        }
        private void popularSairam(List<Veiculo> lista)
        {
           textBox_Saida.Text = "";
            listBox_Sairam.Items.Clear();
            int contador = 0;
            foreach (Veiculo i in lista)
            {
                contador++;
                textBox_Saida.AppendText(contador + " - " +i.Placa + " - " + i.DataSaida + " - " + i.HoraSaida + " - " + i.PermanenciaHora + " hora(s) - " + i.ValorCobrado.ToString("C"));
            }
        }


        public Form1()
        {
            InitializeComponent();
            Persistencia.gravarArquivoEntrada(listaNaGaragem);
            popularNaGaragem(listaNaGaragem);

            Persistencia.lerArquivoEntrada(listaNaGaragem);
            popularNaGaragem(listaNaGaragem);

            Persistencia.lerArquivoSaida(listaSairam);
            popularSairam(listaSairam);

            DateTime dataNow = DateTime.Now;

            maskedTextBox_Data.Text = dataNow.ToShortDateString();
            maskedTextBox_Hora.Text = dataNow.ToShortTimeString();

            Configurar configuracao = new Configurar();
            configuracao.lerConfiguracao();

            textBox_TamanhoGaragem.Text = configuracao.TamanhoGaragem.ToString();
            textBox_ValorHora.Text = configuracao.ValorHora.ToString("C");
            textBox_Disponivel.Text = (configuracao.TamanhoGaragem - listaNaGaragem.Count).ToString();

        }

        private void btn_configuracao_Click(object sender, EventArgs e)
        {
            bool validado = true;
            if (textBox_TamanhoGaragem.Text.Equals(""))
            {
                MessageBox.Show("Por favor, digite a quantidade de vagas que a garagem possui.", "Alerta");
                validado = false;
                return;
            }
            if (textBox_ValorHora.Text.Equals(""))
            {
                MessageBox.Show("Por favor, digite o valor da hora.", "Alerta");
                validado = false;
                return;
            }
            if (validado)
            {
                Configurar configurar = new Configurar(int.Parse(textBox_TamanhoGaragem.Text), double.Parse(textBox_ValorHora.Text));
                configurar.gravarConfiguracao();
            }
        }

        private void btn_Entrada_Click(object sender, EventArgs e)
        {
            
             if (Veiculo.jaCadastrado(maskedTextBox_Placa.Text, listaNaGaragem))
            {
                 MessageBox.Show("Veiculo já está na Garagem.\nPlaca repetida.", "Alerta");
                 return;
             }

            // Verifica se existe vaga
            Configurar configuracao = new Configurar();
            configuracao.lerConfiguracao();

             if (listaNaGaragem.Count >= configuracao.TamanhoGaragem)
             {
                 MessageBox.Show("Não temos vaga", "Lotação");
                 return;
             }

             DateTime dataAgora = DateTime.Now;
             string dataEntrada = dataAgora.ToShortDateString();
             string horaEntrada = dataAgora.ToShortTimeString();

             listaNaGaragem.Add(new Veiculo(maskedTextBox_Placa.Text, dataEntrada, horaEntrada, configuracao.ValorHora));
             Persistencia.gravarArquivoEntrada(listaNaGaragem);
             popularNaGaragem(listaNaGaragem);
             textBox_Disponivel.Text = (configuracao.TamanhoGaragem - listaNaGaragem.Count).ToString();
            //  Limpar dados
            DateTime dataNow = DateTime.Now;
            maskedTextBox_Data.Text = dataNow.ToShortDateString();
            maskedTextBox_Hora.Text = dataNow.ToShortTimeString();
            maskedTextBox_Placa.Text = "";
            textBox_ResumoSaida.Text = "";
            textBox_Total.Text = "";   

        }

        private void btn_Saida_Click(object sender, EventArgs e)
        {
            //Verifica se o veículo está na garagem através da placa
            posicao = Veiculo.Localiza(maskedTextBox_Placa.Text, listaNaGaragem);
            if (posicao == -27)
            {
                MessageBox.Show("Veiculo não está mais na Garagem", "Alerta");
                return;
            }

            placaSaida = maskedTextBox_Placa.Text;

            DateTime dataHoraEntrada = DateTime.Parse(Veiculo.retorna_DataHoraEntrada(placaSaida, listaNaGaragem));
            DateTime dataHoraSaida = DateTime.Now;
            dataSaida = dataHoraSaida.ToShortDateString();
            horaSaida = dataHoraSaida.ToShortTimeString();

            TimeSpan intervalo;
            intervalo = dataHoraSaida - dataHoraEntrada;
            permanenciaMinuto = (int)Math.Round(intervalo.TotalMinutes);
            permanenciaHora = (int)Math.Ceiling(intervalo.TotalHours);

            valorHora = Veiculo.retorna_ValorHora(maskedTextBox_Placa.Text, listaNaGaragem);
            valorCobrado = (double)(Math.Ceiling(intervalo.TotalHours)) * valorHora;

            // Exibe o resumo em um textBox
            //textBox_ResumoSaida.Text = "";
            //textBox_ResumoSaida.AppendText("Entrou às: " + dataHoraEntrada.ToString() + Environment.NewLine);
            //textBox_ResumoSaida.AppendText("Saiu às: " + dataHoraSaida + Environment.NewLine);
            //textBox_ResumoSaida.AppendText("Tempo: " + Convert.ToString(Math.Round(intervalo.TotalMinutes)) + " minutos" + Environment.NewLine);
            //textBox_ResumoSaida.AppendText("Tempo: " + Convert.ToString(Math.Ceiling(intervalo.TotalHours)) + " horas" + Environment.NewLine);
            //textBox_ResumoSaida.AppendText("A receber: " + Convert.ToString(Math.Ceiling(intervalo.TotalHours)) + " x " + valorHora.ToString("C") + " = " + valorCobrado.ToString("C") + Environment.NewLine);
            textBox_Total.AppendText(valorCobrado.ToString("C"));
         
            textBox_Saida.AppendText(maskedTextBox_Placa.Text + "     -      " + maskedTextBox_Data.Text + "    -   " + maskedTextBox_Hora.Text+ "     -     "+ permanenciaMinuto + Environment.NewLine);
            // Remone o veiculo da lista de entrada quando ele sai do estacionamento
            listaNaGaragem.RemoveAt(posicao);

            maskedTextBox_Placa.Text = "";

            

        }
    }
}