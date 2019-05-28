using System;
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
    }
}
