using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class ImageDataAccessLayer
    {
        private readonly MySqlDbConnection mySqlDbConnection;

        public ImageDataAccessLayer()
        {
            mySqlDbConnection =  MySqlDbConnection.GetConnection();
        }

        public bool CreateImage(string link, int? sp)
        {
            const string query = "insert into images(link,id_product) values (@link, @sp)";
            var sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("@link", MySqlDbType.VarChar) { Value = link };
            sqlParameters[1] = new MySqlParameter("@sp", MySqlDbType.Int32) { Value = sp };

            return mySqlDbConnection.ExecuteInsertQuery(query, sqlParameters);
        }
    }
}
