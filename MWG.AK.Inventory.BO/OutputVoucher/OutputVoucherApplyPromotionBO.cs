using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BO.OutputVoucher
{
    [Serializable]
    public class OutputVoucherApplyPromotionBO : BaseBO
    {
        /// <summary>
        /// Mã chi tiết áp dụng khuyến mãi
        /// </summary>
        public long APPLYPROMOTIONID { get; set; }
        /// <summary>
        /// Mã phiếu thu chi
        /// </summary>
        public string OUTPUTVOUCHERID { get; set; }
        /// <summary>
        /// Mã CT KM
        /// </summary>
        public long PROMOTIONID { get; set; }
        /// <summary>
        /// số tiền giảm giá
        /// </summary>
        public double PROMOTIONDISCOUNT { get; set; }
        /// <summary>
        /// Hình thức áp dụng
        /// </summary>
        public short PROMOTIONAPPLYTYPE { get; set; }
        /// <summary>
        /// detail
        /// </summary>
        public List<OutputVoucherApplyPromotionBO> LISTOUTPUTVOUCHERAPPLYPROMOTIONDETAILBO { get; set; }
        public string GUID { get; set; }
    }
}
