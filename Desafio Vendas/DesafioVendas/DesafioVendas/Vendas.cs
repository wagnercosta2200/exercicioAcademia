using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesafioVendas
{
    internal class Vendas
    {
        private int idVenda;
        private int codigoCliente;
        private decimal valorTotal;

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }

        public Vendas(int idVenda, int codigoCliente, decimal valorTotal)
        {
            this.IdVenda = idVenda;
            this.CodigoCliente = codigoCliente;
            this.ValorTotal = valorTotal;
        }
        public bool gravarVendas()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into venda values(@idVenda,@codigoCliente,@valorTotal);";
            command.Parameters.Add("@idVenda", SqlDbType.VarChar);
            command.Parameters.Add("@codigoCliente", SqlDbType.Int);
            command.Parameters.Add("@valorTotal", SqlDbType.Decimal);


            command.Parameters[0].Value = this.idVenda;
            command.Parameters[1].Value = this.codigoCliente;
            command.Parameters[2].Value = this.valorTotal;


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

