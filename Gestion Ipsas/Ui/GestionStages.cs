using Gestion_Ipsas.Models;
using System;
using System.Windows.Forms;

namespace Gestion_Ipsas.Ui
{
    public partial class GestionStages : Form
    {
        public GestionStages()
        {
            InitializeComponent();
            initControls();

            loadStages();
        }

        private void loadStages()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Stage.GetDataTable();
            stagesDGV.DataSource = bindingSource;
        }

        private void initControls()
        {
            foreach (var c in Course.GetClasses())
            {
                classeCombo.Items.Add(c);
            }
        }

        private void resetControls()
        {
            idTxt.Text = "";
            entrepriseTxt.Text = "";
            dateDebut.Value = DateTime.Today;
            dateFin.Value = DateTime.Today;
            studentsCombo.Items.Clear();

        }

        private void loadStudents()
        {
            studentsCombo.Items.Clear();
            foreach (var student in Student.GetStudentsByClasse(classeCombo.SelectedItem.ToString()))
            {
                studentsCombo.Items.Add(student);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void classeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classeCombo.SelectedIndex > -1)
            {
                loadStudents();
            }
        }

        private void stagesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = stagesDGV.SelectedCells[0].RowIndex;
            if (rowIndex < stagesDGV.RowCount - 1)
            {
                DataGridViewRow selectedRow = stagesDGV.Rows[rowIndex];

                idTxt.Text = selectedRow.Cells[0].Value.ToString();
                entrepriseTxt.Text = selectedRow.Cells[1].Value.ToString();
                dateDebut.Value = (DateTime)selectedRow.Cells[2].Value;
                dateFin.Value = (DateTime)selectedRow.Cells[3].Value;
                if (selectedRow.Cells[4].Value.ToString() != "")
                {
                    selectStudentClasse((int)selectedRow.Cells[4].Value, Student.GetStudentById((int)selectedRow.Cells[4].Value).Classe.Trim());
                }
                else
                {
                    studentsCombo.SelectedIndex = -1;
                    studentsCombo.Text = "";
                }

            }
        }

        private void selectStudentClasse(int studentId, string classe)
        {
            
            for(var i = 0; i < classeCombo.Items.Count; i++)
            {
                if (classeCombo.Items[i].ToString() == classe)
                {
                    classeCombo.SelectedIndex = i;
                    loadStudents();
                    break;
                }
            }
            for (var i = 0; i < studentsCombo.Items.Count; i++)
            {
                if (((Student)studentsCombo.Items[i]).Id == studentId)
                {
                    studentsCombo.SelectedIndex = i;
                    loadStudents();
                    break;
                }
            }

            //studentsCombo.SelectedIndex = -1;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "")
            {
                if (Stage.DeleteStage(int.Parse(idTxt.Text)))
                {
                    MessageBox.Show("Stage supprimé");
                    loadStages();
                    resetControls();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (idTxt.Text == "")
            {
                MessageBox.Show("Il faut sélectionner un stage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (entrepriseTxt.Text == "")
            {
                MessageBox.Show("Il faut donner l'entreprise", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dateDebut.Value >= dateFin.Value)
            {
                MessageBox.Show("Il faut donner deux dates différentes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool res;
                if (studentsCombo.SelectedIndex > -1)
                {
                    res = Stage.UpdateStage(int.Parse(idTxt.Text), entrepriseTxt.Text, dateDebut.Value, dateFin.Value,
                        ((Student)studentsCombo.SelectedItem).Id);
                }
                else {
                    res = Stage.UpdateStage(int.Parse(idTxt.Text), entrepriseTxt.Text, dateDebut.Value, dateFin.Value);
                }

                if (res)
                {
                    loadStages();
                    MessageBox.Show("Stage Modifié");
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (idTxt.Text != "")
            {
                MessageBox.Show("Il faut clicker sur Nouveau", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (entrepriseTxt.Text == "")
            {
                MessageBox.Show("Il faut donner l'entreprise", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dateDebut.Value >= dateFin.Value)
            {
                MessageBox.Show("Il faut donner deux dates différentes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool res;
                if (studentsCombo.SelectedIndex > -1)
                {
                    res = Stage.CreateStage(entrepriseTxt.Text, dateDebut.Value, dateFin.Value,
                        ((Student)studentsCombo.SelectedItem).Id);
                }
                else
                {
                    res = Stage.CreateStage(entrepriseTxt.Text, dateDebut.Value, dateFin.Value);
                }

                if (res)
                {
                    loadStages();
                    resetControls();
                    MessageBox.Show("Stage Ajouté");
                }
            }
        }
    }
}
