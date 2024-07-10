namespace Prontuario_Eletronico.Core.Entities
{
    public class Session : BaseEntity
    {        
        public string Anotations { get; set; }
        public Guid PatientId { get; set; }
        public DateTime Date { get; set; }

        public Patient Patient { get; set; }        
    }
}
