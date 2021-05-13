using MWG.AK.Inventory.BLL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BLL.Persistence
{
    public interface IRepository<TAggregate, TAggregateId>
        where TAggregate : IAggregate<TAggregateId>
    {
        Task<TAggregate> GetByIdAsync(TAggregateId id);

        Task SaveAsync(TAggregate aggregate);
    }

    [Serializable]
    public class RepositoryException : Exception
    {
        public RepositoryException() { }
        public RepositoryException(string message) : base(message) { }
        public RepositoryException(string message, Exception inner) : base(message, inner) { }
        protected RepositoryException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
