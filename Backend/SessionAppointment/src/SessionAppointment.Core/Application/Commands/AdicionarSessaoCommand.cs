using MediatR;
using SessionAppointment.Core.Application.Responses;

namespace SessionAppointment.Core.Application.Application.Commands
{
    public class AdicionarSessao : IRequest<PostResponseDefault>
    {
        public string Anotations { get; set; } = string.Empty;
        public Guid ProfessionalId{get; set; } = Guid.Empty;
    }
}
