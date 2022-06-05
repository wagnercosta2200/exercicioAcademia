using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public class Usuario
    {
        public string nome { get; set; }
        public string telefone { get; set;}
        public string cpf { get; set; } 
        // public string login { get; set; }
        public string status { get; set;}
        public string tipo { get; set;}
       
        public Usuario(string nome, string telefone,string cpf, string status, string tipo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            //this.login = login;
            this.status = status;
            this.tipo = tipo;

        }
        public void MostrarDadosUsuario()
        {
           /*   MessageBox.Show("Nome " + this.nome);
                MessageBox.Show("Telefone " + this.telefone);
                MessageBox.Show("Cpf " + this.cpf);
                MessageBox.Show("Login " + this.login);
                MessageBox.Show("Status " + this.status);
                MessageBox.Show("Tipo " + this.tipo);
           */
MessageBox.Show("Nome: " + this.nome + "\n" + 
                "Telefone: "  + this.telefone + "\n "+
                "Cpf: " + this.cpf + "\n" +  
                "status: " + this.status +"\n"+
                "tipo: " + this.tipo);
        }

    }
}
