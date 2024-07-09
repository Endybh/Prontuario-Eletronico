namespace Prontuario_Eletronico.Core.Entities
{
    public class Professional : BaseEntity
    {        
        public string Name { get; set; }
        public string FunctionalNumber{ get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Patient> Patients { get; set; }
    }
}