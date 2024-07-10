namespace Prontuario_Eletronico.Core.Entities
{
    public class Patient : BaseEntity
    {        
        public string Name {get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Minor { get; private set; }
        public string ReferencePersonName { get; set; }
        public string ReferencePersonPhone { get; set; }
        public string Email { get; set; }
        public Guid ProfessionalId { get; set; }

        public Professional Professional { get; set; }

        public ICollection<Session> Sessions { get; set; }

        public void DefineifMinor()
        {
            int idade = DateTime.Now.Year - BirthDate.Year;

            if(DateTime.Now < BirthDate.AddYears(idade))            
                idade--;
            
            Minor = idade < 18;            
        }
    }
}
