using MediatR;
using Prontuario_Eletronico.Core.Entities;
using SessionAppointment.Core.Application.Domain.Entities;
using SessionAppointment.Core.Domain.Aggregations;
using SessionAppointment.Core.Domain.Entities;

namespace SessionAppointment.Core.Application.Commands
{
    public class CriarProntuarioCommand : IRequest<Prontuario>
    {
        public Professional Professional { get; private set; } = new();

        public Patient Patient { get; private set; } = new Patient();

        public List<Session> Sessions {get; private set; } = new List<Session>();
    }
}
