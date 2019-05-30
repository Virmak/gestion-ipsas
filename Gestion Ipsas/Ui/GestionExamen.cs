using Gestion_Ipsas.Models;
using System;
using System.Windows.Forms;

namespace Gestion_Ipsas.Ui
{
    public partial class GestionExamen : Form
    {
        public GestionExamen()
        {
            InitializeComponent();
            initControls();
            resetControls();
            loadExamen();
        }

        private void loadExamen()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Examen.GetExamensDataTable();
            examenDgv.DataSource = bindingSource;
        }

        private void initControls()
        {
            var db = DbConnection.GetInstance();
            foreach(var course in Course.GetCoursesList())
            {
                courseCombo.Items.Add(course);
            }
            dateExamen.Format = DateTimePickerFormat.Custom;
            dateExamen.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void resetControls()
        {
            idTxt.Text = "";
            courseCombo.SelectedIndex = -1;
            dureeUpDown.Value = 0;
            dateExamen.Value = DateTime.Today;
            teacherTxt.Text = "";
        }             

        private void initDgv()
        {
            examenDgv.AutoGenerateColumns = false;
            examenDgv.ColumnCount = 4;

            examenDgv.Columns[0].DataPropertyName = "Id";
            examenDgv.Columns[0].Name = "Identifiant";
            examenDgv.Columns[1].Name = "Date";
            examenDgv.Columns[1].DataPropertyName = "Date";
            examenDgv.Columns[2].Name = "Durée";
            examenDgv.Columns[2].DataPropertyName = "Duree";
            examenDgv.Columns[3].Name = "Id. Cours";
            examenDgv.Columns[3].DataPropertyName = "CourseId";
            examenDgv.Columns[5].Width = 118;
        }

        private void courseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseCombo.SelectedIndex != -1)
            {
                Course c = (Course)courseCombo.SelectedItem;
                teacherTxt.Text = c.Teacher.FirstName + " " + c.Teacher.LastName;
            }
        }

        private void new_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "")
            {
                MessageBox.Show("Clicker sur Nouveau");
            }
            else if (courseCombo.SelectedIndex == -1 || dureeUpDown.Value <= 0)
            {
                MessageBox.Show("Tous les champs sont obligatoire");
            }
            else if (Examen.CreateExamen(dateExamen.Value, dureeUpDown.Value, ((Course)courseCombo.SelectedItem).Id))
            {
                loadExamen();
                MessageBox.Show("Examen Ajouté");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (idTxt.Text != "")
            {
                if (Examen.DeleteExamen(int.Parse(idTxt.Text)))
                {
                    MessageBox.Show("Examen Supprimé");
                    resetControls();
                    loadExamen();
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (idTxt.Text == "" || courseCombo.SelectedIndex == -1 || dureeUpDown.Value <= 0)
            {
                MessageBox.Show("Tous les champs sont obligatoire");
            }
            else if (Examen.UpdateExamen(int.Parse(idTxt.Text), dateExamen.Value, dureeUpDown.Value, ((Course)courseCombo.SelectedItem).Id))
            {
                loadExamen();
                MessageBox.Show("Examen Modifié");
            }
        }

        private void examenDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowIndex = examenDgv.SelectedCells[0].RowIndex;
            if (rowIndex < examenDgv.RowCount - 1)
            {
                DataGridViewRow selectedRow = examenDgv.Rows[rowIndex];
                idTxt.Text = selectedRow.Cells[0].Value.ToString();
                dateExamen.Value = (DateTime)selectedRow.Cells[1].Value;
                dureeUpDown.Value = decimal.Parse(selectedRow.Cells[2].Value.ToString());
                courseCombo.SelectedIndex = getCourseIndex(int.Parse(selectedRow.Cells[3].Value.ToString()));
            }
        }



        private int getCourseIndex(int courseId)
        {
            for (var i = 0; i < courseCombo.Items.Count; i++)
            {
                if (((Course)courseCombo.Items[i]).Id == courseId)
                {
                    return i;
                }

            }
            return -1;

        }
    }
}
