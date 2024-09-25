using MySql.Data.MySqlClient;

namespace Hospital_Management_System.Utils
{
    class DatabaseConnection
    {
        private MySqlConnection conn;
        public MySqlConnection connection
        {
            get
            {
                return conn;
            }
        }

        public DatabaseConnection(string hostname, string database, string username, string password)
        {
            string connStr = "SERVER=" + hostname;
            connStr += ";DATABASE=" + database;
            connStr += ";UID=" + username;
            connStr += ";PASSWORD=" + password + ";";
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        public MySqlDataReader executeQuery(string queryStr)
        {
            MySqlCommand command = new MySqlCommand(queryStr, conn);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public int insertQuery(string queryStr)
        {
            MySqlCommand command = new MySqlCommand(queryStr, conn);
            MySqlDataReader reader = command.ExecuteReader();
            int id = (int) command.ExecuteScalar();
            return id;
        }

    }
}
