using GerenciamentoContatos.Data;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoContatos.Models
{
    [Table("ContatoModel")]
    public class ContatoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        //public void Salvar()
        //{
        //    var db = new Contexto();
        //    db.Contatos.Add(this);
        //    db.SaveChanges();
        //}
    }
}