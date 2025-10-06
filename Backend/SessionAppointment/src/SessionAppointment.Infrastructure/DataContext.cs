using Microsoft.EntityFrameworkCore;
using Prontuario_Eletronico.Core.Entities;
using SessionAppointment.Core.Application.Domain.Entities;
using SessionAppointment.Core.Domain.Entities;
using SessionAppointment.Infrastructure.DatabaseMapConfigs;
// ReSharper disable All

namespace SessionAppointment.Infrastructure
{
    public class DataContext : DbContext
    {
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProfessionalDbConfig());

            modelBuilder.ApplyConfiguration(new PatientDbConfig());

            modelBuilder.ApplyConfiguration(new SessaoDbConfig());            
        }
    }
}
