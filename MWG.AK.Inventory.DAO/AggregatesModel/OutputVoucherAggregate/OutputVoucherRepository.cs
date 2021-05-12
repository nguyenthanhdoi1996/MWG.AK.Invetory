using Claim.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using MWG.AK.Inventory.BO.AggregatesModel;
using MWG.AK.Inventory.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.DAO.AggregatesModel.OutputVoucherAggregate
{
    public class OutputVoucherRepository : IOutputVoucherRepository
    {
        private readonly InventoryContext _context;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return (IUnitOfWork)_context;
            }
        }

        public OutputVoucherRepository(InventoryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<OutputVoucher> GetById(string outputVoucherId)
        {
            var result = await _context.OutputVoucher.Where(x => x.outputvoucherid == outputVoucherId).FirstOrDefaultAsync();
            return result;
        }

        public async Task Add(OutputVoucher objOutputVoucher)
        {
             _context.Add(objOutputVoucher);
        }
    }
}
