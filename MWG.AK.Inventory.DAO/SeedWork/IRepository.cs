using MWG.AK.Inventory.DAO.SeedWork;
using System.Linq;
using System.Threading.Tasks;

namespace Claim.Domain.SeedWork
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        // IQueryable<T> Queryable();

        IUnitOfWork UnitOfWork { get; }
    }
}