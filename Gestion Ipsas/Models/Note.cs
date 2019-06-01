using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Ipsas.Models
{
    class Note
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public decimal NoteVal { get; set; }

        public static bool CreateNote(int CourseId, int StudentId, decimal NoteVal) 
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Notes(StudentId, CourseId, Note) VALUES (@StudentId, @CourseId, @NoteVal)";
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@NoteVal", NoteVal);
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

        public static bool UpdateNote(int Id, int CourseId, int StudentId, decimal NoteVal)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "UPDATE Notes SET StudentId = @StudentId, CourseId = @CourseId, Note = @Note WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            cmd.Parameters.AddWithValue("@NoteVal", NoteVal);
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

        public static DataTable GetDataTable()
        {
            var dataTable = new DataTable();
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT n.Id AS NoteId, CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, c.Name AS CourseName, n.Note FROM Notes n " +
                "INNER JOIN Students s ON s.Id = StudentId " +
                "INNER JOIN Courses c ON c.Id = CourseId";
            var dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable GetDataTable(string Classe)
        {
            var dataTable = new DataTable();
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT n.Id AS NoteId, n.Note, CONCAT(s.FirstName, ' ', s.LastName) as StudentName FROM Notes n " +
                "INNER JOIN Students s ON s.Id = StudentId " +
                "WHERE s.Classe = @Classe";
            cmd.Parameters.AddWithValue("@Classe", Classe);
            var dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable GetDataTable(string Classe, int CourseId)
        {
            var dataTable = new DataTable();
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT n.Id AS NoteId, n.Note, CONCAT(s.FirstName, ' ', s.LastName) as StudentName FROM Notes n " +
                "INNER JOIN Students s ON s.Id = StudentId " +
                "WHERE s.Classe = @Classe AND CourseId = @CourseId";
            cmd.Parameters.AddWithValue("@Classe", Classe);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
            var dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        internal static bool Delete(int Id)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Notes WHERE Id = @Id ";
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
    }
}
