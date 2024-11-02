using Microsoft.EntityFrameworkCore;

namespace AtividadeOrm.Models
{
    public class MyDbContext:DbContext
    {
        public MydbContext(DbContextOptions< MydbContext> options):base(options) { }

        public DbSet<Veiculo> veiculo { get; set; }
        public DbSet<Proprietario> Props { get; set; }

    }
}
