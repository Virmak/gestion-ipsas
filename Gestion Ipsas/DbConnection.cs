
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Ipsas
{
    class DbConnection
    {
        public SqlConnection connection;


        private static DbConnection _instance;

        private DbConnection(string server, string database, string uid, string password)
        {
            //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\IPSAS_DB.mdf';Integrated Security = True; Connect Timeout = 30";

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\USERS\\VIRMAK\\SOURCE\\REPOS\\GESTION IPSAS\\GESTION IPSAS\\IPSAS_DB.MDF';Integrated Security = True; Connect Timeout = 30";

            connection = new SqlConnection(connectionString);
            this.OpenConnection();
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
            } catch(SqlException e)
            {
                MessageBox.Show("Cannot connect to sql server. Message : " + e.Message);
                return false;
            }
            return true;
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static DbConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DbConnection("localhost", "ipsas", "root", "");
            }
            return _instance;
        }
    }
}
