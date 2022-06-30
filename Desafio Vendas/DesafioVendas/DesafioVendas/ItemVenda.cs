using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVendas
{
    internal class ItemVenda
    {
        private int idItemVenda;
        private int idVenda;
        private int idProduto;
        private decimal valorUnitario;
        private int quantidade;
        private decimal valorTotal;

        public int IdItemVenda { get => idItemVenda; set => idItemVenda = value; }
        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public decimal ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }

        public ItemVenda(int idItemVenda, int idVenda, int idProduto, decimal valorUnitario, int quantidade, decimal valorTotal)
        {
            this.IdItemVenda = idItemVenda;
            this.IdVenda = idVenda;
            this.IdProduto = idProduto;
            this.ValorUnitario = valorUnitario;
            this.Quantidade = quantidade;
            this.ValorTotal = valorTotal;
        }
    }
}
