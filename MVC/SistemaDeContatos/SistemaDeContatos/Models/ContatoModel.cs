using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeContatos.Models
{
    [Table("Contatos")]
    public class ContatoModel
    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Column("Celular")]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

    }
}