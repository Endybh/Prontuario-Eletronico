using Prontuario_Eletronico.Core.Entities;

namespace SessionAppointment.Core.Application.Domain.Entities
{
    public class Session : BaseEntity
    {        
        public string Anotations { get; set; } = string.Empty;
        public Guid PatientId { get; set; }
        public DateTime Date { get; set; }

        public Patient Patient { get; set; } = new();
    }
}
