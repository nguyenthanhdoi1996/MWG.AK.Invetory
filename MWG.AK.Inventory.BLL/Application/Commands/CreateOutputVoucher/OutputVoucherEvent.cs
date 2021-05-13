using MWG.AK.Inventory.BLL.Core;

namespace MWG.AK.Inventory.BLL.Application.Commands.CreateOutputVoucher
{
    public class OutputVoucherEvent : DomainEventBase<OutputVoucherId>
    {
        public OutputVoucherId OutputVoucherId { get; private set; }

        internal OutputVoucherEvent(OutputVoucherId aggregateId, OutputVoucherId outputVoucherId) : base(aggregateId)
        {
            OutputVoucherId = outputVoucherId;
        }

        private OutputVoucherEvent(OutputVoucherId aggregateId, long aggregateVersion, OutputVoucherId outputVoucherId) : base(aggregateId, aggregateVersion)
        {
            OutputVoucherId = outputVoucherId;
        }

        public override IDomainEvent<OutputVoucherId> WithAggregate(OutputVoucherId aggregateId, long aggregateVersion)
        {
            return new OutputVoucherEvent(aggregateId, aggregateVersion, OutputVoucherId);
        }
    }
}
