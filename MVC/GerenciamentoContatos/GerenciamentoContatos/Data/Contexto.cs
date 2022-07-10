using GerenciamentoContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoContatos.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
        public DbSet<ContatoModel> Contato { get; set; }
        public DbSet<UsuarioModel> Usuario{ get; set; }

    }
}
