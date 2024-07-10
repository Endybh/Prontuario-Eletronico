using System.Linq.Expressions;
using Prontuario_Eletronico.Core.Entities;

namespace SessionAppointment.Core.Interfaces.Repositories
{
    public interface IGenericRepository<Entity> where Entity : BaseEntity
    {
        Task<Entity> AdicionarAsync(Entity entitie);
        Task AtualizarAsync(Entity entitie);
        Task<List<Entity>> EncontrarAsync(Expression<Func<Entity, bool>> predicate);
        Task<List<Entity>> EncontrarAsync(Expression<Func<Entity, bool>> predicate, params Expression<Func<Entity, object>>[] includes);
        Task<Entity> ObterAsync(int id);
        Task RemoverAsync(Entity entitie);
    }
}
