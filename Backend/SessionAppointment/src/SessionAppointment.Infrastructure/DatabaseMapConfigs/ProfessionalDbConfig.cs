using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prontuario_Eletronico.Core.Entities;

namespace Prontuario_Eletronico.Infrastructure;

public class ProfessionalDbConfig : IEntityTypeConfiguration<Professional>
{
    public void Configure(EntityTypeBuilder<Professional> entity)
    {
        entity.HasKey(e => e.Id);

        entity.Property(e => e.Name);

        entity.Property(e => e.Email);

        entity.Property(e => e.Password);

        entity.Property(e => e.BirthDate);

        entity.Property(e => e.FunctionalNumber);

        entity.Property(e => e.CreatedAt);

        entity.Property(e => e.UpdatedAt);

        entity.Property(e => e.DeletedAt);

        entity.ToTable("profissional");
    }
}
