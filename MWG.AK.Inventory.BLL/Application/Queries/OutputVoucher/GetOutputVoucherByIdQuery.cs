using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BLL.Application.Queries.OutputVoucher
{
    public class GetOutputVoucherByIdQuery : IRequest<GetOutputVoucherByIdQueryResult>
    {
        public GetOutputVoucherByIdQuery(string outputVoucherId)
        {
            outputvoucherid = outputVoucherId;
        }
        public string outputvoucherid { get; private set; }
    }
}
