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
    public partial class Form_Produtos : Form
    {
        public Form_Produtos()
        {
            InitializeComponent();
        }
        //botão cadastrar prrodutos
        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {

            Produtos p = new Produtos(int.Parse(textBox_IdProduto.Text), textBox_CodEAN.Text, textBox_NomeProduto.Text, Convert.ToDecimal(maskedTextBox_Preco.Text), Convert.ToInt16(textBox_Estoque.Text));
            //p.IdProduto = Convert.ToInt16(textBox_IdProduto);
            //p.CodEAN = textBox_CodEAN.Text;
            //p.Nome = textBox_NomeProduto.Text;
            //p.Preco = Convert.ToDecimal(maskedTextBox_Preco.Text);
            //p.Estoque = Convert.ToInt16(textBox_Estoque.Text);
            p.gravarProdudos();

           // dG_Produtos(produtos.IdProduto,produtos.CodEAN,produtos.Nome,produtos.Preco,produtos.Estoque);
           // produtos.gravarProdudos();
        }
        // limpa campos
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
           textBox_IdProduto.Text = " ";
           textBox_CodEAN.Text = " ";
           textBox_NomeProduto.Text = " ";
           maskedTextBox_Preco.Text = " ";
           textBox_Estoque.Text = " ";
        }
    }
}
