using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class ProductValueObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public int IdType { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Inew { get; set; }
        public int Collection { get; set; }
        public int? Total { get; set; }

        public ProductValueObject(int? id, string name, int idType, int price, string desc, int inew, int icollection, int? total)
        {
            this.Id = id;
            this.Name = name;
            this.IdType = idType;
            this.Price = price;
            this.Description = desc;
            this.Inew = inew;
            this.Collection = icollection;
            this.Total = total;
        }
    }
}
