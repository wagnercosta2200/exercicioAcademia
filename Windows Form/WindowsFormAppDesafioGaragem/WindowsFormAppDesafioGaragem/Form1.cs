namespace WindowsFormAppDesafioGaragem
{
    public partial class Form1 : Form
    {
        List<Veiculo> listaEntrada = new List<Veiculo>();
        List<Veiculo> listasaida = new List<Veiculo>();
        private void populartextboxEntradaVeiculos(List<Veiculo> lista)
        {
            textBoxEntradaVeiculo.Text = "";
            foreach (Veiculo i in lista)
            {
                
                textBoxEntradaVeiculo.AppendText(i.Placa + " : " + i.HoraEntrada + " : " + i.DataEntrada + Environment.NewLine);
            }
        }

        private void populartextboxSaidaVeiculos(List<Veiculo> lista)
        {
            textBoxSaidaVeiculo.Text = "";
            foreach (Veiculo i in lista)
            {
                textBoxSaidaVeiculo.AppendText(i.Placa + " : " + i.HoraSaida + " : " + i.DataSaida + " : " + i.TempoPermanecia + " : " + i.ValorCobrado + Environment.NewLine);
            }
        }
        public Form1()
        {
            InitializeComponent();
            //populartextboxEntradaVeiculos(listaentrada);

           // Persistencia.gravarNoArquivoEntrada(listaEntrada);
           // Persistencia.gravarNoArquivoSaida(listasaida);

            populartextboxEntradaVeiculos(listaEntrada);
            populartextboxSaidaVeiculos(listasaida);

            Persistencia.lerArquivoEntrada(listaEntrada);           
            Persistencia.lerArquivoSaida(listasaida);
            
        }

       

      

        /// <summary>
        /// hora referencia do porteiro
        /// </summary>

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(" dd/MM/yyyy  ");
        }
        /// <summary>
        /// Data referência do porteiro
        /// </summary>

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("  HH:mm:ss  ");
        }

        private void button_Entrada_Click(object sender, EventArgs e)
        {
            
            Veiculo veiculo = new Veiculo(mtBox_placa.Text, mtBox_horaEntrada.Text, mtBox_dataEntrada.Text);
           
            if (Veiculo.localizado(veiculo.Placa, listaEntrada) == -27)
            {
                listaEntrada.Add(veiculo);

                Persistencia.gravarNoArquivoEntrada(listaEntrada);
                Persistencia.lerArquivoEntrada(listaEntrada);
                
                textBox_Placa.Text = "";
                //lança veiculos cadastrados
                mtBox_placa.Text = mtBox_placa.Text.ToUpper();
                textBoxEntradaVeiculo.AppendText(veiculo.Placa + "          -       " + veiculo.HoraEntrada + "         -         " + veiculo.DataEntrada + Environment.NewLine);
                // Limpa os textbox
                mtBox_placa.Text = "";
                mtBox_dataEntrada.Text = "";
                mtBox_horaEntrada.Text = "";

            }
            else
            {
                MessageBox.Show("Placa já Cadastrada", "    Alerta    ");
            }  
           }

        private void button_Saida_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo(mtBox_placa.Text,mtBox_horaSaida.Text, mtBox_dataSaida.Text);
            
            if (Veiculo.localizado(veiculo.Placa, listasaida) == -27)
            {
                listasaida.Add(veiculo);
                
                Persistencia.gravarNoArquivoSaida(listasaida);
                Persistencia.lerArquivoEntrada(listaEntrada);
                Persistencia.lerArquivoSaida(listasaida);
                //lança veiculos cadastrados
               //listasaida.Add(new Veiculo(veiculo.Placa + " - " +  veiculo.TempoPermanecia + " - " + veiculo.ValorCobrado + Environment.NewLine));
                textBoxSaidaVeiculo.AppendText(veiculo.Placa + "  -    " +veiculo.HoraSaida+ "  -  " +veiculo.TempoPermanecia + " - " + veiculo.ValorCobrado + Environment.NewLine);
                // Limpa os textbox
                mtBox_placa.Text = "";
                mtBox_dataSaida.Text = "";
                mtBox_horaSaida.Text = "";
                MessageBox.Show("" + veiculo.ValorCobrado );
               
            }
        }
    }
    }
