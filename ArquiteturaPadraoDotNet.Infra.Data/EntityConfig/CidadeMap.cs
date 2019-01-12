using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Infra.Data.EntityConfig
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> entity)
        {
            entity.ToTable("Cidade", "dbo");

            entity.HasKey(e => e.CodigoCidade);
            entity.Property(e => e.CodigoCidade).HasColumnName("CodigoCidade").ValueGeneratedOnAdd();
            entity.Property(e => e.CodigoUF).HasColumnName("CodigoUF");
            entity.Property(e => e.Descricao).HasColumnName("Descricao").HasMaxLength(60);
            entity.Property(e => e.flAtivo).HasColumnName("flAtivo").HasMaxLength(1);

            entity.HasOne(e => e.UF).WithMany(u => u.Cidades);
        }
    }
}
