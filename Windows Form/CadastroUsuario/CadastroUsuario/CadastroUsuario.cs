using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public partial class frm_CadastroUsuario : Form
    {
        public frm_CadastroUsuario()
        {
            InitializeComponent();
        }

        // Botoão Cadastrar
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string status = "";

            if (cmb_status.Text == "Ativo")
            {
                status = "Ativo";
            }
            else if (cmb_status.Text == "Inativo")
            {
                status = "Inativo";
            }

            string tipo = "";

            if (cmb_tipo.Text == "Administrador")
            {
                tipo = "Administrador";
            }
             else if (cmb_tipo.Text == "Usuário")
            {
                tipo = "Usuário";
            }

            Usuario usuario = new Usuario(tB_nome.Text, tB_Telefone.Text, tB_Cpf.Text, status, tipo);
            usuario.MostrarDadosUsuario();
        }
        

        // Parametro botão cancelar
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tB_nome.Clear();
            tB_Cpf.Clear();
            tB_Telefone.Clear();
            cmb_status.Text = " ";
            cmb_tipo.Text = " ";
        }
    }
}
