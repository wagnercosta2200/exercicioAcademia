using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CadastroSimples
{
    public class Contexto : System.Data.Entity.DbContext
    { 
        public Contexto(): base("StringConextion")
         {

        }
   
        public System.Data.Entity.DbSet<Agenda> ObjetoAgenda { get; set; }
    }
}
