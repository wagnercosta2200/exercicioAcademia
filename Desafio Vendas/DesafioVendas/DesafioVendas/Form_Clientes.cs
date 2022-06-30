using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioVendas
{
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }
        // limpar campos
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            textBox_IdCliente.Text = " ";
            maskedTextBox_Cpf.Text = " ";
            textBox_NomeCliente.Text = " ";
            maskedTextBox_Telefone.Text =" ";
            textBox_Email.Text = " ";
        }
        //botão cadastrar cliente
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(int.Parse(textBox_IdCliente.Text), maskedTextBox_Cpf.Text,textBox_NomeCliente.Text,maskedTextBox_Telefone.Text,textBox_Email.Text);
            //c.Idcliente = Convert.ToInt16(textBox_IdCliente.Text);
            c.Cpf = maskedTextBox_Cpf.Text;
            c.Nome = textBox_NomeCliente.Text;
            c.Telefone = maskedTextBox_Telefone.Text;
            c.Email= textBox_Email.Text;
            c.gravarCliente();

        }
    }
}
