using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAO
{
   public class ProductDataAccessLayer
    {
        private MySqlDbConnection _mySqlDbConnection;

        public ProductDataAccessLayer()
        {
            _mySqlDbConnection = MySqlDbConnection.GetConnection();
        }

        public DataTable GetAllProduct()
        {
            const string query = "select * from product";
            return _mySqlDbConnection.ExecuteSelectQuery(query);
        }


        public bool CreateNewProduct(string name, int idType, int price, string description, int inew, int collection)
        {
            const string query =
                "INSERT INTO product (name, id_type,price, description, new, inCollection) VALUES (@name,@type,@pri,@des,@inew,@col)";
            
            var sqlParameters = new MySqlParameter[6];
            sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.String) { Value = name };
            sqlParameters[1] = new MySqlParameter("@type", MySqlDbType.Int32) { Value = idType };
            sqlParameters[2] = new MySqlParameter("@pri", MySqlDbType.Int32) { Value = price };
            sqlParameters[3] = new MySqlParameter("@des", MySqlDbType.Text) { Value = description };
            sqlParameters[4] = new MySqlParameter("@inew", MySqlDbType.Int32) { Value = inew };
            sqlParameters[5] = new MySqlParameter("@col", MySqlDbType.Int32) { Value = collection };
            return _mySqlDbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

        public DataTable GetProductById(int? rowId)
        {
            const string query = "select * from product where id = @id limit 1";
            var sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = rowId };
            return _mySqlDbConnection.ExecuteSelectQuery(query, sqlParameters);
        }

        public bool UpdateProduct(int? id, string name, int idType, int price, string description, int inew, int collection, int? total)
        {
            const string query = "UPDATE product SET name=@name, id_type=@ty, price=@pr, " +
                                 "description=@des, new=@n, inCollection=@co, currentTotal = @currentTotal WHERE id=@id";
            
            var sqlParameters = new MySqlParameter[8];
            sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.String) { Value = name };
            sqlParameters[1] = new MySqlParameter("@ty", MySqlDbType.Int32) { Value = idType };
            sqlParameters[2] = new MySqlParameter("@pr", MySqlDbType.Float) { Value = price };
            sqlParameters[3] = new MySqlParameter("@des", MySqlDbType.Text) { Value = description };
            sqlParameters[4] = new MySqlParameter("@n", MySqlDbType.Int32) { Value = inew };
            sqlParameters[5] = new MySqlParameter("@co", MySqlDbType.Int32) { Value = collection };
            sqlParameters[6] = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };
            sqlParameters[7] = new MySqlParameter("@currentTotal", MySqlDbType.Int32) { Value = total };
            return _mySqlDbConnection.ExecuteUpdateQuery(query, sqlParameters);
        }
    }
}
