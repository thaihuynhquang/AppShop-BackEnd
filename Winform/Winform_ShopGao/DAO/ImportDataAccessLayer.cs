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

       public bool InsertImportBill(int idncc, int idsp, int sl, int dongia, int tong)
       {
           const string query =
               "INSERT INTO import (supplierId,productId, soluong, dongia, tong) VALUES (@name,@type,@pri,@des,@inew)";

           var sqlParameters = new MySqlParameter[5];
           sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.Int32) { Value =  idncc};
           sqlParameters[1] = new MySqlParameter("@type", MySqlDbType.Int32) { Value =  idsp};
           sqlParameters[2] = new MySqlParameter("@pri", MySqlDbType.Int32) { Value = sl};
           sqlParameters[3] = new MySqlParameter("@des", MySqlDbType.Int32) { Value =  dongia};
           sqlParameters[4] = new MySqlParameter("@inew", MySqlDbType.Int32) { Value = sl*dongia};

           return mySqlDbConnection.ExecuteInsertQuery(query, sqlParameters);
        }

       public DataTable GetAll()
       {
           const string query = "select * from import";
           return mySqlDbConnection.ExecuteSelectQuery(query);
        }
   }
}
