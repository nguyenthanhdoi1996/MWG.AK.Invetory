using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BO.Attachment
{
    [Serializable]
    public class AttachmentBO : BaseBO
    {
        /// <summary>
        /// Mã chứng từ đính kèm
        /// </summary>
        public string ATTACHMENTID { get; set; }
        /// <summary>
        /// Loại chứng từ:
        /// 1: phiếu nhập
        /// 2: phiếu xuất
        /// 3: đơn hàng bán
        /// 4: đơn hàng mua
        /// 5: yêu cầu chuyển kho
        /// </summary>
        public Int16 VOUCHERTYPEID { get; set; }
        /// <summary>
        /// mã chứng từ
        /// </summary>
        public string VOUCHERID { get; set; }
        /// <summary>
        /// nội dung, ghi chú
        /// </summary>
        public string NOTE { get; set; }
        /// <summary>
        /// đường dẫn URL file
        /// </summary>
        public string FILEPATH { get; set; }
        /// <summary>
        /// Tên file
        /// </summary>
        public string FILENAME { get; set; }
    }
}
