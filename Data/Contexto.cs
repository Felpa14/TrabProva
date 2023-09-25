using Microsoft.EntityFrameworkCore;
using TrabProva.Models;

namespace TrabProva.Data
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { 

        }

        public DbSet<EstoqueModel> Estoque{ get; set; }


    }
}
