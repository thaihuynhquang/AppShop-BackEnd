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
                        DateTime.Parse(row[2].ToString()), DateTime.Parse(row[3].ToString()), int.Parse(row[4].ToString()), row[5].ToString(),
                        row[6].ToString(), row[7].ToString(), row[8].ToString(), int.Parse(row[9].ToString()),
                        int.Parse(row[10].ToString()))).ToList();
        }

        public bool CreateNewBill(BillValueObject bill)
        {
            return _access.CreateNewBill(bill.IdCus, bill.DateOrder, bill.ExpectedDateOrder, bill.Total, bill.Addr, bill.Dis, bill.City, bill.Note, bill.Status, bill.IdShipper);
        }
    }
}
