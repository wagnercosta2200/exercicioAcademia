using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Models;

namespace SistemaCadastro.Data
{
    //Construtor do banco de dados
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<ContatoModel> Contato { get; set; }
        public DbSet<SistemaCadastro.Models.UsuarioModel>? UsuarioModel { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

    }
}




