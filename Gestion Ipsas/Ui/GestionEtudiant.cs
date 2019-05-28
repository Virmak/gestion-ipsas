using Gestion_Ipsas.Models;
using System;

using System.Windows.Forms;

namespace Gestion_Ipsas.Ui
{
    public partial class GestionEtudiant : Form
    {
        public GestionEtudiant()
        {
            InitializeComponent();
            initDataGridView();
            loadStudents();
        }

        private void initDataGridView()
        {
            studentsDataGridView.AutoGenerateColumns = false;
            studentsDataGridView.ColumnCount = 6;

            studentsDataGridView.Columns[0].DataPropertyName = "Id";
            studentsDataGridView.Columns[0].Name = "Identifiant";
            studentsDataGridView.Columns[1].Name = "Prénom";
            studentsDataGridView.Columns[1].DataPropertyName = "FirstName";
            studentsDataGridView.Columns[2].Name = "Nom";
            studentsDataGridView.Columns[2].DataPropertyName = "LastName";
            studentsDataGridView.Columns[3].Name = "Date de naissance";
            studentsDataGridView.Columns[3].DataPropertyName = "BirthDate";
            studentsDataGridView.Columns[4].Name = "Mot de passe";
            studentsDataGridView.Columns[4].DataPropertyName = "Password";
            studentsDataGridView.Columns[5].Name = "Classe";
            studentsDataGridView.Columns[5].DataPropertyName = "Niveau";
            studentsDataGridView.Columns[5].Width = 118;
        }

        private void loadStudents()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = User.GetUsersDataTableByRole("Etudiant");
            studentsDataGridView.DataSource = bindingSource;
        }

        private void new_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void studentsDataGridView_Click(object sender, EventArgs e)
        {
            int rowIndex = studentsDataGridView.SelectedCells[0].RowIndex;
            if (rowIndex < studentsDataGridView.RowCount - 1)
            {
                DataGridViewRow selectedRow = studentsDataGridView.Rows[rowIndex];
                idTxt.Text = selectedRow.Cells[0].Value.ToString();
                fNameTxt.Text = selectedRow.Cells[1].Value.ToString();
                lNameTxt.Text = selectedRow.Cells[2].Value.ToString();
                birthDate.Value = (DateTime)selectedRow.Cells[3].Value;
                passwordTxt.Text = selectedRow.Cells[4].Value.ToString();
                classeTxt.Text = selectedRow.Cells[5].Value.ToString().Replace(" ", "");
                niveauTxt.Text = selectedRow.Cells[5].Value.ToString().Replace(" ", "");
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "")
            {
                MessageBox.Show("Clicker sur Nouveau pour ajouter un étudiant");
            }
            else if (User.CreateUser(fNameTxt.Text, lNameTxt.Text, birthDate.Value, 
                passwordTxt.Text, "Etudiant", niveauTxt.Text))
            {
                loadStudents();
                MessageBox.Show("Etudiant Ajouté");
                resetControls();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (User.UpdateUser(int.Parse(idTxt.Text), fNameTxt.Text, lNameTxt.Text,
                birthDate.Value, passwordTxt.Text, "Etudiant", niveauTxt.Text))
            {
                loadStudents();
                MessageBox.Show("Etudiant Modifié");
            }
        }

        private void resetControls()
        {
            idTxt.Text = "";
            fNameTxt.Text = "";
            lNameTxt.Text = "";
            passwordTxt.Text = "";
            birthDate.Value = DateTime.Today;
            classeTxt.Text = "";
            niveauTxt.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "")
            {
                if (User.DeleteUser(int.Parse(idTxt.Text)))
                {
                    MessageBox.Show("Etudiant Supprimé");
                    resetControls();
                    loadStudents();
                }
            }
        }
    }
}
