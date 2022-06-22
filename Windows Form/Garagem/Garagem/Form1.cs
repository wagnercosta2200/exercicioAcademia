namespace Garagem
{
    public partial class Form1 : Form
    {
        List<Veiculo> listaNaGaragem = new List<Veiculo>();
        List<Veiculo> listaSairam = new List<Veiculo>();
        //string[] linhaConfiguracao;
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
            //textBox_NaGaragem.Text = "";
            listBox_Estacionados.Items.Clear();
            int contador = 0;
            foreach (Veiculo i in lista)
            {
                contador++;
                //textBox_NaGaragem.AppendText(contador + " - " + i.Placa + " - " + i.DataEntrada + " - " + i.HoraEntrada + " - " + i.ValorHora.ToString("C") + Environment.NewLine);
                listBox_Estacionados.Items.Add(contador + " - " + i.Placa + " - " + i.DataEntrada + " - " + i.HoraEntrada + " - " + i.ValorHora.ToString("C"));
            }
        }
        private void popularSairam(List<Veiculo> lista)
        {
            //textBox_Sairam.Text = "";
            listBox_Sairam.Items.Clear();
            int contador = 0;
            foreach (Veiculo i in lista)
            {
                contador++;
                //textBox_Sairam.AppendText(contador + " - " + i.Placa + " - " + i.DataSaida + " - " + i.HoraSaida + " - " + i.PermanenciaHora + " hora(s) - " + i.ValorCobrado.ToString("C") + Environment.NewLine);
                listBox_Sairam.Items.Add(contador + " - " + i.Placa + " - " + i.DataSaida + " - " + i.HoraSaida + " - " + i.PermanenciaHora + " hora(s) - " + i.ValorCobrado.ToString("C"));
            }
        }



        public Form1()
        {
            InitializeComponent();

            Persistencia.gravarArquivoEntrada(listaNaGaragem);
            popularNaGaragem(listaNaGaragem);

            Persistencia.lerArquivoEntrada(listaNaGaragem); //lista vazia para popular
            popularNaGaragem(listaNaGaragem);

            Persistencia.lerArquivoSaida(listaSairam);
            popularSairam(listaSairam);

            DateTime dataNow = DateTime.Now;

            maskedTextBox_Data.Text = dataNow.ToShortDateString();
            maskedTextBox_Hora.Text = dataNow.ToShortTimeString();

            Configurar configuracao = new Configurar();
            configuracao.lerConfiguracao();

            textBox_Vagas.Text = configuracao.TamanhoGaragem.ToString();
            maskedTextBox_ValorHora.Text = configuracao.ValorHora.ToString("C");
            textBox_Disponivel.Text = (configuracao.TamanhoGaragem - listaNaGaragem.Count).ToString();



        }

        private void btn_Entrada_Click(object sender, EventArgs e)
        {
            //validar campos preenchidos
           // if (maskedTextBox_Placa.Text.Length != 6)
           // {
           //     MessageBox.Show("Por favor, informar a placa com 7 caracteres." +
           //         "\nSomente letras e números", "Preenchimento:");
           //     return;
           // }

            //Já está cadastrado - não pode repetir
            if (Veiculo.jaCadastrado(maskedTextBox_Placa.Text, listaNaGaragem))
            {
                MessageBox.Show("Veiculo já está na Garagem.\nPlaca repetida.", "Erro de digitação");
                return;
            }

            //existe vaga?
           Configurar configuracao = new Configurar();
           configuracao.lerConfiguracao();

            if (listaNaGaragem.Count >= configuracao.TamanhoGaragem)
            {
                MessageBox.Show("A garagem está cheia. \nNão há vagas disponíveis", "Lotação");
                return;
            }

            DateTime dataAgora = DateTime.Now;
            string dataEntrada = dataAgora.ToShortDateString();
            string horaEntrada = dataAgora.ToShortTimeString();

            listaNaGaragem.Add(new Veiculo(maskedTextBox_Placa.Text, dataEntrada, horaEntrada, configuracao.ValorHora));
            Persistencia.gravarArquivoEntrada(listaNaGaragem);
           // textBox_NaGaragem.AppendText(listaNaGaragem.Count + " - " + textBox_Placa.Text + " - " + dataEntrada + " - " + horaEntrada + " - " + configuracao.ValorHora.ToString("C") + Environment.NewLine);
            popularNaGaragem(listaNaGaragem);
            textBox_Disponivel.Text = (configuracao.TamanhoGaragem - listaNaGaragem.Count).ToString();

            // Limpara dados
            DateTime dataNow = DateTime.Now;

            maskedTextBox_Data.Text = dataNow.ToShortDateString();
            maskedTextBox_Hora.Text = dataNow.ToShortTimeString();
            maskedTextBox_Placa.Text = "";
            textBox_ResumoSaida.Text = "";

        }

        private void btn_Saida_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_Placa.Text.Length != 7)
            {
                MessageBox.Show("Por favor, informar a placa com 7 caracteres." +
                    "\nSomente letras e números.", "Preenchimento:");
                return;
            }

            //Verifica se o veículo está na garagem através da placa
            posicao = Veiculo.Localiza(maskedTextBox_Placa.Text, listaNaGaragem);
            if (posicao == -27)
            {
                MessageBox.Show("Veiculo não está na Garagem.\nPlaca não encontrada.", "Erro de digitação");
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

            textBox_ResumoSaida.Text = "";
            textBox_ResumoSaida.AppendText("Entrou às: " + dataHoraEntrada.ToString() + Environment.NewLine);
            textBox_ResumoSaida.AppendText("Saiu às: " + dataHoraSaida + Environment.NewLine);
            textBox_ResumoSaida.AppendText("Tempo: " + Convert.ToString(Math.Round(intervalo.TotalMinutes)) + " minutos" + Environment.NewLine);
            textBox_ResumoSaida.AppendText("Tempo: " + Convert.ToString(Math.Ceiling(intervalo.TotalHours)) + " horas" + Environment.NewLine);
            textBox_ResumoSaida.AppendText("A receber: " + Convert.ToString(Math.Ceiling(intervalo.TotalHours)) + " x " + valorHora.ToString("C") + " = " + valorCobrado.ToString("C") + Environment.NewLine);
            textBox_ResumoSaida.AppendText("intervalo total: " + intervalo.ToString() + Environment.NewLine);

            btn_Saida.Enabled = true;







        }

        private void btn_configuracao_Click(object sender, EventArgs e)
        {
            bool validado = true;
            if (textBox_Vagas.Text.Equals(""))
            {
                MessageBox.Show("Por favor, digite a quantidade de vagas que a garagem possui.", "Alerta");
                validado = false;
                return;
            }
            if (maskedTextBox_ValorHora.Text.Equals(""))
            {
                MessageBox.Show("Por favor, digite o valor da hora.", "Alerta");
                validado = false;
                return;
            }
            if (validado)
            {
               Configurar configurar = new Configurar(int.Parse(textBox_Vagas.Text), double.Parse(maskedTextBox_ValorHora.Text));
               configurar.gravarConfiguracao();



            }
        }
    }

}