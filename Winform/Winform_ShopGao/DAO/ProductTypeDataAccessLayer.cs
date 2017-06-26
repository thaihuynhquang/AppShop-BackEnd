using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class ProductTypeDataAccessLayer
    {
        private MySqlDbConnection _conn;

        public ProductTypeDataAccessLayer()
        {
            _conn =  MySqlDbConnection.GetConnection();
        }

        public DataTable GetAllProductType()
        {
            const string query = "select * from product_type";
            return _conn.ExecuteSelectQuery(query);
        }
    }
}
