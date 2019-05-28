using Gestion_Ipsas.Models;
using System;
using System.Windows.Forms;

namespace Gestion_Ipsas.Ui
{
    public partial class GestionUtilisateurs : Form
    {
        public GestionUtilisateurs()
        {
            InitializeComponent();
            initControls();
            loadUsers();
        }

        private void loadUsers()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = User.GetUsersDataTable();
            usersDgv.DataSource = bindingSource;
        }

        private void initControls()
        {
            roleCombo.SelectedIndex = 0;

            usersDgv.AutoGenerateColumns = false;
            usersDgv.ColumnCount = 6;

            usersDgv.Columns[0].DataPropertyName = "Id";
            usersDgv.Columns[0].Name = "Identifiant";
            usersDgv.Columns[1].Name = "Prénom";
            usersDgv.Columns[1].DataPropertyName = "FirstName";
            usersDgv.Columns[2].Name = "Nom";
            usersDgv.Columns[2].DataPropertyName = "LastName";
            usersDgv.Columns[3].Name = "Date de naissance";
            usersDgv.Columns[3].DataPropertyName = "BirthDate";
            usersDgv.Columns[4].Name = "Mot de passe";
            usersDgv.Columns[4].DataPropertyName = "Password";
            usersDgv.Columns[5].Name = "Role";
            usersDgv.Columns[5].DataPropertyName = "Role";

            usersDgv.Columns[0].Width = 80;
            usersDgv.Columns[3].Width = 120;
        }

        private void resetControls()
        {
            idTxt.Text = "";
            fNameTxt.Text = "";
            lNameTxt.Text = "";
            passwordTxt.Text = "";
            birthDate.Value = DateTime.Today;
            roleCombo.SelectedIndex = 0;
        }

        private void usersDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = usersDgv.SelectedCells[0].RowIndex;
            if (rowIndex < usersDgv.RowCount - 1)
            {
                DataGridViewRow selectedRow = usersDgv.Rows[rowIndex];
                idTxt.Text = selectedRow.Cells[0].Value.ToString();
                fNameTxt.Text = selectedRow.Cells[1].Value.ToString();
                lNameTxt.Text = selectedRow.Cells[2].Value.ToString();
                birthDate.Value = (DateTime)selectedRow.Cells[3].Value;
                passwordTxt.Text = selectedRow.Cells[4].Value.ToString();
                roleCombo.SelectedIndex = roleCombo.Items.IndexOf(selectedRow.Cells[5].Value.ToString());
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "")
            {
                if (User.DeleteUser(int.Parse(idTxt.Text)))
                {
                    MessageBox.Show("Utilisateur Supprimé");
                    resetControls();
                    loadUsers();
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

            if (User.UpdateUser(int.Parse(idTxt.Text), fNameTxt.Text, lNameTxt.Text,
                birthDate.Value, passwordTxt.Text, roleCombo.SelectedItem.ToString()))
            {
                loadUsers();
                MessageBox.Show("Utilisateur Modifié");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "")
            {
                MessageBox.Show("Clicker sur Nouveau pour ajouter un utilisateur");
            }
            else if (User.CreateUser(fNameTxt.Text, lNameTxt.Text, birthDate.Value,
                passwordTxt.Text, roleCombo.SelectedItem.ToString()))
            {
                loadUsers();
                MessageBox.Show("Utilisateur Ajouté");
                resetControls();
            }
        }
    }
}
