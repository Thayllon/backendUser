using Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .HasColumnType("varchar(100)");

            builder.Property(u => u.Sobrenome)
                .HasColumnType("varchar(100)");

            builder.Property(u => u.Email)
                .HasColumnType("varchar(100)");

            builder.Property(u => u.DataNascimento)
                .HasColumnType("date");

            builder.Property(u => u.Escolaridade)
                .HasColumnType("varchar(11)");
        }
    }
}
