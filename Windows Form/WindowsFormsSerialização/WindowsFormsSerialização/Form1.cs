using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


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
            return !textBox_Nome.Text.Equals("") && !textBox_dataNasimento.Equals("") && !textBox_cpf.Equals("");
        }

        private void limpaCampos()
        {
            textBox_nomePaciente.Text = String.Empty;
            textBox_dataNascimento.Text = String.Empty;
            textBox_cpf.Text = String.Empty;
        }

        private void Btn_gravar_Click(object sender, EventArgs e)
        {
            if (saoValidosCampos())
            {
                try
                {
                    Paciente p = new Paciente(textBox_nomePaciente.Text.ToUpper(), DateTime.Parse(textBox_dataNascimento.Text), textBox_cpf.Text);
                    if (Paciente.jaCadastrado(pacientes, p.Nome))
                    {
                        MessageBox.Show("Paciente já cadastrado", "Alerta");
                    }
                    else
                    {
                        pacientes.Add(p);
                        MessageBox.Show("Paciente cadastrado com sucesso", "Alerta");
                    }

                    limpaCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data inválida", "Alerta");
                }

            }
            else
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos", "Alerta");
            }

        }

        private void btn_SerializarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.idade = 67;
                p.nome = "Maria de Fátima";
                p.salario = 12000;

                JsonSerializer serializadorJSON = new JsonSerializer();
                StreamWriter procurador = new StreamWriter(@"C:\teste\pessoa.json");
                JsonWriter escritorJSON = new JsonTextWriter(procurador);
                serializadorJSON.Serialize(escritorJSON, p);
                procurador.Close();
                escritorJSON.Close();

                MessageBox.Show("Sucesso para serializar com JSON");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btn_DeserializarJSON_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\teste\pessoa.json");

            Pessoa p = JsonConvert.DeserializeObject<Pessoa>(json);
            //codigo para exibir os dados da pessoa deserializada
            MessageBox.Show("Nome: " + p.nome + " Idade: " + p.idade + " Salário: " + p.salario);
        }

        private void btn_serializar_Click(object sender, EventArgs e)
        {
            if (pacientes.Count > 0)
            {
                Serializador.serializarXML(pacientes, @"C:\teste\pacientes.xml");
                textBox_conteudoArquivo.Text = Arquivo.lerArquivo(@"C:\teste\pacientes.xml");
            }
            else
            {
                MessageBox.Show("Lista de pacientes vazia!", "Alerta");
            }
        }
    }

        private void btn_Deserializar_Click(object sender, EventArgs e)
        {
            FileStream procurador = new FileStream(@"C:\teste\dados.data", FileMode.Open);
            BinaryFormatter serializador = new BinaryFormatter();
            string dadosDesserializados = (string)serializador.Deserialize(procurador);
            procurador.Close();

            txbDesserializar.Text = dadosDesserializados;
        }

        private void btn_Serializar2_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.idade = 67;
                p.nome = "Maria de Fátima";
                p.salario = 12000;

                FileStream procurador = new FileStream(@"C:\teste\pessoaSOAP.xml", FileMode.Create);
                SoapFormatter serializadorSOAP = new SoapFormatter();

                serializadorSOAP.Serialize(procurador, p);
                procurador.Close();

                MessageBox.Show("Sucesso para serializar SOAP");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btn_Deserializar2_Click(object sender, EventArgs e)
        {
            FileStream procurador = new FileStream(@"C:\teste\pessoaSOAP.xml", FileMode.Open);
            Pessoa p = new Pessoa();
            SoapFormatter serializadorSOAP = new SoapFormatter();
            p = (Pessoa)serializadorSOAP.Deserialize(procurador);

            procurador.Close();
        }

        private void btn_SerializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.idade = 67;
                p.nome = "Maria de Fátima";
                p.salario = 12000;

                FileStream procurador = new FileStream(@"C:\teste\pessoa1.xml", FileMode.Create);
                XmlSerializer serializadorXML = new XmlSerializer(typeof(Pessoa));

                serializadorXML.Serialize(procurador, p);
                procurador.Close();

                MessageBox.Show("Sucesso para serializar com XML");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btn_DeserializarXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializadorXML = new XmlSerializer(typeof(Pessoa));
            StreamReader procurador = new StreamReader(@"C:\teste\pessoa1.xml");
            Pessoa p = (Pessoa)serializadorXML.Deserialize(procurador.BaseStream);
            //codigo para exibir os dados da pessoa deserializada
            MessageBox.Show("Nome: " + p.nome + " Idade: " + p.idade + " Salário: " + p.salario);

            procurador.Close();
        }
    }
 }
    
