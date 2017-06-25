using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAO;
using ValueObject;

namespace BusinessLogicLayer
{
    
    public class ProductBusinessLogic
    {
        private readonly ProductDataAccessLayer _productDataAccessLayer;
        private readonly ImportDataAccessLayer importDataAccessLayer;

        public ProductBusinessLogic()
        {
            _productDataAccessLayer = new ProductDataAccessLayer();
            importDataAccessLayer= new ImportDataAccessLayer();
        }

        public List<ProductValueObject> GetAllProduct()
        {
            var data = _productDataAccessLayer.GetAllProduct();
             return (from DataRow row in data.Rows select new ProductValueObject(int.Parse(row["id"].ToString()), 
                 row["name"].ToString(), int.Parse(row["id_type"].ToString()),
                 int.Parse(row["price"].ToString()), row["description"].ToString(), int.Parse(row["new"].ToString()),
                 int.Parse(row["inCollection"].ToString()), int.Parse(row["currentTotal"].ToString()))).ToList();
     
        }

        public bool CreateNewProduct(ProductValueObject productValueObject)
        {
            return _productDataAccessLayer.CreateNewProduct(productValueObject.Name,productValueObject.IdType,productValueObject.Price,productValueObject.Description,productValueObject.Inew,productValueObject.Collection);
        }

        public ProductValueObject GetProductById(int? rowId)
        {
            var data = _productDataAccessLayer.GetProductById(rowId);
            return (from DataRow row in data.Rows
                select new ProductValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), int.Parse(row["id_type"].ToString()),
                    int.Parse(row["price"].ToString()), row["description"].ToString(), 
                    int.Parse(row["new"].ToString()), int.Parse(row["inCollection"].ToString()),
                    int.Parse(row["currentTotal"].ToString()))).First();
        }

        public bool UpdateProduct(ProductValueObject productValueObject)
        {
            return _productDataAccessLayer.UpdateProduct(productValueObject.Id, productValueObject.Name,
                productValueObject.IdType, productValueObject.Price, productValueObject.Description,
                productValueObject.Inew, productValueObject.Collection, productValueObject.Total);
        }

        public bool ImportProduct(int id, int idncc, int total, int dongia)
        {
            var product = GetProductById(id);
            if (product.Total == null || product.Total == 0)
            {
                product.Total = total;
            }
            else
            {
                product.Total += total;
            }
            using (var transactionScope = new TransactionScope())
            {
                UpdateProduct(product);
                importDataAccessLayer.InsertImportBill(idncc, id, total, dongia, total * dongia);

                transactionScope.Complete();
                return true;
            }
        }

        public List<ImportValueObject> GetAllImportValueObjects()
        {
            var data = importDataAccessLayer.GetAll();
            return (from DataRow row in data.Rows
                select new ImportValueObject(int.Parse(row[0].ToString()), int.Parse(row[1].ToString()),
                    int.Parse(row[2].ToString()),
                    int.Parse(row[3].ToString()), int.Parse(row[4].ToString()), int.Parse(row[5].ToString()))).ToList();
        }

    }
}
