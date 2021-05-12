using MWG.AK.Inventory.DAO.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Claim.Domain.SeedWork
{
    public interface IDataRepository<T> where T : IAggregateRoot
    {
        Task<IList<T>> GetAllAsync(Predicate<T> predicate);

        Task<T> GetById(long id);
    }
}
