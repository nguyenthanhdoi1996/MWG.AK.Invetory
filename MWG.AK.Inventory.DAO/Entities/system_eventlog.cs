using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.DAO.Entities
{
    public class system_eventlog
    {
        [Key]
        public long eventid { get; set; }
        public string eventtype { get; set; }
        public string eventbody { get; set; }
        public string eventstate { get; set; }
        public DateTime createdate { get; set; }
        public DateTime publishdate { get; set; }
        public string traceid { get; set; }
    }
}
