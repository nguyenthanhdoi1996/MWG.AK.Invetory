using Claim.Domain.SeedWork;
using MWG.AK.Inventory.BO.AggregatesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.DAO.AggregatesModel.OutputVoucherAggregate
{
    public interface IOutputVoucherRepository : IRepository<OutputVoucher>
    {
        Task<OutputVoucher> GetById(string outputVoucherId);

        Task Add(OutputVoucher objOutputVoucher);
    }
}
