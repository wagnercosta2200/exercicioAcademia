using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuario_Cadastro
{
    public class Usuario
    {
        public Usuario(string nome, string telefone, string cpf, string status, string tipo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            this.status = status;
            this.tipo = tipo;
        }

        public string nome { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }
        public string status {get; set; }
        public string tipo { get; set; }
    }
    public void MostrarDadosUsuario()
    {

    }
}
