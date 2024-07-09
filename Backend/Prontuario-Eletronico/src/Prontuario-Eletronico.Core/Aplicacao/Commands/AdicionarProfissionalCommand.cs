using MediatR;
using Prontuario_Eletronico.Core.Entities;

namespace Prontuario_Eletronico.Core.Application
{
    public class AddProfessionalCommand : IRequest<Professional>
    {
        public string Name { get; set; }
        public string FuncionalNumber{ get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
