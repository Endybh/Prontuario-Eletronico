using System.Linq.Expressions;
using Prontuario_Eletronico.Core.Entities;

namespace Prontuario_Eletronico.Core.Interfaces.Repositories
{
    public interface IGenericoRepositorio<Entidade> where Entidade : BaseEntity
    {
        Task<Entidade> AdicionarAsync(Entidade entitie);
        Task AtualizarAsync(Entidade entitie);
        Task<List<Entidade>> EncontrarAsync(Expression<Func<Entidade, bool>> predicate);
        Task<List<Entidade>> EncontrarAsync(Expression<Func<Entidade, bool>> predicate, params Expression<Func<Entidade, object>>[] includes);
        Task<Entidade> ObterAsync(int id);
        Task RemoverAsync(Entidade entitie);
    }
}
