using MWG.AK.Inventory.BLL.Core;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BLL.Application.Services
{
    public interface IDomainEventHandler<TAggregateId, TEvent>
        where TEvent : IDomainEvent<TAggregateId>
    {
        Task HandleAsync(TEvent @event);
    }
}
