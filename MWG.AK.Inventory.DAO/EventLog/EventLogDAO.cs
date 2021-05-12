using MWG.AK.Inventory.BO.OutputVoucher;
using MWG.AK.Inventory.DAO.Entities;
using MWG.AK.Inventory.Reponsitory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BLL.EventLog
{
    public class EventLogDAO : IEventLogDAO
    {
        private IRepository<system_eventlog> _eventLogRepository;
        private string strEventstate = "INIT";
        public EventLogDAO(IRepository<system_eventlog> eventLogRepository)
        {
            _eventLogRepository = eventLogRepository;
        }
        public bool CreateOutputVoucher(OutputVoucherBO objOutputVoucherBO)
        {
            system_eventlog objEventlog = new system_eventlog()
            {
                eventbody = JsonConvert.SerializeObject(objOutputVoucherBO),
                createdate = DateTime.Now,
                eventstate = "INIT",
                eventtype = "CreateOutputVoucher",
                traceid = objOutputVoucherBO.OUTPUTVOUCHERID
            };
            return _eventLogRepository.Insert(objEventlog); 
        }
        public List<system_eventlog> GetUnPublishedEventList(string strEventType)
        {
            List<system_eventlog> objEventlogs = new List<system_eventlog>();
            if (string.IsNullOrEmpty(strEventType)) {
                objEventlogs =  _eventLogRepository.Queryable().Where(x => x.eventtype == strEventType && x.eventstate == strEventstate).ToList();
            }
            return objEventlogs;
        }
        public void SetStateToPublished(long enventId)
        {
            var objEventLog = _eventLogRepository.Queryable().FirstOrDefault(x => x.eventid == enventId);
            if(objEventLog != null)
            {
                objEventLog.eventstate = "PUBLISHED";
                objEventLog.publishdate = DateTime.Now;
                _eventLogRepository.Update(objEventLog);
            }
        }
    }
}
