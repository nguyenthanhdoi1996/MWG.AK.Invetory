using MWG.AK.Inventory.BLL.Core;
using System;

namespace MWG.AK.Inventory.BLL.Application.Commands.CreateOutputVoucher
{
    public class OutputVoucherId : IAggregateId
    {
        private const string IdAsStringPrefix = "OutputVoucher-";
        public Guid Id { get; private set; }
        private OutputVoucherId(Guid id)
        {
            Id = id;
        }

        public static OutputVoucherId NewCartId()
        {
            return new OutputVoucherId(Guid.NewGuid());
        }

        public string IdAsString()
        {
            return $"{IdAsStringPrefix}{Id.ToString()}";
        }
    }
}
