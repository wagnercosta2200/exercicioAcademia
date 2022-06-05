namespace CadastroUsuario
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        //Parametros Login
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string usuario = tB_Usuario.Text;
            string senha = tB_Senha.Text;

            if (usuario == "wagnercosta2200@gmail.com" && senha == "wc2200")
            {
                frm_CadastroUsuario f = new frm_CadastroUsuario();
                f.Show();
              
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Incorreta");
            }
        }
         //Limpar os dados do usuario e Senha
        private void lbl_Cancelar_Click(object sender, EventArgs e)
        {
            tB_Usuario.Text = "";
            tB_Senha.Text = "";
        }
    }
}