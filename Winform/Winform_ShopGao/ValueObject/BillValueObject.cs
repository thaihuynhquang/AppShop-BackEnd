using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
   public class BillValueObject
   {
       public int? Id { get; set; }
       public int IdCus { get; set; }
        public DateTime DateOrder { get; set; }
        public int Total { get; set; }
        public string Addr { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }

        public BillValueObject(int? id, int idCus, DateTime order, int total, string addr, string note, int status)
       {
           this.Id = id;
           this.IdCus = idCus;
           this.DateOrder = order;
           this.Total = total;
           this.Addr = addr;
           this.Note = note;
           this.Status = status;
       }
   }
}
