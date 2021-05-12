using MediatR;
using MWG.AK.Inventory.BLL.Application.Commands.CreateOutputVoucher;
using MWG.AK.Inventory.BO.AggregatesModel;
using MWG.AK.Inventory.DAO.AggregatesModel.OutputVoucherAggregate;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.Application.Commands.CreateEventLog
{
    public class CreateOutputVoucherHandler : IRequestHandler<CreateOutputVoucherCommand, OutputVoucher>
    {
        private readonly IOutputVoucherRepository _repository;
        public CreateOutputVoucherHandler(IOutputVoucherRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<OutputVoucher> Handle(CreateOutputVoucherCommand request, CancellationToken cancellationToken)
        {
            var objOutputVoucher = new OutputVoucher(request.OUTPUTVOUCHERID, request.CUSTOMERID, request.CUSTOMERNAME, request.CUSTOMERADDRESS, request.CUSTOMERTAXID, request.CUSTOMERPHONE, request.CUSTOMERFAX ,
                request.CUSTOMEREMAIL, request.INVOICETYPE, request.INVOICEPATTERN, request.INVOICESYMBOL, request.INVOICEDATE, request.ORIGINALSTOREID, request.STOREID, request.ACCOUNTINGSTOREID, request.CURRENTCYUNITID,
                request.TOTALAMOUNTBF, request.DISCOUNTVATTYPE);
            _repository.Add(objOutputVoucher);
            _repository.UnitOfWork.SaveEntitiesAsync();
            return objOutputVoucher;
        }
    }
}
