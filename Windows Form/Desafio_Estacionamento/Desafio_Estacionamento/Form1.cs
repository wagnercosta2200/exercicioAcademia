namespace Desafio_Estacionamento
{
    public partial class Form1 : Form
    {   /// <summary>
        /// Adiciona na lista de veiculos estacionados
        /// </summary>
        /// 
        List<Veiculo> listaEntrada = new List<Veiculo>();

        //Adiciona lista de veiculos saida
        List<Veiculo> listasaida = new List<Veiculo>();
        private void populartextboxEntradaVeiculos(List<Veiculo> lista)
        {
            textBoxEntradaVeiculo.Text = "";
            foreach (Veiculo i in lista)
            {
                textBoxEntradaVeiculo.AppendText(i.Placa + " : " + i.HoraEntrada + " : " + i.DataEntrada + Environment.NewLine);
            }
        }
        public Form1()
        {
            InitializeComponent();

            //Persistencia.gravarNoArquivoEntrada(listasaida);
           populartextboxEntradaVeiculos(listaEntrada);

            // Persistencia.lerArquivoEntrada(listaEntrada);
            // populartextboxEntradaVeiculos(listaEntrada);

            //Persistencia.lerArquivoSaida(listasaida);
            //populartexboxSaidadeVeiculos(listasaida);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(" dd/MM/yyyy  ");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("  HH:mm:ss  ");
        }


        private void button_Entrada_Click_1(object sender, EventArgs e)
        {

            Veiculo veiculo = new Veiculo(mtBox_placa.Text, mtBox_horaEntrada.Text, mtBox_dataEntrada.Text);

            if (Veiculo.localizado(veiculo.Placa, listaEntrada) == -27)
            {
                listaEntrada.Add(veiculo);
                Persistencia.gravarNoArquivoEntrada(listaEntrada);
                textBox_Placa.Text = "";

                listaEntrada.Add(veiculo);
                listaEntrada.Add(new Veiculo(mtBox_placa.Text, mtBox_horaEntrada.Text, mtBox_dataEntrada.Text));
                Persistencia.gravarNoArquivoEntrada(listaEntrada);
                textBox_Placa.Text = "";
                //lança veiculos cadastrados
                mtBox_placa.Text = mtBox_placa.Text.ToUpper();
                textBoxEntradaVeiculo.AppendText(veiculo.Placa + "          -       " + veiculo.DataEntrada + "         -         " + veiculo.HoraEntrada + Environment.NewLine);

                // Limpa os textbox
                mtBox_placa.Text = "";
                mtBox_dataEntrada.Text = "";
                mtBox_horaEntrada.Text = "";

            }
            else
            {
                MessageBox.Show("Placa Já Cadastrada", "Alerta");
            }
           
        }
    }
}

        
            


           



       
    
