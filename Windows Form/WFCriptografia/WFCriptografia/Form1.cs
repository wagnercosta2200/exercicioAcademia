namespace WFCriptografia
{
    public partial class Form1 : Form
    {
        Assimetrica a;
        Simetrica s;
        public Form1()
        {
            InitializeComponent();
            a = new Assimetrica();
            s = new Simetrica();
        }

        private void btn_Criptografia_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto;
            frase = txbFrase.Text;
          
            fraseCripto = a.encrypt(frase);
            lblDescripto.Text = fraseCripto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto,chave;
            frase = txbFrase.Text;
            chave = txbChave.Text;
            fraseCripto =  s.EncryptData(frase,chave);
            lblDescripto.Text = fraseCripto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto, chave;
            chave = txbChave.Text;
            fraseCripto = lblCripto.Text;
            frase = s.DecryptData(fraseCripto,chave);
            lblCripto.Text = frase;
            
        }

        private void btn_Descriptografar_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto, chave;
            chave = txbChave.Text;
            fraseCripto = lblCripto.Text;
            frase = s.DecryptData(fraseCripto, chave);
            lblDescripto.Text = frase;
        }
    }
}