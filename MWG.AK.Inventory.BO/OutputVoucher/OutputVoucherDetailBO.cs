using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BO.OutputVoucher
{
    [Serializable]
    public class OutputVoucherDetailBO : BaseBO
    {
        public OutputVoucherDetailBO()
        {
            PRODUCTID = "";
        }
        /// <summary>
        /// Mã chi tiết phiếu xuất
        /// </summary>
        public string OUTPUTVOUCHERDETAILID { get; set; }
        /// <summary>
        /// Mã phiếu xuất
        /// </summary>
        public string OUTPUTVOUCHERID { get; set; }
        /// <summary>
        /// Mã sản phẩm xuất
        /// </summary>
        public string PRODUCTID { get; set; }
        public string PRODUCTIDTRIM
        {
            get
            {
                if (string.IsNullOrEmpty(PRODUCTID))
                {
                    return null;
                }
                return PRODUCTID.Trim();
            }
        }
        /// <summary>
        /// Trạng thái tồn của sản phẩm
        /// </summary>
        public int INVENTORYSTATUSID { get; set; }
        /// <summary>
        /// Hình thức xuất
        /// </summary>
        public int OUTPUTTYPEID { get; set; }
        /// <summary>
        /// Đơn vị của sản phẩm
        /// </summary>
        public int QUANTITYUNITID { get; set; }
        /// <summary>
        /// Số lượng xuất trên phiếu
        /// </summary>
        public double QUANTITY { get; set; }
        /// <summary>
        /// đơn giá chuẩn trong làm giá
        /// </summary>
        public double RETAILPRICE { get; set; }
        /// <summary>
        /// đơn giá chiết khấu của 1 đơn vị sản phẩm
        /// </summary>
        public double DISCOUNT { get; set; }
        /// <summary>
        /// Đơn giá vốn (Giá trước thuế)
        /// </summary>
        public double COSTPRICE { get; set; }
        /// <summary>
        /// Đơn Giá bán
        /// </summary>
        public double SALEPRICE { get; set; }
        /// <summary>
        /// Thuế suất của sản phẩm
        /// </summary>
        public int VAT { get; set; }
        /// <summary>
        /// % Thuế phải nộp của sản phẩm
        /// </summary>
        public int VATPERCENT { get; set; }
        /// <summary>
        /// Đơn vị tính cơ sở của model
        /// </summary>
        public int ORIGINALQUANTITYUNITID { get; set; }
        /// <summary>
        /// Hệ số quy đổi về sản phẩm cơ sở
        /// </summary>
        public double EXCHANGEQUANTITY { get; set; }
        /// <summary>
        /// Kho tạo: để đồng bộ dữ liệu posclient
        /// </summary>
        public int ORIGINALSTOREID { get; set; }
        /// <summary>
        /// </summary>
        public string IMEI { get; set; }
        /// <summary>
        /// Số serial
        /// </summary>
        public string SERIALNUMBERS { get; set; }
        /// <summary>
        /// Mã lô date
        /// </summary>
        public Int64 BATCHID { get; set; }
        /// <summary>
        /// Ngày hết hạn của sản phẩm
        /// </summary>
        public DateTime? EXPIRATIONDATE { get; set; }
        /// <summary>
        /// Ngày sản xuất
        /// </summary>
        public DateTime? MANUFACTUREDATE { get; set; }
        /// <summary>
        /// Chứng từ liên quan
        /// </summary>
        public string VOUCHERCONCERN { get; set; }

        /// <summary>
        /// </summary>
        public string VOUCHERCONCERNTYPE { get; set; }
        public int REFSTOREID { get; set; }

        public string NOTE { set; get; }//chua co DB
        public string QUANTITYUNIT { set; get; }
        public int SHOWQUANTITYUNITID { set; get; }
        public double AVGQUANTITY { set; get; }
        public string PRODUCTNAME { set; get; }
        public int? MORNINGQTY { set; get; }
        public int? NOONQTY { set; get; }
        public int? AFTERNOONQTY { set; get; }
        public int? EVENINGQTY { set; get; }
        public string OUTPUTTYPENAME { get; set; }
        public double TOTALAMOUNT
        {
            get
            {
                return QUANTITY * SALEPRICE * (1 + VAT * 0.01);
            }
        }
    }
}
