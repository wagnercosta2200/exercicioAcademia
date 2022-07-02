namespace CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            using(var tb = new Contexto())
            {
                 tb.ObjetoAgenda.Add(new Agenda { Nome = textBox_Telefone.Text, telefone = int.Parse.textBox_Telefone.Text });
                 tb.SaveChanges();
            }
        }
        //metodo atualizar datagrid
        public void Atualizar_Lista()
        {
            using(var tb = new Contexto())
            {
                dG_Agenda.DataSource = null;

                dG_Agenda.DataSource = tb.ObjetoAgenda.ToList();
            }
        }
    }
}