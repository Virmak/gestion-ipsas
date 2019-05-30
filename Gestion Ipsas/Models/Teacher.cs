using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Ipsas.Models
{
    public class Teacher : User
    {

        public string Specialite { get; set; }

        public static Teacher GetTeacherById(int Id)
        {
            Teacher t = null;
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT Id, FirstName, LastName, BirthDate, Password, Specialite" +
                " FROM Teachers WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                t = new Teacher
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    BirthDate = reader.GetDateTime(3),
                    Password = reader.GetString(4),
                    Specialite = reader.GetString(5)
                };
            }
            reader.Close();
            return t;
        }

        public static DataTable GetTeachersDataTable()
        {
            var dataTable = new DataTable();
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Teachers";
            var dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static IList<Teacher> GetTeachersList()
        {
            var list = new List<Teacher>();
            SqlCommand cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Teachers";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var t = new Teacher
                {
                    Id = (int)reader["Id"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    BirthDate = (DateTime)reader["BirthDate"],
                    Password = (string)reader["Password"],
                    Specialite = (string)reader["Specialite"],
                };

                list.Add(t);
            }

            reader.Close();
            return list;
        }

        public static bool CreateTeacher(string FirstName, string LastName,
            DateTime BirthDate, string Password, string Specialite)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Teachers VALUES (@FirstName, @LastName, " +
                "@BirthDate, @Password, @Specialite)";
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Specialite", Specialite);
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

        public static bool UpdateTeacher(int Id, string FirstName, string LastName,
            DateTime BirthDate, string Password, string Specialite)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "UPDATE Teachers SET FirstName = @FirstName, LastName = @LastName, " +
                "BirthDate = @BirthDate, Password = @Password, Specialite = @Specialite WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Specialite", Specialite);
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

        public static bool DeleteTeacher(int Id)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Teachers WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);

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

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
