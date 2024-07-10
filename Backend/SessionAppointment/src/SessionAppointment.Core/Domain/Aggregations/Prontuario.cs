using Prontuario_Eletronico.Core.Entities;

namespace Prontuario_Eletronico.Core.Aggregations
{
    public class Prontuario
    {
        public Professional Professional { get; private set; }

        public Patient Patient { get; private set; } = new Patient();

        public List<Session> Sessions {get; private set; } = new List<Session>();

        public void AdicionarSessao(string anotations)
        {
            Sessions.Add(new Session{Anotations = anotations, Id = Guid.NewGuid(), PatientId = Patient.Id, Date = DateTime.UtcNow});
        }

        public void DefinirProfissional(Professional professional)
        {
            Professional = professional;
        }

        public void DefinirPaciente(string nome, string telefone, DateTime dataNascimento, string nomePessoaReferencia, string telefonePessoaReferencia)
        {
            Patient.Id = Guid.NewGuid();
            Patient.BirthDate = dataNascimento;
            Patient.Phone = telefone;
            Patient.Name = nome;
            Patient.ReferencePersonName = nomePessoaReferencia;
            Patient.ReferencePersonPhone = telefonePessoaReferencia;
            Patient.DefineifMinor();
        }
    }
}
