using MediatR;

namespace Prontuario_Eletronico.Core.Application
{
    public class AdicionarSessao : IRequest<PostResponseDefault>
    {
        public string Anotations { get; set; }
        public Guid ProfessionalId{get; set; }
    }
}
