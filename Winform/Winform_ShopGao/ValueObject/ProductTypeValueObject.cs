using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class ProductTypeValueObject
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string image { get; set; }

        public ProductTypeValueObject(int? id, string name, string img)
        {
            this.id = id;
            this.name = name;
            this.image = img;
        }
    }
}
