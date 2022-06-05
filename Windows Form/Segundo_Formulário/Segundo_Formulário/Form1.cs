namespace Segundo_Formulário
{
    public partial class Form1 : Form
    {
        public Form1()
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
            c.MostrarDadosCarro();
        }
    }
}



