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
            // MessageBox.Show("Cliquei no botão Limpar");
            
        }

        private void n_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no botão confirmar");
            // MessageBox.Show("O E-mail digitado é: " + tbEmail.Text);
            MessageBox.Show("O nome é : "+tbNome.Text + "\"n O E-mail digitado é :" + tbEmail.Text+"\nO Endereço é : " + tbEndereco.Text +"\nO telefone é : " + tbTelefone.Text  +"\nO Bairro é: " + tbBairro.Text + "\nA cidade é: " + tbCidade.Text +"\nO sexo é: " + tbSexo.Text);
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
            MessageBox.Show("Bem vindo ao nosso primeiro Formulário");
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}