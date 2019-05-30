using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Ipsas.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NbHours { get; set; }
        public Teacher Teacher { get; set; }

        public static DataTable GetCoursesDataTable()
        {
            var dataTable = new DataTable();
            var db = DbConnection.GetInstance();
            var dataAdapter = new SqlDataAdapter("SELECT * FROM Courses", db.connection);
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public static IList<Course> GetCoursesList()
        {
            var list = new List<Course>(); 
            SqlCommand cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "SELECT c.*, t.Id as TeacherId, t.* FROM Courses c INNER JOIN Teachers t ON c.TeacherId = t.Id";
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                var c = new Course();
                c.Id = reader.GetInt32(0);
                c.Name = reader.GetString(1);
                c.NbHours = reader.GetInt32(2);
                c.Teacher = new Teacher
                {
                    Id = (int)reader["TeacherId"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    BirthDate = (DateTime)reader["BirthDate"],
                    Password = (string)reader["Password"],
                    Role = "Enseignant"
                };

                list.Add(c);
            }

            reader.Close();
            return list;
        }

        public static bool DeleteCourse(int Id)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Users WHERE Id = @Id";
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

        public static bool CreateCourse(string Name, int NbHour, int TeacherId)
        {

            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Courses VALUES (@Name, @NbHour, @TeacherId)";
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@NbHour", NbHour);
            cmd.Parameters.AddWithValue("@TeacherId", TeacherId);
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

        public static bool UpdateCourse(int Id, string Name, int NbHour, int TeacherId)
        {

            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "UPDATE Users SET Name = @Name, NbHour = @NbHour, TeacherId = @TeacherId";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@NbHour", NbHour);
            cmd.Parameters.AddWithValue("@TeacherId", TeacherId);
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
            return Name;
        }
    }
}
