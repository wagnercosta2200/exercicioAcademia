namespace Simples_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            /*string nome tbnome
                       * int idade = tbidade
                       * string cpf = tbcpf
                       * string end = tbend
                       * string bairro tbbairro
                       * string cep tbcep
                       * string cidade tbcidade
                       * */
            Pessoa p = new Pessoa(tbNome.Text, int.Parse(tbidade.Text), tbcpf.Text, tbend.Text, tbbairro.Text, tbCEP.Text, tbCidade.Text);
            MessageBox.Show("Nome do individuo: " + p.nome + " CPF: " + p.cpf);
            tbNome.Text = "";
            tbidade.Text = "";
            tbcpf.Text = "";
            tbend.Text = "";
            tbbairro.Text = "";
            tbCEP.Text = "";
            tbCidade.Text = "";
            p.gravarPessoa();
        }
    }
}

