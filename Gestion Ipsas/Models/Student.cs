using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Ipsas.Models
{
    public class Student : User
    {
        public string Classe { get; set; }

        public Student(int Id, string FirstName, string LastName, DateTime BirthDate, string Password, string Classe)
            :base()
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.Password = Password;
            this.Classe = Classe;
        }

        public static Student GetStudentById(int id)
        {
            Student s = null;
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT Id, FirstName, LastName, BirthDate, Password, Classe" +
                " FROM Students WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s = new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4),
                    reader.GetString(5));
            }
            reader.Close();
            return s;
        }

        public static IList<Student> GetStudentsByClasse(string Classe)
        {
            IList<Student> students = new List<Student>();
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT Id, FirstName, LastName, BirthDate, Password, Classe" +
                " FROM Students WHERE Classe = @Classe";
            cmd.Parameters.AddWithValue("@Classe", Classe);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                students.Add(new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4),
                    reader.GetString(5)));
            }
            reader.Close();
            return students;
        }

        public static DataTable GetStudentsDataTableByRole()
        {
            var dataTable = new DataTable();
            var db = DbConnection.GetInstance();
            var cmd = db.connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Students";
            var dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static bool CreateStudent(string FirstName, string LastName,
            DateTime BirthDate, string Password, string Classe)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Students VALUES (@FirstName, @LastName, " +
                "@BirthDate, @Password, @Classe)";
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Classe", Classe);
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

        public static bool UpdateStudent(int Id, string FirstName, string LastName,
            DateTime BirthDate, string Password, string Classe)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, " +
                "BirthDate = @BirthDate, Password = @Password, Classe = @Classe WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Classe", Classe);
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

        public static bool DeleteStudent(int Id)
        {
            var cmd = DbConnection.GetInstance().connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Students WHERE Id = @Id";
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
            return this.FirstName + " " + this.LastName;
        }
    }
}
