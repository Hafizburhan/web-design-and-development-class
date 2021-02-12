using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pureCRUD
{
    class dataBase
    {

        private MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=credentials;");

        // opening connection with database
        public void openConnection()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        // closing connection with database
        public void closeConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }

        // returning connection
        public MySqlConnection getConnection()
        {
            return connect;
        }
    }
}
