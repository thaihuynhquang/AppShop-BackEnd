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
        public int SoLuongSanPham { get; set; }
        public int Dongia { get; set; }
        public int TongTien { get; set; }

    public ImportValueObject(int? id, int supplierId, string supplierName, int productId, string productName, int unitInStock, int unitPrice)
        {
            this.Id = id;
            this.IdNcc = idncc;
            this.IdSp = idsp;
            this.Soluong = sl;
            this.Dongia = dongia;
            this.Tong = tong;

        }
    }
}
