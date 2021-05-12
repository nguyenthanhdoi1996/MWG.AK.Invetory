using MediatR;
using MWG.AK.Inventory.BO;
using MWG.AK.Inventory.BO.AggregatesModel;
using MWG.AK.Inventory.BO.Attachment;
using MWG.AK.Inventory.BO.OutputVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWG.AK.Inventory.BLL.Application.Commands.CreateOutputVoucher
{
    public class CreateOutputVoucherCommand: BaseBO, IRequest<OutputVoucher>
    {
        string id = string.Empty;
        /// <summary>
        /// Mã phiếu xuất: N_05_04_Sothutu xxxx
        /// </summary>
        public string OUTPUTVOUCHERID
        {
            get
            { return id.Trim(); }
            set { id = value ?? string.Empty; }
        }
        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public int CUSTOMERID { get; set; }
        /// <summary>
        /// Tên khách hàng
        /// </summary>
        public string CUSTOMERNAME { get; set; }
        /// <summary>
        /// Địa chỉ khách hàng
        /// </summary>
        public string CUSTOMERADDRESS { get; set; }
        /// <summary>
        /// Mã số thuế khách hàng
        /// </summary>
        public string CUSTOMERTAXID { get; set; }
        /// <summary>
        /// Số điện thoại khách hàng
        /// </summary>
        public string CUSTOMERPHONE { get; set; }
        /// <summary>
        /// Mã fax của khách hàng
        /// </summary>
        public string CUSTOMERFAX { get; set; }
        /// <summary>
        /// Mail khách hàng
        /// </summary>
        public string CUSTOMEREMAIL { get; set; }
        /// <summary>
        /// 1: Hóa đơn GTGT
        /// 2: Phiếu xuất kho kiêm vận chuyển nội bộ
        /// </summary>
        public Int16 INVOICETYPE { get; set; }
        /// <summary>
        /// Mã chứng từ hóa đơn
        /// </summary>
        public string INVOICEID { get; set; }
        /// <summary>
        /// Mẫu số hóa đơn
        /// </summary>
        public string INVOICEPATTERN { get; set; }
        /// <summary>
        /// ký hiệu hóa đơn
        /// </summary>
        public string INVOICESYMBOL { get; set; }
        /// <summary>
        /// Ngày hóa đơn
        /// </summary>
        public DateTime? INVOICEDATE { get; set; }
        /// <summary>
        /// Kho chứng từ phát sinh
        /// </summary>
        public int ORIGINALSTOREID { get; set; }
        /// <summary>
        /// Kho xuất hàng (xác định công ty của phiếu này)
        /// </summary>
        public int STOREID { get; set; }
        /// <summary>
        /// Kho hạch toán của chứng từ
        /// </summary>
        public int ACCOUNTINGSTOREID { get; set; }
        /// <summary>
        /// Mã đơn vị tiền tệ
        /// </summary>
        public int? CURRENTCYUNITID { get; set; }
        /// <summary>
        /// Tỷ giá quy đổi về VNĐ
        /// </summary>
        public double? CURRENCYEXCHANGE { get; set; }
        /// <summary>
        /// Cộng từ detail
        /// </summary>
        public double TOTALAMOUNTBF { get; set; }
        /// <summary>
        /// DISCOUNTTYPE 1: Chiết khấu trước thuế; 2: Chiết khấu sau thuế
        /// </summary>
        public int DISCOUNTVATTYPE { get; set; }
        /// <summary>
        /// Giảm giá
        /// </summary>
        public double DISCOUNT { get; set; }
        /// <summary>
        /// Lý do giảm giá
        /// </summary>
        public int DISCOUNTREASONID { get; set; }
        /// <summary>
        /// Tổng tiền thuế của phiếu xuất
        /// </summary>
        public double TOTALVAT { get; set; }
        /// <summary>
        /// Tổng tiền phải thanh toán
        /// </summary>
        public double TOTALAMOUNT { get; set; }
        /// <summary>
        /// Số chênh lệch khi làm tròn
        /// </summary>
        public double ROUNDMONEY { get; set; }
        /// <summary>
        /// Hình thức thanh toán
        /// </summary>
        public int PAYABLETYPEID { get; set; }
        /// <summary>
        /// Nội dung xuất
        /// </summary>
        public string NOTE { get; set; }
        /// <summary>
        /// Mã loại chứng từ liên quan
        /// </summary>
        public string VOUCHERCONCERNTYPE { get; set; }
        /// <summary>
        /// Chứng từ liên quan
        /// </summary>
        public string VOUCHERCONCERN { get; set; }
        /// <summary>
        /// Tạo từ: Web, APP
        /// </summary>
        public string CREATEDAPP { get; set; }
        /// <summary>
        /// Đã hạch toán
        /// </summary>
        public bool ISPOSTED { get; set; }
        /// <summary>
        /// nv xuất
        /// </summary>
        public string OUTPUTUSER { get; set; }
        /// <summary>
        /// ngày xuất
        /// </summary>
        public DateTime? OUTPUTDATE { get; set; }
        public string FULLNAME { get; set; }

        //public int OUTPUTTYPEID { set; get; }
        public string TRACEID { get; set; }
        public string STORENAME { get; set; }
        public short? PRINTTYPE { get; set; }
        /// <summary>
        /// OuputvoucherId reference
        /// </summary>
        public string VOUCHERCONCERNAPPID { get; set; }
        public List<AttachmentBO> ATTACHMENTBOLIST;
        public List<OutputVoucherDetailBO> LISTOUTPUTVOUCHERDETAILBO { get { return OutputVoucherDetailBOList ?? ListOutputVoucherDetailBO; } }
        public List<OutputVoucherDetailBO> OutputVoucherDetailBOList;

        public List<OutputVoucherDetailBO> LISTOUTPUTVOUCHERDETAIL { get; set; }

        public List<OutputVoucherPayBO> LISTOUTPUTVOUCHERPAYBO { get; set; }

        public List<OutputVoucherApplyPromotionBO> LISTOUTPUTVOUCHERAPPLYPROMOTIONBO { get; set; }
        public List<OutputVoucherDetailBO> ListOutputVoucherDetailBO;
    }
}
