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

            // Persistencia.gravarNoArquivoEntrada(listaEntrada);
            //Persistencia.gravarNoArquivoSaida(listaEntrada);

            populartextboxEntradaVeiculos(listaEntrada);
            populartextboxSaidaVeiculos(listasaida);

            Persistencia.lerArquivoEntrada(listaEntrada);
            Persistencia.lerArquivoSaida(listasaida);

        }

        private void populartextboxSaidaVeiculos(List<Veiculo> lista)
        {
            textBoxSaidaVeiculo.Text = "";
            foreach (Veiculo i in lista)
            {
                textBoxSaidaVeiculo.AppendText(i.Placa + " : " + i.HoraSaida + " : " + i.DataSaida + " : " + i.TempoPermanecia + " : " + i.ValorCobrado + Environment.NewLine);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy");
         
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void button_Entrada_Click_1(object sender, EventArgs e)
        {


            if (listaEntrada.Count >= 50)
            {
                MessageBox.Show("Não temos VAGAS", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Veiculo.localizado(mtBox_placa.Text, listaEntrada) != -27)
            {
                MessageBox.Show("Veiculo Já Cadastrado", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Veiculo veiculo = new Veiculo(mtBox_placa.Text, mtBox_dataEntrada.Text, mtBox_horaEntrada.Text);
            listaEntrada.Add(veiculo);
            Persistencia.gravarNoArquivoEntrada(listaEntrada);
            textBoxEntradaVeiculo.AppendText(veiculo.Placa + "       -        " + veiculo.DataEntrada + "         -         " + veiculo.HoraEntrada + Environment.NewLine);

            MessageBox.Show($"{mtBox_placa.Text}\n{mtBox_dataEntrada.Text}\n{mtBox_horaEntrada.Text}");


            mtBox_placa.Text = "";
            mtBox_dataEntrada.Text = "";
            mtBox_horaEntrada.Text = "";

        }

        private void button_Saida_Click(object sender, EventArgs e)
        {
            
                Veiculo veiculo = new Veiculo(mtBox_placa.Text, mtBox_dataSaida.Text, mtBox_horaSaida.Text);
            
                if (Veiculo.localizado(veiculo.Placa, listasaida) == -27)
                {
                    Persistencia.gravarNoArquivoSaida(listasaida);
              
                     Persistencia.lerArquivoSaida(listasaida);
                     veiculo.DataSaida = mtBox_dataSaida.Text;
                     veiculo.HoraSaida = mtBox_horaSaida.Text;

                // veiculo.realizarCobranca(5);
                // veiculo.HoraEntrada = DateTime.Now.ToString("HH:mm");
                // veiculo.HoraSaida = DateTime.Now.ToString("dd/MM/yyyy");

                //   // veiculo.TempoPermanecia = textBox_permanencia.Text;

                //   // veiculo.realizarCobranca(5);
                //    var listaSaida = new List<Veiculo>();
                //    //Persistencia.lerArquivoSaida(listaSaida);
                //    //listaSaida.Add(veiculo);
                //    //Persistencia.gravarNoArquivoSaida(listaSaida);
                //    //listaEntrada.Remove(veiculo);
                //    //Persistencia.gravarNoArquivoEntrada(listaEntrada);
                //  //  MessageBox.Show("Obrigado Volte Sempre", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                textBoxSaidaVeiculo.AppendText(veiculo.Placa + "  -  " + veiculo.DataSaida + "  -  " + veiculo.HoraSaida+ "  -  " + veiculo.TempoPermanecia+ "  -  " + veiculo.ValorCobrado +  Environment.NewLine);
               
               
                mtBox_placa.Text = "";
                mtBox_dataSaida.Text = "";
                mtBox_horaSaida.Text = "";
            }





        }

        private void textBox_permanencia_TextChanged(object sender, EventArgs e)
        {
           // mtbox_permanecia.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
    



           
        
    



        
            


           



       
    
