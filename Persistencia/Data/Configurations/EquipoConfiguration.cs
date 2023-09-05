using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class EquipoConfiguration : IEntityTypeConfiguration<Equipo>
    {
        public void Configure(EntityTypeBuilder<Equipo> builder)
        {
            builder.ToTable("equipo");

            builder.Property(p => p.NombreEquipo)
            .IsRequired()
            .HasMaxLength(15);

            builder
            .HasOne(p=>p.Pais)
            .WithMany(p => p.Equipos)
            .HasForeignKey(p => p.IdPaisFk);
        }
    }
}