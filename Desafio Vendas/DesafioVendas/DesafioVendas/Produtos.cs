using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesafioVendas
{
    internal class Produtos
    {
        private int idProduto;
        private string codEAN;
        private string nome;
        private decimal preco;
        private int estoque;

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string CodEAN { get => codEAN; set => codEAN = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Estoque { get => estoque; set => estoque = value; }

        public Produtos(int idProduto, string codEAN, string nome, decimal preco, int estoque)
        {
            this.IdProduto = idProduto;
            this.CodEAN = codEAN;
            this.Nome = nome;
            this.Preco = preco;
            this.Estoque = estoque;
        }

        public bool gravarProdudos()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into produto values(@idProduto,@codEAN,@nome,@preco,@estoque);";
            command.Parameters.Add("@idProduto", SqlDbType.VarChar);
            command.Parameters.Add("@codEAN", SqlDbType.VarChar);
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Decimal);
            command.Parameters.Add("@estoque", SqlDbType.VarChar);

            command.Parameters[0].Value =this.idProduto;
            command.Parameters[1].Value = this.codEAN;
            command.Parameters[2].Value = this.nome;
            command.Parameters[3].Value = this.preco;
            command.Parameters[4].Value = this.estoque;

            //Caso der algum erro ele entrar na exececção (catch)
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
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
