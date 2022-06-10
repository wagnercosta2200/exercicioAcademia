namespace _10_Form_Lista_Aquivos
{
    public partial class Form_TelaPrincipal : Form
    {

        private void popularTextBoxListaPessoas(List<Pessoa> lista)
        {
            textBox_ListadePessoa.Text = "";
            foreach (Pessoa i in lista)
            {
                textBox_ListadePessoa.AppendText(i.NomeCompleto + " : " + i.Email + Environment.NewLine);
            }
        }

        public Form_TelaPrincipal()
        {
            InitializeComponent();
           // Persistencia.trazerDoArquivo(listaPessoas);
            popularTextBoxListaPessoas(listaPessoas);
        }

        private void button_Cadatrar_Click(object sender, EventArgs e)
        {
            if (textBox_nomePessoa.Text.Equals(""))
            {
                MessageBox.Show("Digite algum nome na caixa de nome de pessoa", "Alerta");
                return;
            }
            //colocar nome em maiusculo
            textBox_nomePessoa.Text = textBox_nomePessoa.Text.ToUpper();

            //testar se esse nome j� foi cadastrado
            if (Pessoa.jaCadastrado(textBox_nomePessoa.Text, listaPessoas))
            {
                MessageBox.Show("Pessoa j� cadastrada", "Alerta");
            }
            else
            {
                //adicionar na lista
                string[] vetorDados = textBox_nomePessoa.Text.ToLower().Split(' ');
                string email = vetorDados[0] + "." + vetorDados[vetorDados.Length - 1] + "@ufn.edu.br";
                listaPessoas.Add(new Pessoa(textBox_nomePessoa.Text, email));

                //adicionar no textBox_listaPessoas
                textBox_ListadePessoa.AppendText(textBox_nomePessoa.Text + " : " + email + Environment.NewLine);

                //adicionar no arquivo
                Persistencia.gravarNoArquivo(listaPessoas);

                textBox_nomePessoa.Text = "";
            }
        }
        List<Pessoa> listaPessoas = new List<Pessoa>();
        private void button_Remover_Click_1(object sender, EventArgs e)
        {
            //transformar o nome para maiusculo
            textBox_nomePessoa.Text = textBox_nomePessoa.Text.ToUpper();

            //localizar se o nome est� na lista
            int posicao = Pessoa.localiza(textBox_nomePessoa.Text, listaPessoas);
            if (posicao == -27)
            {
                MessageBox.Show("Pessoa n�o localizada", "Alerta");
            }
            else
            {
                //apagar a pessoa da lista
                listaPessoas.RemoveAt(posicao);

                //apagar a pessoa do textBox_listaPessoas
                popularTextBoxListaPessoas(listaPessoas);

                //apagar a pessoa do arquivo
                Persistencia.gravarNoArquivo(listaPessoas);

                textBox_nomePessoa.Text = "";

            }
        }
    }
}