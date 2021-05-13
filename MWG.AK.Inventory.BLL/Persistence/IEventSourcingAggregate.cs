using MWG.AK.Inventory.BLL.Core;
using System.Collections.Generic;

namespace MWG.AK.Inventory.BLL.Persistence
{
    internal interface IEventSourcingAggregate<TAggregateId>
    {
        long Version { get; }
        void ApplyEvent(IDomainEvent<TAggregateId> @event, long version);
        IEnumerable<IDomainEvent<TAggregateId>> GetUncommittedEvents();
        void ClearUncommittedEvents();
    }
}
