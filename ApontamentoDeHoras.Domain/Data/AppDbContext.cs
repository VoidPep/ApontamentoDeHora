using System.Data.Entity;
using ApontamentoDeHoras.Domain.Models;

namespace ApontamentoDeHoras.Domain.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("SQLiteConnection") { }

        public DbSet<TempoDecorrido> Tempos { get; set; }
    }
}
