using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class SupplierDataAccessLayer
    {
        private MySqlDbConnection _mySqlDbConnection;

        public SupplierDataAccessLayer()
        {
            _mySqlDbConnection = new MySqlDbConnection();
        }

        public DataTable GetAllSupplier()
        {
            const string query = "select * from suppliers";
            return _mySqlDbConnection.ExecuteSelectQuery(query);
        }

        public bool CreateNewSupplier(string name, string addr, string mail, string phone)
        {
            const string query = "INSERT INTO suppliers (name, addr, mail,phone) VALUES(@name, @add, @mail, @phone)";
            var sqlParameters = new MySqlParameter[4];
            sqlParameters[0] = new MySqlParameter("@name", MySqlDbType.String) {Value = name};
            sqlParameters[1] = new MySqlParameter("@add", MySqlDbType.String) { Value = addr };
            sqlParameters[2] = new MySqlParameter("@mail", MySqlDbType.String) { Value = mail };
            sqlParameters[3] = new MySqlParameter("@phone", MySqlDbType.String) { Value = phone };
            return _mySqlDbConnection.ExecuteInsertQuery(query,sqlParameters);
        }
    }
}
