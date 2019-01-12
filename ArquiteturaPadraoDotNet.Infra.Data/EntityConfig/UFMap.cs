using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using One.Domain.Entities;

namespace One.Infra.Data.EntityConfig
{
    public class UFMap : IEntityTypeConfiguration<UF>
    {
        public void Configure(EntityTypeBuilder<UF> entity)
        {
            entity.ToTable("UF", "dbo");

            entity.HasKey(e => e.CodigoUF);
            entity.Property(e => e.CodigoUF).HasColumnName("CodigoUF").ValueGeneratedOnAdd();
            entity.Property(e => e.Descricao).HasColumnName("Descricao").HasMaxLength(30);
            entity.Property(e => e.Sigla).HasColumnName("Sigla").HasMaxLength(2);
            entity.Property(e => e.flAtivo).HasColumnName("flAtivo").HasMaxLength(1);

            entity.HasMany(e => e.Cidades).WithOne(c => c.UF);
        }
    }
}