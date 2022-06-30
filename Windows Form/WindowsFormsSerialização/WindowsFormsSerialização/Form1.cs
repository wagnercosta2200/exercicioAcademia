namespace WindowsFormsSerialização
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Paciente > pacientes = new List<Paciente>();

        private bool saoValidosCampos()
        {
            return ! textBox_Nome.Text.Equals("")&& !textBox_dataNasimento.Equals("") && !textBox_cpf.Equals("")
        }

        private void Btn_gravar_Click(object sender, EventArgs e)
        {
            if (saoValidosCampos())
            {
                Paciente p = new Paciente(textBox_Nome.Text.ToUpper(), DateTime.Parse(textBox_dataNasimento.Text), textBox_cpf);
            }

        }
    }
}