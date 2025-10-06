using MediatR;
using Prontuario_Eletronico.Core.Entities;
using SessionAppointment.Core.Domain.Entities;

namespace SessionAppointment.Core.Application.Commands
{
    public class AddProfessionalCommand : IRequest<Professional>
    {
        public string Name { get; set; } = string.Empty;
        public string FuncionalNumber{ get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.MinValue;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
