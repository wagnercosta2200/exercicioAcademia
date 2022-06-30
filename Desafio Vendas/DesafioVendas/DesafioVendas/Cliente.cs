using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesafioVendas
{
    internal class Cliente
    {
        private int idcliente;
        private string cpf;
        private string nome;
        private string telefone;
        private string email;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }

        public Cliente(int idcliente, string cpf, string nome, string telefone, string email)
        {
            this.idcliente = idcliente;
            this.cpf = cpf;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
        // grava no banco cliente
        public bool gravarCliente()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection  = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into cliente values(@cpf,@nome,@telefone,@email);";
           // command.Parameters.Add("@idcliente", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@nome",SqlDbType.VarChar);
            command.Parameters.Add("@telefone",SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);

            //command.Parameters[0].Value = this.idcliente;
            command.Parameters[1].Value = this.cpf;
            command.Parameters[2].Value = this.nome;
            command.Parameters[3].Value = this.telefone;
            command.Parameters[4].Value = this.email;

            //Caso der algum erro ele entrar na exececção (catch)
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
          catch(Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();// fecha a conexão do banco
            }


        }
    }
}

