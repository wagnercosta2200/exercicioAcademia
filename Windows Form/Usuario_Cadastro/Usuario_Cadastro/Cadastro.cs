using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuario_Cadastro
{
    public partial class frm_Cadastro : Form
    {
        public frm_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_Cadastar_Click(object sender, EventArgs e)
        {
            string status = "";
            if (cmb_status.Text == "Ativo")
            {
                status = "Ativo";
            }
            else if (cmb_status.Text == "Inativo")
                status = "Inativo";
            
            }
       

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_Telefone.Clear();
            tb_cpf.Clear();
            cmb_status.Text = "";
            cmb_tipo.Text = "";
        }
    }
}
