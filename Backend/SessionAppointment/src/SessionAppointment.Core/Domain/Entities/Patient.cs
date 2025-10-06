using SessionAppointment.Core.Application.Domain.Entities;
using SessionAppointment.Core.Domain.Entities;

namespace Prontuario_Eletronico.Core.Entities
{
    public class Patient : BaseEntity
    {        
        public string Name {get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public bool Minor { get; private set; } = false;
        public string ReferencePersonName { get; set; } = string.Empty;
        public string ReferencePersonPhone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Guid ProfessionalId { get; set; } = Guid.NewGuid();
 
        public Professional Professional { get; set; } = new();

        public ICollection<Session> Sessions { get; set; } = new List<Session>();

        public void DefineifMinor()
        {
            int idade = DateTime.Now.Year - BirthDate.Year;

            if(DateTime.Now < BirthDate.AddYears(idade))            
                idade--;
            
            Minor = idade < 18;            
        }
    }
}
