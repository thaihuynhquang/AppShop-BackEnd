using System.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class UserDataAccessLayer
    {
        private MySqlDbConnection _conn;

        public UserDataAccessLayer()
        {
            _conn = new MySqlDbConnection();
        }

        public bool Login(string user, string pass)
        {
            const string query = "select * from user_administrator where username = @user and password = @pass";
            var sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("@user", MySqlDbType.VarChar) {Value = user};
            sqlParameters[1] = new MySqlParameter("@pass", MySqlDbType.VarChar) { Value = pass };

            return _conn.ExecuteSelectQuery(query, sqlParameters).Rows.Count > 0;
        }

        public DataTable GetAllUser()
        {
            const string query = "select * from users";
            return _conn.ExecuteSelectQuery(query);
        }

    }
}
