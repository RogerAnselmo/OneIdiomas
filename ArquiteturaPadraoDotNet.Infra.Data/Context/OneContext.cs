using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;
using System.Linq;

namespace One.Infra.Data.Context
{
    public class OneContext : DbContext
    {
        public OneContext(DbContextOptions<OneContext> options) : base(options)
        { }

        #region GERAL
        public DbSet<ACAluno> ACAluno { get; set; }
        public DbSet<GEBairro> GEBairro { get; set; }
        public DbSet<GECidade> GECidade { get; set; }
        public GEEndereco GEEndereco { get; set; }
        public DbSet<ACResponsavel> ACResponsavel { get; set; }
        public DbSet<GETelefone> GETelefone { get; set; }
        public DbSet<GETipoTelefone> GETipoTelefone { get; set; }
        public DbSet<GEUF> GEUF { get; set; }
        public DbSet<GEParentesco> GEParentesco { get; set; }
        public DbSet<GEUsuarioEndereco> GEUsuarioEndereco { get; set; }
        #endregion

        #region ACADÊMICO
        public DbSet<ACNivel> ACNivel { get; set; }
        public DbSet<ACFaixaEtaria> ACFaixaEtaria { get; set; }
        public DbSet<ACProfessor> ACProfessor { get; set; }
        public DbSet<ACTurma> ACTurma { get; set; }
        #endregion

        #region SEGURANÇA
        public DbSet<SEGPerfil> SEGPerfil { get; set; }
        public DbSet<SEGUsuario> SEGUsuario { get; set; }
        public DbSet<SEGUsuarioPerfil> SEGUsuarioPerfil { get; set; }
        #endregion

        #region FINANCEIRO
        public DbSet<FIMensalidade> FIMensalidade { get; set; } 
        #endregion

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);
            //modelbuilder.Conventions.Remove<ManyToManyCascadeDeleteConve‌​ntion>();
            //modelbuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
