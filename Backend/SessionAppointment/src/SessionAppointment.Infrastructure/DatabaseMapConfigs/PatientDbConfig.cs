using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prontuario_Eletronico.Core.Entities;

namespace Prontuario_Eletronico.Infrastructure
{
    public class PatientDbConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> entity)
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Name);

            entity.Property(e => e.BirthDate);

            entity.Property(e => e.ReferencePersonName);

            entity.Property(e => e.Phone);

            entity.Property(e => e.ReferencePersonPhone);

            entity.Property(e => e.Email);

            entity.Property(e => e.CreatedAt);

            entity.Property(e => e.UpdatedAt);

            entity.Property(e => e.DeletedAt);
            
            entity.Property(e => e.ProfessionalId);

             entity.HasOne(e => e.Professional)
                  .WithMany(e => e.Patients)
                  .HasForeignKey(e => e.ProfessionalId);

            entity.ToTable("paciente");
        }
    }
}
