using MediatR;
using MWG.AK.Inventory.DAO.AggregatesModel.OutputVoucherAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BLL.Application.Queries.OutputVoucher
{
    public class GetOutputVoucherByIdQueryHanlder : IRequestHandler<GetOutputVoucherByIdQuery, GetOutputVoucherByIdQueryResult>
    {
        private readonly IOutputVoucherRepository _repository;
        public GetOutputVoucherByIdQueryHanlder(IOutputVoucherRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task<GetOutputVoucherByIdQueryResult> Handle(GetOutputVoucherByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetById(request.outputvoucherid);
            if(result== null)
                throw new Exception("Not_Found");
            return new GetOutputVoucherByIdQueryResult(result);
        }
    }
}
