using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class NominaConfiguration : IEntityTypeConfiguration<TipoNomina>
    {
        public void Configure(EntityTypeBuilder<TipoNomina> builder)
        {
            builder.ToTable("tiponomina");

            builder.Property(p => p.NombreNomina)
            .IsRequired()
            .HasMaxLength(15);
        }
    }
}