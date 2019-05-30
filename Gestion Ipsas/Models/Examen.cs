using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Ipsas.Models
{
    class Examen
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Duree { get; set; }
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }



        public static DataTable GetExamensDataTable()
        {
            var dataTable = new DataTable();
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Examens";
            var dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        internal static bool CreateExamen(DateTime Date, decimal Duree, int CourseId)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Examens VALUES (@Date, @Duree, @CourseId)";
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Duree", Duree);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
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

        internal static bool UpdateExamen(int Id, DateTime Date, decimal Duree, int CourseId)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "UPDATE Examens SET Date = @Date, Duree = @Duree, CourseId = @CourseId WHERE Id = @Id ";
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Duree", Duree);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
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

        internal static bool DeleteExamen(int Id)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Examens WHERE Id = @Id ";
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
