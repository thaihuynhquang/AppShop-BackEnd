using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
   public class ImportValueObject
    {
        public int? Id { get; set; }
        public int IdNCC { get; set; }
        public string NhaCungCap { get; set; }
        public int IdSP { get; set; }
        public string SanPham { get; set; }
        public uint SoLuongTrongKho { get; set; }
        public int SoLuongTrenDonHang { get; set; }
        public uint Dongia { get; set; }
        public int TongTien { get; set; }

    public ImportValueObject(int? id, int supplierId, string supplierName, int productId, string productName, uint unitInStock, int unitOnBill, uint unitPrice, int totalPrice)
        {
            this.Id = id;
            this.IdNCC = supplierId;
            this.NhaCungCap = supplierName;
            this.IdSP = productId;
            this.SanPham = productName;
            this.SoLuongTrongKho = unitInStock;
            this.SoLuongTrenDonHang = unitOnBill;
            this.Dongia = unitPrice;
            this.TongTien = totalPrice;

        }
    }
}
