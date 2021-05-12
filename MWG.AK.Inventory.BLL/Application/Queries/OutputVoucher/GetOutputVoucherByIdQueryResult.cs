using MWG.AK.Inventory.DAO.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BLL.Application.Queries.OutputVoucher
{
    public class GetOutputVoucherByIdQueryResult : IAggregateRoot
    {
        public GetOutputVoucherByIdQueryResult(MWG.AK.Inventory.BO.AggregatesModel.OutputVoucher objOutputVoucher)
        {
            OutputVoucher = objOutputVoucher;
        }

        public MWG.AK.Inventory.BO.AggregatesModel.OutputVoucher OutputVoucher { get; private set; }
    }
}
