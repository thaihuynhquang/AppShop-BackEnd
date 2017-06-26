using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAO;
using ValueObject;
using Winform_ShopGao;

namespace BusinessLogicLayer
{
    
    public class ProductBusinessLogic
    {
        private readonly ProductDataAccessLayer _productDataAccessLayer;
        private readonly ImportDataAccessLayer importDataAccessLayer;
        private readonly ImageDataAccessLayer imageDataAccessLayer;

        public ProductBusinessLogic()
        {
            _productDataAccessLayer = new ProductDataAccessLayer();
            importDataAccessLayer= new ImportDataAccessLayer();
            imageDataAccessLayer = new ImageDataAccessLayer();
        }

        public List<ProductValueObject> GetAllProduct()
        {
            var data = _productDataAccessLayer.GetAllProduct();
             return (from DataRow row in data.Rows select new ProductValueObject(int.Parse(row["id"].ToString()), 
                 row["name"].ToString(), int.Parse(row["id_type"].ToString()),
                 int.Parse(row["price"].ToString()), row["description"].ToString(), int.Parse(row["new"].ToString()),
                 int.Parse(row["inCollection"].ToString()), int.Parse(row["currentTotal"].ToString()))).ToList();
     
        }

        public bool CreateNewProduct(ProductValueObject productValueObject, ImageValueObject image)
        {
            try
            {
                var listProduct = GetAllProduct();
                if (listProduct.Any(x => x.IdType == productValueObject.IdType && x.Name == productValueObject.Name))
                {
                    return false;
                }
                _productDataAccessLayer.CreateNewProduct(productValueObject.Name, productValueObject.IdType, productValueObject.Price,
                    productValueObject.Description, productValueObject.Inew, productValueObject.Collection);

                listProduct = GetAllProduct();
                var insertedProduct =
                    listProduct.First(x => x.IdType == productValueObject.IdType && x.Name == productValueObject.Name);
                image.idSp = insertedProduct.Id;

                imageDataAccessLayer.CreateImage(image.link, image.idSp);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

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

        public bool UpdateProduct(ProductValueObject productValueObject, ImageValueObject image = null)
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
