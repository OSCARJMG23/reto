using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona");

            builder.Property(p => p.NombrePersona)
            .IsRequired()
            .HasMaxLength(25);

            builder.Property(p => p.ApellidpPersona)
            .IsRequired()
            .HasMaxLength(25);

            builder.Property(p => p.Edad)
            .IsRequired()
            .HasColumnType("int");

            builder
            .HasOne(p=>p.Equipo)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdEquipoFk);

            builder
            .HasOne(p=>p.TipoNomina)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoNominaFk);

            builder
            .HasOne(p =>p.Jugador)
            .WithOne(p => p.Persona)
            .HasForeignKey<Jugador>(p =>p.IdPersonaFk);
        }
    }
}