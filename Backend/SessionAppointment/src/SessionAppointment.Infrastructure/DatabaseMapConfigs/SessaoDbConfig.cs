using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prontuario_Eletronico.Core.Entities;

namespace Prontuario_Eletronico.Infrastructure
{
    public class SessaoDbConfig : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> entity)
        {
            entity.HasKey(e => e.Id);        

            entity.Property(e => e.Anotations);

            entity.Property(e => e.Date);

            entity.Property(e => e.CreatedAt);

            entity.Property(e => e.UpdatedAt);

            entity.Property(e => e.DeletedAt);
            
            entity.Property(e => e.PatientId);

            entity.HasOne(e => e.Patient)
                  .WithMany(e => e.Sessions)
                  .HasForeignKey(e => e.PatientId);
                  

            entity.ToTable("sessao");
        }
    }
}
