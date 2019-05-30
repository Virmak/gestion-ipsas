using Gestion_Ipsas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ipsas.Ui
{
    public partial class GestionEnseignant : Form
    {
        public GestionEnseignant()
        {
            InitializeComponent();
            initDgv();
            loadTeachers();
            
        }

        private void initDgv()
        {
            
            teachersDGV.AutoGenerateColumns = false;
            teachersDGV.ColumnCount = 6;

            teachersDGV.Columns[0].DataPropertyName = "Id";
            teachersDGV.Columns[0].Name = "Identifiant";
            teachersDGV.Columns[1].Name = "Prénom";
            teachersDGV.Columns[1].DataPropertyName = "FirstName";
            teachersDGV.Columns[2].Name = "Nom";
            teachersDGV.Columns[2].DataPropertyName = "LastName";
            teachersDGV.Columns[3].Name = "Date de naissance";
            teachersDGV.Columns[3].DataPropertyName = "BirthDate";
            teachersDGV.Columns[4].Name = "Mot de passe";
            teachersDGV.Columns[4].DataPropertyName = "Password";
            teachersDGV.Columns[5].Name = "Spécialité";
            teachersDGV.Columns[5].DataPropertyName = "Specialite";
        }

        private void loadTeachers()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Teacher.GetTeachersDataTable();
            teachersDGV.DataSource = bindingSource;
        }

        private void teachersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = teachersDGV.SelectedCells[0].RowIndex;
            if (rowIndex < teachersDGV.RowCount - 1)
            {
                DataGridViewRow selectedRow = teachersDGV.Rows[rowIndex];
                idTxt.Text = selectedRow.Cells[0].Value.ToString();
                fnameTxt.Text = selectedRow.Cells[1].Value.ToString();
                lnameTxt.Text = selectedRow.Cells[2].Value.ToString();
                naissanceDatePicker.Value = (DateTime)selectedRow.Cells[3].Value;
                passTxt.Text = selectedRow.Cells[4].Value.ToString();
                specialiteTxt.Text = selectedRow.Cells[5].Value.ToString().Replace(" ", "");
            }

        }

        private void resetControls()
        {
            idTxt.Text = "";
            fnameTxt.Text = "";
            lnameTxt.Text = "";
            naissanceDatePicker.Value = DateTime.Today;
            passTxt.Text = "";
            specialiteTxt.Text = "";
        }

        private void newTeacher_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "")
            {
                if (Teacher.DeleteTeacher(int.Parse(idTxt.Text)))
                {
                    MessageBox.Show("Enseignant Supprimé");
                    resetControls();
                    loadTeachers();
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {

            if (idTxt.Text != "" && Teacher.UpdateTeacher(int.Parse(idTxt.Text), fnameTxt.Text, lnameTxt.Text,
                naissanceDatePicker.Value, passTxt.Text, specialiteTxt.Text))
            {
                loadTeachers();
                MessageBox.Show("Enseignant Modifié");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "")
            {
                MessageBox.Show("Clicker sur Nouveau pour ajouter un Enseignant");
            }
            else if (fnameTxt.Text == "" || lnameTxt.Text == "" ||
                passTxt.Text == "" || specialiteTxt.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoire");
            }
            else if (Teacher.CreateTeacher(fnameTxt.Text, lnameTxt.Text,
                naissanceDatePicker.Value, passTxt.Text, specialiteTxt.Text))
            {
                loadTeachers();
                MessageBox.Show("Enseignant Ajouté");
                resetControls();
            }
        }
    }
}
