using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_CadastroUsuarios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // Botão Ok (Login)
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string usuario = tb_Usuario.Text;
            string senha = tb_Senha.Text;

            // Parametros do Acesso

            if (usuario == "wagnercosta2200@gmail.com" && senha == "wagner2200")
            {
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos");
            }

        }
    }
}
