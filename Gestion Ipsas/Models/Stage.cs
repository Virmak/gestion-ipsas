using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Ipsas.Models
{
    class Stage
    {
        public int Id { get; set; }
        public string Entreprise { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Student Student { get; set; }


        public static DataTable GetDataTable()
        {
            var dt = new DataTable();
            SqlCommand cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "SELECT a.*, CONCAT(b.FirstName, ' ', b.LastName) AS StudentName FROM Stages a LEFT JOIN Students b ON a.StudentId = b.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public static bool CreateStage(string Entreprise, DateTime StartDate, DateTime EndDate)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Stages(Entreprise, StartDate, EndDate) VALUES (@Entreprise, @StartDate, @EndDate)";
            cmd.Parameters.AddWithValue("@Entreprise", Entreprise);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
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
        
        public static bool CreateStage(string Entreprise, DateTime StartDate, DateTime EndDate, int StudentId)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Stages(Entreprise, StartDate, EndDate, StudentId) VALUES (@Entreprise, @StartDate, @EndDate, @StudentId)";
            cmd.Parameters.AddWithValue("@Entreprise", Entreprise);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
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

        public static bool UpdateStage(int Id, string Entreprise, DateTime StartDate, DateTime EndDate)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "UPDATE Stages SET Entreprise = @Entreprise, StartDate = @StartDate," +
                " EndDate = @EndDate, StudentId = NULL WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Entreprise", Entreprise);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
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

        public static bool UpdateStage(int Id, string Entreprise, DateTime StartDate, DateTime EndDate, int StudentId)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "UPDATE Stages SET Entreprise = @Entreprise, StartDate = @StartDate," +
                " EndDate = @EndDate, StudentId = @StudentId WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Entreprise", Entreprise);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
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


        public static bool DeleteStage(int Id)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Stages WHERE Id = @Id ";
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
