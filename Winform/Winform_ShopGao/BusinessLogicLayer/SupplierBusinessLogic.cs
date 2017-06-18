using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ValueObject;

namespace BusinessLogicLayer
{
    public class SupplierBusinessLogic
    {
        private SupplierDataAccessLayer _supplierDataAccessLayer;

        public SupplierBusinessLogic()
        {
            _supplierDataAccessLayer = new SupplierDataAccessLayer();
        }

        public List<SupplierValueObject> GetallSupplier()
        {
            var suppliers = new List<SupplierValueObject>();
            var dataTable = new DataTable();
            dataTable = _supplierDataAccessLayer.GetAllSupplier();
            foreach (DataRow row in dataTable.Rows)
            {
                suppliers.Add( new SupplierValueObject(Int32.Parse(row["id"].ToString()), row["name"].ToString(),
                    row["addr"].ToString(),row["mail"].ToString(),row["phone"].ToString()));
            }
            return suppliers;
        }

        public bool CreateSupplier(SupplierValueObject supplier)
        {
            return false;
        }

    }
}
