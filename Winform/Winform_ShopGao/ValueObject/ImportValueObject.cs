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
        public int IdNcc { get; set; }
        public int IdSp { get; set; }
        public int Soluong { get; set; }
        public int Dongia { get; set; }
        public int Tong { get; set; }

    public ImportValueObject(int? id, int idncc, int idsp, int sl, int dongia, int tong)
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
