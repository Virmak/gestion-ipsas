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
    public partial class GestionCours : Form
    {
        public GestionCours()
        {
            InitializeComponent();
            initDGV();
            loadCourses();

            foreach(var t in Teacher.GetTeachersList())
            {
                teachersCombo.Items.Add(t);
            }
        }

        private void initDGV()
        {
            courseDGV.AutoGenerateColumns = false;
            courseDGV.ColumnCount = 5;

            courseDGV.Columns[1].Width = 130;

            courseDGV.Columns[0].Name = "Identifiant";
            courseDGV.Columns[0].DataPropertyName = "Id";
            courseDGV.Columns[1].Name = "Cours";
            courseDGV.Columns[1].DataPropertyName = "Name";
            courseDGV.Columns[2].Name = "Nb. Heures";
            courseDGV.Columns[2].DataPropertyName = "NbHour";
            courseDGV.Columns[3].Name = "Classe";
            courseDGV.Columns[3].DataPropertyName = "Classe";
            courseDGV.Columns[4].Name = "Id. Enseignant";
            courseDGV.Columns[4].DataPropertyName = "TeacherId";
        }

        private void loadCourses()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Course.GetCoursesDataTable();
            courseDGV.DataSource = bindingSource;
        }

        private void resetControls()
        {
            idTxt.Text = "";
            nameTxt.Text = "";
            nbHours.Value = 0;
            classeTxt.Text = "";
            teachersCombo.SelectedIndex = -1;
        }

        private void new_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (idTxt.Text != "")
            {
                if (Course.DeleteCourse(int.Parse(idTxt.Text)))
                {
                    MessageBox.Show("Cours Supprimé");
                    resetControls();
                    loadCourses();
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "" && teachersCombo.SelectedIndex > -1 && Course.UpdateCourse(int.Parse(idTxt.Text), nameTxt.Text, 
                (int)nbHours.Value, classeTxt.Text, ((Teacher)teachersCombo.SelectedItem).Id))
            {
                loadCourses();
                MessageBox.Show("Cours Modifié");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "")
            {
                MessageBox.Show("Clicked sur Nouveau avant d'ajouter");
            }
            else if (teachersCombo.SelectedIndex > -1 
                && Course.CreateCourse(nameTxt.Text, (int)nbHours.Value, classeTxt.Text, ((Teacher)teachersCombo.SelectedItem).Id))
            {
                loadCourses();
                MessageBox.Show("Cours Ajouté");
            }
        }

        private void courseDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = courseDGV.SelectedCells[0].RowIndex;
            if (rowIndex < courseDGV.RowCount - 1)
            {
                DataGridViewRow selectedRow = courseDGV.Rows[rowIndex];
                idTxt.Text = selectedRow.Cells[0].Value.ToString();
                nameTxt.Text = selectedRow.Cells[1].Value.ToString();
                nbHours.Value = int.Parse(selectedRow.Cells[2].Value.ToString());
                classeTxt.Text = selectedRow.Cells[3].Value.ToString();
                teachersCombo.SelectedIndex = getTeacherIndex(int.Parse(selectedRow.Cells[4].Value.ToString()));


            }
        }

        private int getTeacherIndex(int teacherId)
        {
            for(var i = 0; i < teachersCombo.Items.Count; i++)
            {
                if (((Teacher)teachersCombo.Items[i]).Id == teacherId)
                {
                    return i;
                }

            }
            return -1;

        }
    }
}
