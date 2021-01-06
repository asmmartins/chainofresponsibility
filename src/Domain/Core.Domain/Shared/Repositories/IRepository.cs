using Core.Domain.Shared.Models;
using Core.Domain.Shared.Specifications;
using System.Threading.Tasks;
using System.Linq;

namespace Core.Domain.Shared.Repositories
{
    public interface IRepository<TAggregate> where TAggregate : IRootAggregate
    {
        Task Add(TAggregate aggregate); 
        Task Update(TAggregate aggregate);
        Task Remove(TAggregate aggregate);
        Task<TAggregate> Get(Specification<TAggregate> specification);      
        Task<IQueryable<TAggregate>> GetAll(Specification<TAggregate> specification);
    }
}