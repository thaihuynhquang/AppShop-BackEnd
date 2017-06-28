using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ValueObject;

namespace DAO
{
   public class ImportDataAccessLayer
   {
       private MySqlDbConnection mySqlDbConnection;

       public ImportDataAccessLayer()
       {
            mySqlDbConnection = MySqlDbConnection.GetConnection();
       }

       public bool InsertImportBill(int idncc, int idsp, int sl, int dongia)
       {
           const string query =
               "INSERT INTO import (supplierId, productId, unitPrice, unitInStock, totalPrice) VALUES (@supplierId, @productId, @unitPrice, @unitInStock, @totalPrice)";

           var sqlParameters = new MySqlParameter[5];
           sqlParameters[0] = new MySqlParameter("@supplierId", MySqlDbType.Int32) { Value =  idncc};
           sqlParameters[1] = new MySqlParameter("@productId", MySqlDbType.Int32) { Value =  idsp};
           sqlParameters[2] = new MySqlParameter("@unitInStock", MySqlDbType.Int32) { Value = sl};
           sqlParameters[3] = new MySqlParameter("@unitPrice", MySqlDbType.Int32) { Value =  dongia};
           sqlParameters[4] = new MySqlParameter("@totalPrice", MySqlDbType.Int32) { Value = sl*dongia};

           return mySqlDbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

       public DataTable GetAll()
       {
           const string query = "select * from import";
           return mySqlDbConnection.ExecuteSelectQuery(query);
        }
   }
}
