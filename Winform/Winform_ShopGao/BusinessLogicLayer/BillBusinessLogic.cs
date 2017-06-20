using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ValueObject;

namespace BusinessLogicLayer
{
   public class BillBusinessLogic
   {
       private BillDataAccessLayer _access;

       public BillBusinessLogic()
       {
            _access = new BillDataAccessLayer();
       }

       public List<BillValueObject> GetAllBill()
       {
           var data = _access.GetAllBill();
           return (from DataRow row in data.Rows
               select new BillValueObject(int.Parse(row[0].ToString()), int.Parse(row[1].ToString()),
                   DateTime.Parse(row[2].ToString()), int.Parse(row[3].ToString()), row[4].ToString(),
                   row[5].ToString(),
                   int.Parse(row[6].ToString()))).ToList();
       }

       public bool CreateNewBill(BillValueObject bill)
       {
           return _access.CreateNewBill(bill.IdCus, bill.DateOrder, bill.Total, bill.Addr, bill.Note, bill.Status);
       }
   }
}
