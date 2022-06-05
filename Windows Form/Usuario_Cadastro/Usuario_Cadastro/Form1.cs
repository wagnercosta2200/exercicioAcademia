namespace Usuario_Cadastro
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string usuario = tB_Usuario.Text;
            string senha = tB_Senha.Text;

            if (usuario =="wagnercosta2200@gmail.com" &&  senha == "wc2200")
            {
                frm_Cadastro f = new frm_Cadastro();
                f.Show();
            }
            else
            {
                MessageBox.Show("usuário ou Senha Incorreta!");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tB_Usuario.Text = "";
            tB_Senha.Text = "";
        }
    }
}