namespace PrimeiroWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Cliquei no bot�o Limpar");
            
        }

        private void n_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no bot�o confirmar");
            // MessageBox.Show("O E-mail digitado �: " + tbEmail.Text);
            MessageBox.Show("O nome � : "+tbNome.Text + "\"n O E-mail digitado � :" + tbEmail.Text+"\nO Endere�o � : " + tbEndereco.Text +"\nO telefone � : " + tbTelefone.Text  +"\nO Bairro �: " + tbBairro.Text + "\nA cidade �: " + tbCidade.Text +"\nO sexo �: " + tbSexo.Text);
            MessageBox.Show("Cadastro Efetuado");
            tbNome.Clear();
            tbEmail.Clear();
            tbEndereco.Clear();
            tbCidade.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            tbTelefone.Clear();
            tbSexo.Clear();
            lblMensagem.Text = "Cadastro Efetuado Com Sucesso! Insira um Novo Registro";
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao nosso primeiro Formul�rio");
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}