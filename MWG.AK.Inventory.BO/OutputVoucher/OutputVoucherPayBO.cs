using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BO.OutputVoucher
{
    [Serializable]
    public class OutputVoucherPayBO : BaseBO
    {
        /// <summary>
        /// Mã chi tiết thu chi
        /// </summary>
        public string PAYID { get; set; }
        /// <summary>
        /// Mã phiếu thu chi
        /// </summary>
        public string OUTPUTVOUCHERID { get; set; }
        /// <summary>
        /// Mã hình thức thu
        /// </summary>
        public int VOUCHERTYPEID { get; set; }
        /// <summary>
        /// số tiền thu
        /// </summary>
        public double CASH { get; set; }
        /// <summary>
        /// Tỷ giá
        /// </summary>
        public int CURRENCYUNITID { get; set; }
        /// <summary>
        /// Tỷ giá
        /// </summary>
        public double CURRENCYEXCHANGE { get; set; }
        /// <summary>
        /// Phương thức thanh toán: Tiền mặt, Thẻ ngân hàng, Phiếu quà tặng, Ví điện tử, Cổng trung gian thanh toán
        /// </summary>
        public short METHODOFPAYMENT { get; set; }
        /// <summary>
        /// Số tiền điều chỉnh khi làm tròn trong thu chi.
        ///Ví dụ: 1.999 vnd thu 2.000 vnd
        /// </summary>
        public double ROUNDMONEY { get; set; }
        /// <summary>
        /// Mã số của thẻ đối với hình thức thanh toán là thẻ
        /// </summary>
        public short CARDID { get; set; }
        /// <summary>
        /// Mã máy POS
        /// </summary>
        public string CARDPOSID { get; set; }
        /// <summary>
        /// Tiền phí khi thanh toán qua các hinh thức không phải tiền mặt VND: cà thẻ, ví điện tử, cổng thanh toán
        /// </summary>
        public double CARDSPEND { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CARDVOUCHERID { get; set; }
        /// <summary>
        /// Tiền trả lại khách
        /// </summary>
        public double REFUNDMONEY { get; set; }
        /// <summary>
        /// Ghi chú
        /// </summary>
        public string NOTE { get; set; }
        /// <summary>
        /// mã kho phát sinh nghiệp vụ
        /// </summary>
        public int STOREID { get; set; }
        /// <summary>
        /// Kho tạo phiếu
        /// </summary>
        public int ORIGINATESTOREID { get; set; }
        /// <summary>
        /// Mã ngân hàng thu tiền
        /// </summary>
        public short BANKID { get; set; }
        /// <summary>
        /// Người thu
        /// </summary>
        public string USERNAME { get; set; }
        /// <summary>
        /// Mã giao dịch thẻ 
        /// </summary>
        public string MONEYCARDVOUCHERID { get; set; }
        /// <summary>
        /// Mã phiếu mua hàng
        /// </summary>
        public string VOUCHERCODE { get; set; }
        /// <summary>
        /// Loại phiếu mua hàng thanh toán: 1 - PINCODE; 2 - IMEI
        /// </summary>
        public int VOUCHERTYPE { get; set; }
        /// <summary>
        /// Giá trị của voucher
        /// </summary>
        public double VOUCHERAMOUNT { get; set; }
    }
}
