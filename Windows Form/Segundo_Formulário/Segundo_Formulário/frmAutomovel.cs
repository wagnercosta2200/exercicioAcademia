namespace Segundo_Formulário
{
    public partial class frmAutomovel : Form
    {
        //adciona a lista carro
        static List<Carro>carros = new List<Carro>();
        public frmAutomovel()
        {
            InitializeComponent();
        }

        private void lbl_FabricanteDoCarro_Click(object sender, EventArgs e)
        {

        }
        //Botão Limpar
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_FabricanteCarro.Clear();
            tb_ModeloCarro.Clear();
           // lb_Opcionais.ClearSelected();
           //lb_Opcionais.Items.Clear();

           // Para fazer a limpeza do Ckeklistbox

           foreach(int checados in lb_Opcionais.CheckedIndices)
            {
                lb_Opcionais.SetItemChecked(checados, false);
            }

            cmb_Portas.ResetText();
            dgAutomoveis.Rows.Clear();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            bool ac = false, dh = false, abs = false, ve = false, ab = false;
            int portas;
            foreach (string opc in lb_Opcionais.CheckedItems)
            {
                if (opc == "Ar condicionado")
                {
                    ac = true;
                }
                if (opc == "Direção hidráulica")
                {
                    dh = true;
                }
                if (opc == "Freios ABS")
                {
                    abs = true;
                }
                if (opc == "Vidros elétricos")
                {
                    ve = true;
                }
                if (opc == "Air bag")
                {
                    ab = true;
                }
            }
            portas = 0;
            if (cmb_Portas.Text == "2 portas") portas = 2;
            else if (cmb_Portas.Text == "3 portas") portas = 3;
            else if (cmb_Portas.Text == "4 portas") portas = 4;
            else if (cmb_Portas.Text == "5 portas") portas = 5;
            Carro c = new Carro(tb_ModeloCarro.Text, tb_FabricanteCarro.Text, ac, dh, abs, ab, ve, portas);
            carros.Add(c);
            // c.MostrarDadosCarro();
            mostraListadeCarro();
            dgAutomoveis.Rows.Add(tb_ModeloCarro.Text, tb_FabricanteCarro.Text, ac, dh, abs, ab, ve, portas);



        }
        static void mostraListadeCarro()
        {
            foreach(Carro c in carros)
            {
                MessageBox.Show("Carro " + c.modelo + "\nFabricante " + c.fabricante + "\nDH " + c.dh + "\nAr " + c.ar + "\nABS " + c.abs + "\nAir bag " + c.airbarg + "\nVidros eletrico " + c.ve + "\nPortas " + c.portas);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgAutomoveis.Rows.Clear();
            foreach (Carro c in carros) {
                dgAutomoveis.Rows.Add(c.modelo, c.fabricante, c.ar, c.dh, c.ve, c.airbarg, c.portas);
                    
            }
        }
    }
}



