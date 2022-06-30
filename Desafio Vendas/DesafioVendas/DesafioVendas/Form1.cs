namespace DesafioVendas
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void btn_Cad_Produtos_Click(object sender, EventArgs e)
        {
            Form_Produtos form = new Form_Produtos();
            form.Show();
        }

        private void btn_Cad_Clientes_Click(object sender, EventArgs e)
        {
            Form_Clientes form = new Form_Clientes();
            form.Show();
        }

        private void btn_Cad_Vendas_Click(object sender, EventArgs e)
        {
            Form_Vendas form = new Form_Vendas();
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Clientes form = new Form_Clientes();
            form.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Produtos form = new Form_Produtos();
            form.Show();
        }
    }
}