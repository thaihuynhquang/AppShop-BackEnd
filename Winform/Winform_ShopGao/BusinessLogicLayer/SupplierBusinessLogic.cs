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
    public class SupplierBusinessLogic
    {
        private SupplierDataAccessLayer _supplierDataAccessLayer;

        public SupplierBusinessLogic()
        {
            _supplierDataAccessLayer = new SupplierDataAccessLayer();
        }

        public List<SupplierValueObject> GetallSupplier()
        {
            var dataTable = _supplierDataAccessLayer.GetAllSupplier();
            return (from DataRow row in dataTable.Rows select new SupplierValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), row["addr"].ToString(), row["mail"].ToString(), row["phone"].ToString())).ToList();
        }

        public bool CreateSupplier(SupplierValueObject supplier)
        {
           return _supplierDataAccessLayer.CreateNewSupplier(supplier._name, supplier._address, supplier._email,
                supplier._phone);
        }

        public bool UpdateSupplier(SupplierValueObject supplier)
        {
            return _supplierDataAccessLayer.UpdateSupplier(supplier._id,supplier._name, supplier._address, supplier._email,
                supplier._phone);
        }

        public SupplierValueObject GetDetailSupplier(int id)
        {
            var dataTable = _supplierDataAccessLayer.GetDetailSupplier(id);
            return (from DataRow row in dataTable.Rows select new SupplierValueObject(int.Parse(row["id"].ToString()), 
                row["name"].ToString(), row["addr"].ToString(), row["mail"].ToString(), row["phone"].ToString())).ToList().First();
        }

        public bool DeleteSupplier(int id)
        {
            return _supplierDataAccessLayer.DeleteSupplier(id);
        }
    }
}
