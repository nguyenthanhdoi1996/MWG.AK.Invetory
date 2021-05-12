using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BO
{
    public class BaseBO
    {
        public DateTime CREATEDDATE { set; get; }
        public string CREATEDUSER { set; get; }
        public DateTime? UPDATEDDATE { set; get; }
        public string UPDATEDUSER { set; get; }
        public bool ISDELETED { set; get; }
        public DateTime? DELETEDDATE { set; get; }
        public string DELETEDUSER { set; get; }
        public long TOTALROW { get; set; }
        public long STT { get; set; }
        public string LOGINUSER { get; set; }
        public int LOGINSTOREID { get; set; }
    }
}
