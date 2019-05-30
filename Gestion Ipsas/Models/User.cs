

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Ipsas.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User()
        {

        }

        public User(int Id, string FirstName, string LastName, DateTime BirthDate, string Password, string Role)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.Password = Password;
            this.Role = Role;
        }

        public static User GetUserById(int id)
        {
            User u = null;
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT Id, FirstName, LastName, BirthDate, Password, Role" +
                " FROM users WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                u = new User
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    BirthDate = reader.GetDateTime(3),
                    Password = reader.GetString(4),
                    Role = reader.GetString(5)
                };
            }
            reader.Close();
            return u;
        }

        public static DataTable GetUsersDataTableByRole(string role)
        {
            var dataTable = new DataTable();
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Users WHERE Role = @Role";
            cmd.Parameters.AddWithValue("@Role", role);
            var dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable GetUsersDataTable()
        {
            var dataTable = new DataTable();
            var db = DbConnection.GetInstance();
            var dataAdapter = new SqlDataAdapter("SELECT * FROM Users", db.connection);
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public static User Login(string identifiant, string password, string role)
        {
            var user = GetUserById(int.Parse(identifiant));
            if (user != null && user.Password == password && user.Role == role)
            {
                return user;
            }

            return null;
        }

        public static bool UpdateUser(int Id, string FirstName, string LastName, 
            DateTime BirthDate, string Password, string Role, string Niveau )
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, " +
                "BirthDate = @BirthDate, Password = @Password, Role = @Role, Niveau = @Niveau WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Role", Role);
            cmd.Parameters.AddWithValue("@Niveau", Niveau);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public static bool UpdateUser(int Id, string FirstName, string LastName,
            DateTime BirthDate, string Password, string Role)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, " +
                "BirthDate = @BirthDate, Password = @Password, Role = @Role WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Role", Role);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public static bool DeleteUser(int Id)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Users WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        public static bool CreateUser(string FirstName, string LastName,
            DateTime BirthDate, string Password, string Role, string Niveau)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Users VALUES (@FirstName, @LastName, " +
                "@BirthDate, @Password, @Role, @Niveau)";
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Role", Role);
            cmd.Parameters.AddWithValue("@Niveau", Niveau);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public static bool CreateUser(string FirstName, string LastName,
            DateTime BirthDate, string Password, string Role)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Users(FirstName, LastName, BirthDate, Password, Role, Niveau) " +
                "VALUES (@FirstName, @LastName, @BirthDate, @Password, @Role, '')";
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Role", Role);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
    }
}
