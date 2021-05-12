using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BO.ResultMessage
{
    public class ResultMessageBO
    {
        public bool IsError { get; set; }
        public bool IsSuccess { get { return !IsError; } }
        public SystemErrorBO.ErrorTypes ErrorType { get; set; }
        public string Message { get; set; }
        public string MessageDetail { get; set; }
        public int ErrorCode { get; set; }
        public string Parram { get; set; }
        public string MessageSuccess = "Thành công";
    }
}
