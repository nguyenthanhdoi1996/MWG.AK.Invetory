using MWG.AK.Inventory.DAO.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BO.AggregatesModel
{
    public class OutputVoucher: IAggregateRoot
    {
        public string outputvoucherid { get; set; }
        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public int customerid { get; set; }
        /// <summary>
        /// Tên khách hàng
        /// </summary>
        public string customername { get; set; }
        /// <summary>
        /// Địa chỉ khách hàng
        /// </summary>
        public string customeraddress { get; set; }
        /// <summary>
        /// Mã số thuế khách hàng
        /// </summary>
        public string customertaxid { get; set; }
        /// <summary>
        /// Số điện thoại khách hàng
        /// </summary>
        public string customerphone { get; set; }
        /// <summary>
        /// Mã fax của khách hàng
        /// </summary>
        public string customerfax { get; set; }
        /// <summary>
        /// Mail khách hàng
        /// </summary>
        public string customeremail { get; set; }
        /// <summary>
        /// 1: Hóa đơn GTGT
        /// 2: Phiếu xuất kho kiêm vận chuyển nội bộ
        /// </summary>
        public Int16 invoicetype { get; set; }
        /// <summary>
        /// Mã chứng từ hóa đơn
        /// </summary>
        public string invoiceid { get; set; }
        /// <summary>
        /// Mẫu số hóa đơn
        /// </summary>
        public string invoicepattern { get; set; }
        /// <summary>
        /// ký hiệu hóa đơn
        /// </summary>
        public string invoicesymbol { get; set; }
        /// <summary>
        /// Ngày hóa đơn
        /// </summary>
        public DateTime? invoicedate { get; set; }
        /// <summary>
        /// Kho chứng từ phát sinh
        /// </summary>
        public int originalstoreid { get; set; }
        /// <summary>
        /// Kho xuất hàng (xác định công ty của phiếu này)
        /// </summary>
        public int storeid { get; set; }
        /// <summary>
        /// Kho hạch toán của chứng từ
        /// </summary>
        public int accountingstoreid { get; set; }
        /// <summary>
        /// Mã đơn vị tiền tệ
        /// </summary>
        public int? currentcyunitid { get; set; }
        /// <summary>
        /// Tỷ giá quy đổi về VNĐ
        /// </summary>
        public double? currencyexchange { get; set; }
        /// <summary>
        /// Cộng từ detail
        /// </summary>
        public double totalamountbf { get; set; }
        /// <summary>
        /// DISCOUNTTYPE 1: Chiết khấu trước thuế; 2: Chiết khấu sau thuế
        /// </summary>
        public int discountvattype { get; set; }
        /// <summary>
        /// Giảm giá
        /// </summary>
        public double discount { get; set; }
        /// <summary>
        /// Lý do giảm giá
        /// </summary>
        public int discountreasonid { get; set; }
        /// <summary>
        /// Tổng tiền thuế của phiếu xuất
        /// </summary>
        public double totalvat { get; set; }
        /// <summary>
        /// Tổng tiền phải thanh toán
        /// </summary>
        public double totalamount { get; set; }
        /// <summary>
        /// Số chênh lệch khi làm tròn
        /// </summary>
        public double roundmoney { get; set; }
        /// <summary>
        /// Hình thức thanh toán
        /// </summary>
        public int payabletypeid { get; set; }
        /// <summary>
        /// Nội dung xuất
        /// </summary>
        public string note { get; set; }
        /// <summary>
        /// Mã loại chứng từ liên quan
        /// </summary>
        public string voucherconcerntype { get; set; }
        /// <summary>
        /// Chứng từ liên quan
        /// </summary>
        public string voucherconcern { get; set; }
        /// <summary>
        /// Tạo từ: Web, APP
        /// </summary>
        public string createdapp { get; set; }
        /// <summary>
        /// Đã hạch toán
        /// </summary>
        public bool isposted { get; set; }
        /// <summary>
        /// nv xuất
        /// </summary>
        public string outputuser { get; set; }
        /// <summary>
        /// ngày xuất
        /// </summary>
        public DateTime? outputdate { get; set; }
        public string traceid { get; set; }
        public short? printtype { get; set; }

        public OutputVoucher(string oUTPUTVOUCHERID, int cUSTOMERID, string cUSTOMERNAME, string cUSTOMERADDRESS, string cUSTOMERTAXID, string cUSTOMERPHONE, string cUSTOMERFAX, string cUSTOMEREMAIL, short iNVOICETYPE, string iNVOICEPATTERN, string iNVOICESYMBOL, DateTime? iNVOICEDATE, int oRIGINALSTOREID, int sTOREID, int aCCOUNTINGSTOREID, int? cURRENTCYUNITID, double tOTALAMOUNTBF, int dISCOUNTVATTYPE)
        {
            outputvoucherid = oUTPUTVOUCHERID;
            customerid = cUSTOMERID;
            customername = cUSTOMERNAME;
            customeraddress = cUSTOMERADDRESS;
            customertaxid = cUSTOMERTAXID;
            customerphone = cUSTOMERPHONE;
            customerfax = cUSTOMERFAX;
            customeremail = cUSTOMEREMAIL;
            invoicetype = iNVOICETYPE;
            invoicepattern = iNVOICEPATTERN;
            invoicesymbol = iNVOICESYMBOL;
            invoicedate = iNVOICEDATE;
            originalstoreid = oRIGINALSTOREID;
            storeid = sTOREID;
            accountingstoreid = aCCOUNTINGSTOREID;
            currentcyunitid = cURRENTCYUNITID;
            totalamountbf = tOTALAMOUNTBF;
            discountvattype = dISCOUNTVATTYPE;
        }
    }
}
