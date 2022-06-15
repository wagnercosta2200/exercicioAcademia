using System.Configuration;
using Microsoft.Data.SqlClient;


namespace windowaForm_BancodeDados;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    // obejeto de conex�o garante o elo do app com o o BD SQL Server Express
    private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;

    private void carregarListView()
    {

        // obejeto de conex�o que conversa com o string de conex�o
        SqlConnection conexao = new SqlConnection(conexaoString);

        // ADO em a��o -> texto ou senten�a SQL
        conexao.Open();
        string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";

        // ADO em a��o -> associando o Sqltexto com a conex�o ou seja t� mandando para o BD
        SqlCommand comando = new SqlCommand(sqlTexto, conexao);

        listView_medidasGlicemias.Items.Clear();

        //Obejeto leitr tem a resposta do SqlTexto
        SqlDataReader leitor = comando.ExecuteReader();
        int i = 0;
        while (leitor.Read())
        {
            listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
            listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
            listView_medidasGlicemias.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
            listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
            i++;
        }

        conexao.Close();


    }

    private void button1_Click(object sender, EventArgs e)
    {
        // obejeto de conex�o que conversa com o string de conex�o
        SqlConnection conexao = new SqlConnection(conexaoString);

        // ADO em a��o -> texto ou senten�a SQL
        conexao.Open();
        string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";

        // ADO em a��o -> associando o Sqltexto com a conex�o ou seja t� mandando para o BD
        SqlCommand comando = new SqlCommand(sqlTexto, conexao);

        listView_medidasGlicemias.Items.Clear();

        //Obejeto leitr tem a resposta do SqlTexto
        SqlDataReader leitor = comando.ExecuteReader();
        int i = 0;
        while (leitor.Read())
        {
            listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
            listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
            listView_medidasGlicemias.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
            listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
            i++;
        }

        conexao.Close();
    }

    //Metodo Limpar text box
    private void limparTextBoxs()
    {
        textBoxidGlicemia.Text = "";
        textBoxValorGlicemia.Text = "";
        textBoxdataMedicao.Text = "";
        textBoxIdPaciente.Text = "";

    }

    private void buttonAdicionar_Click(object sender, EventArgs e)
    {
        SqlConnection conexao = new SqlConnection(conexaoString);
        conexao.Open();
        try
        {
            //capturar valores das vari�veis
            int idMedidaGlicemia = int.Parse(textBoxidGlicemia.Text);
            int valorGlicemia = int.Parse(textBoxValorGlicemia.Text);
            string dataMedida = textBoxdataMedicao.Text;
            int idPaciente = int.Parse(textBoxIdPaciente.Text);

            //gerar senten�as SQL
            string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";

            //Comando sql texto
            SqlCommand comando = new SqlCommand(sqlTexto, conexao);
            comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
            comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
            comando.Parameters.AddWithValue("@dataMedida", dataMedida);
            comando.Parameters.AddWithValue("@idPaciente", idPaciente);

            //executar senten�a SQL
            comando.ExecuteNonQuery();
        }
        catch (Exception erro)
        {
        }

        conexao.Close();

        //recarregar ListView
        carregarListView();
        limparTextBoxs();

    }

    private void button2_Click(object sender, EventArgs e)
    {
        // obejeto de conex�o que conversa com o string de conex�o
        SqlConnection conexao = new SqlConnection(conexaoString);

        // ADO em a��o -> texto ou senten�a SQL
        conexao.Open();
        string sqlTexto = "REMOVE idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";

        // ADO em a��o -> associando o Sqltexto com a conex�o ou seja t� mandando para o BD
        SqlCommand comando = new SqlCommand(sqlTexto, conexao);

        listView_medidasGlicemias.Items.Clear();

        //Obejeto leitr tem a resposta do SqlTexto
        SqlDataReader leitor = comando.ExecuteReader();
        int i = 0;
        while (leitor.Read())
        {
            listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
            listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
            listView_medidasGlicemias.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
            listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
            i++;
        }

        conexao.Close();
    }

}




