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
    
    public class ProductBusinessLogic
    {
        private readonly ProductDataAccessLayer _productDataAccessLayer;

        public ProductBusinessLogic()
        {
            _productDataAccessLayer = new ProductDataAccessLayer();
        }

        public List<ProductValueObject> GetAllProduct()
        {
            var data = _productDataAccessLayer.GetAllProduct();
             return (from DataRow row in data.Rows select new ProductValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), int.Parse(row["id_type"].ToString()),
                 int.Parse(row["price"].ToString()), row["description"].ToString(), int.Parse(row["new"].ToString()), int.Parse(row["inCollection"].ToString()))).ToList();
     
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
                    int.Parse(row["price"].ToString()), row["description"].ToString(), int.Parse(row["new"].ToString()), int.Parse(row["inCollection"].ToString()))).First();
        }

        public bool UpdateProduct(ProductValueObject productValueObject)
        {
            return _productDataAccessLayer.UpdateProduct(productValueObject.Id, productValueObject.Name,
                productValueObject.IdType, productValueObject.Price, productValueObject.Description,
                productValueObject.Inew, productValueObject.Collection);
        }
    }
}
