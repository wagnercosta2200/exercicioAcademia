using GerenciamentoContatos.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoContatos.Models
{
    [Table("UsuarioModel")]
    public class UsuarioModel
    {
        [Key()]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public PerfilEnum Perfil { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        //public void Salvar()
        //{
        //    var db = new Contexto();
        //    db.Usuarios.Add(this);
        //    db.SaveChanges();
        //}

    }
}