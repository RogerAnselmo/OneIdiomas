using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;
using One.Infra.Data.EntityConfig;

namespace One.Infra.Data.Context
{
    public class OneContext: DbContext
    {
        public OneContext(DbContextOptions<OneContext> options) : base(options)
        { }

        public DbSet<UF> UF { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UFMap());
            modelBuilder.ApplyConfiguration(new CidadeMap());
        }
    }
}
