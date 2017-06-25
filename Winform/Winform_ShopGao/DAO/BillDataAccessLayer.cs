using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class BillDataAccessLayer
    {
        private MySqlDbConnection _mySqlDbConnection;

        public BillDataAccessLayer()
        {
            _mySqlDbConnection = new MySqlDbConnection();
        }

        public DataTable GetAllBill()
        {
            const string query = "select * from bill";
            return _mySqlDbConnection.ExecuteSelectQuery(query);
        }

        public bool CreateNewBill(int idCus, DateTime order, int total, string addr, string nt, int stt)
        {
            const string query = "INSERT INTO bill (id_customer, date_order, total, address, note, status) VALUES (@cus, @order, @total, @addr, @nt, @stt)";
            var sqlParameters = new MySqlParameter[6];
            sqlParameters[0] = new MySqlParameter("@cus", MySqlDbType.Int32) { Value = idCus };
            sqlParameters[1] = new MySqlParameter("@order", MySqlDbType.DateTime) { Value = order };
            sqlParameters[2] = new MySqlParameter("@total", MySqlDbType.String) { Value = total };
            sqlParameters[3] = new MySqlParameter("@addr", MySqlDbType.String) { Value = addr };
            sqlParameters[4] = new MySqlParameter("@nt", MySqlDbType.Text) { Value = nt };
            sqlParameters[5] = new MySqlParameter("@stt", MySqlDbType.Int32) { Value = stt };
            return _mySqlDbConnection.ExecuteInsertQuery(query, sqlParameters);
        }
    }
}
