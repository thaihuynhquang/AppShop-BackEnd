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
   public class ProductTypeBusinessLogic
   {
       private ProductTypeDataAccessLayer _productTypeDataAccessLayer;

       public ProductTypeBusinessLogic()
       {
           _productTypeDataAccessLayer = new ProductTypeDataAccessLayer();
       }

       public List<ProductTypeValueObject> GetAllProductType()
       {
           var data = _productTypeDataAccessLayer.GetAllProductType();
           return (from DataRow row in data.Rows
               select new ProductTypeValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(),
                   row["image"].ToString())).ToList();
       }
   }
}
