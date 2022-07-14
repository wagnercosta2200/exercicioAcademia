using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaDeContatos.Models;

namespace SistemaDeContatos.Data
{
    public class Contexto : IdentityDbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }
        public DbSet<ContatoModel> ContatoModel { get; set; }
    }
}