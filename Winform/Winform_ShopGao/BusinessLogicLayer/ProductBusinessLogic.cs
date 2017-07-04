using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                 int.Parse(row["price"].ToString()), row["description"].ToString(), int.Parse(row["new"].ToString()))).ToList();
     
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
                    productValueObject.Description, productValueObject.Inew);

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
                    int.Parse(row["new"].ToString()))).First();
        }

        public bool UpdateProduct(ProductValueObject productValueObject, ImageValueObject image = null)
        {
            if (image == null)
                return _productDataAccessLayer.UpdateProduct(productValueObject.Id, productValueObject.Name,
                    productValueObject.IdType, productValueObject.Price, productValueObject.Description,
                    productValueObject.Inew);

            var x  = imageDataAccessLayer.UpdateImage(image.idSp, image.link);
            if (!x )
            {
                throw new Exception("RRR");
            }
            return _productDataAccessLayer.UpdateProduct(productValueObject.Id, productValueObject.Name,
                productValueObject.IdType, productValueObject.Price, productValueObject.Description,
                productValueObject.Inew);
        }

        public bool ImportProduct(int id, int idncc, int total, int dongia)
        {
            var product = GetProductById(id);
            using (var transactionScope = new TransactionScope())
            {
               var isProductUpdate = UpdateProduct(product);
                var isImport = importDataAccessLayer.InsertImportBill(idncc, id, total, dongia);
                if (isImport && isProductUpdate)
                {
                    transactionScope.Complete();
                    return true;
                }
                transactionScope.Dispose();
                return false;
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

        public string GetImageFileName(int? id)
        {
            var data = imageDataAccessLayer.GetImageFileNameByProductId(id);
            var rows = data.Rows.Cast<DataRow>().ToArray();
            return rows.First().ItemArray.First().ToString();
        }
    }
}
