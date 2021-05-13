using MWG.AK.Inventory.BLL.Application.Commands.CreateOutputVoucher;
using MWG.AK.Inventory.BLL.Application.Services;
using MWG.AK.Inventory.BLL.Core;
using MWG.AK.Inventory.BLL.Persistence;
using MWG.AK.Inventory.BLL.PubSubEvent;
using MWG.AK.Inventory.BO.AggregatesModel;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OutputVoucher = MWG.AK.Inventory.BLL.Application.Commands.CreateOutputVoucher.OutputVoucher;

namespace MWG.AK.Inventory.Application.Commands.CreateEventLog
{
    public class CreateOutputVoucherHandlerBase
    {
        private readonly IRepository<OutputVoucher, OutputVoucherId> _repository;
        private readonly ITransientDomainEventSubscriber _subscriber;
        private readonly IEnumerable<IDomainEventHandler<OutputVoucherId, OutputVoucherEvent>> outputVoucherCreatedEventHandlers;

        public async Task<OutputVoucher> Handle(CreateOutputVoucherCommand request, CancellationToken cancellationToken)
        {
            var objOutputVoucher = new OutputVoucher(request.OUTPUTVOUCHERID, request.CUSTOMERID, request.CUSTOMERNAME, request.CUSTOMERADDRESS, request.CUSTOMERTAXID, request.CUSTOMERPHONE, request.CUSTOMERFAX,
                request.CUSTOMEREMAIL, request.INVOICETYPE, request.INVOICEPATTERN, request.INVOICESYMBOL, request.INVOICEDATE, request.ORIGINALSTOREID, request.STOREID, request.ACCOUNTINGSTOREID, request.CURRENTCYUNITID,
                request.TOTALAMOUNTBF, request.DISCOUNTVATTYPE);
            _subscriber.Subscribe<OutputVoucherEvent>(async @event => await HandleAsync(outputVoucherCreatedEventHandlers, @event));
            await _repository.SaveAsync(objOutputVoucher);
            return objOutputVoucher;
        }

        private async Task HandleAsync<T>(IEnumerable<IDomainEventHandler<OutputVoucherId, T>> handlers, T @event)
            where T : IDomainEvent<OutputVoucherId>
        {
            foreach (var handler in handlers)
            {
                await handler.HandleAsync(@event);
            }
        }
    }
}