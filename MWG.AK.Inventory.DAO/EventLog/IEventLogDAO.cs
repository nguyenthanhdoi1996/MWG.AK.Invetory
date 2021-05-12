using MWG.AK.Inventory.BO.OutputVoucher;
using MWG.AK.Inventory.DAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BLL.EventLog
{
    public interface IEventLogDAO
    {
        public bool CreateOutputVoucher(OutputVoucherBO data);
        public List<system_eventlog> GetUnPublishedEventList(string strEventType);
        public void SetStateToPublished(long enventId);
    }
}
