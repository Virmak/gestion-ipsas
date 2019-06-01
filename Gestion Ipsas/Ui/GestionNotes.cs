using Gestion_Ipsas.Models;
using System;
using System.Windows.Forms;

namespace Gestion_Ipsas.Ui
{
    public partial class GestionNotes : Form
    {
        public GestionNotes()
        {
            InitializeComponent();
            initControls();
            //loadNotes();
        }

        private void initControls()
        {

            notesDGV.AutoGenerateColumns = false;
            notesDGV.ColumnCount = 3;

            notesDGV.Columns[1].Width = 330;

            notesDGV.Columns[0].DataPropertyName = "NoteId";
            notesDGV.Columns[0].Name = "Id.";
            notesDGV.Columns[1].DataPropertyName = "StudentName";
            notesDGV.Columns[1].Name = "Etudiant";
            notesDGV.Columns[2].DataPropertyName = "Note";
            notesDGV.Columns[2].Name = "Note";

            foreach (var c in Course.GetClasses())
            {
                classeCombo.Items.Add(c);
            }
        }

        private void resetControls()
        {
            classeCombo.SelectedIndex = -1;
            courseCombo.SelectedIndex = -1;
            courseCombo.Items.Clear();
            noteUpDown.Value = 0;
        }

        private void loadNotes()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Note.GetDataTable();
            notesDGV.DataSource = bindingSource;
        }

        private void loadNotes(string Classe, int CourseId = -1)
        {
            BindingSource bindingSource = new BindingSource();
            if (CourseId == -2) { }
            else if (CourseId != -1)
            {
                bindingSource.DataSource = Note.GetDataTable(Classe, CourseId);
            }
            else
            {
                bindingSource.DataSource = Note.GetDataTable(Classe);
            }
            notesDGV.DataSource = bindingSource;
        }

        private void classeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classeCombo.SelectedIndex > -1)
            {
                studentsListBox.Items.Clear();
                courseCombo.Items.Clear();
                courseCombo.SelectedIndex = -1;
                courseCombo.Text = "";
                noteUpDown.Value = 0;
                searchStudTxt.Text = "";

                loadNotes(classeCombo.SelectedItem.ToString(), -2);
                

                foreach (var c in Course.GetCoursesByClasse(classeCombo.SelectedItem.ToString()))
                {
                    courseCombo.Items.Add(c);
                }
                foreach (var s in Student.GetStudentsByClasse(classeCombo.SelectedItem.ToString()))
                {
                    studentsListBox.Items.Add(s);
                }
            }
        }

        private void new_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (classeCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Il faut sélectionner la classe");
            }
            else if (courseCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Il faut sélctionner le cours");
            }
            else if (studentsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Il faut sélectionner l'étudiant");
            }
            else if (noteUpDown.Value == 0)
            {
                if (MessageBox.Show("Confirmation", "La note est 0, êtes-vous sûr de vouloir continuer ?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                
            }

            if (Note.CreateNote(((Course)courseCombo.SelectedItem).Id, ((Student)studentsListBox.SelectedItem).Id, noteUpDown.Value))
            {
                loadNotes(classeCombo.SelectedItem.ToString(), ((Course)courseCombo.SelectedItem).Id);
                MessageBox.Show("Note Ajouté");
                resetControls();
            }
        }

        private void studentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentsListBox.SelectedItem == null)
            {
                return;
            }
            string studentName = studentsListBox.SelectedItem.ToString().TrimEnd();

            foreach (DataGridViewCell c in this.notesDGV.SelectedCells)
            {
                c.Selected = false;
            }
            Console.WriteLine(studentsListBox.SelectedIndex);
            for (var i = 0; i < notesDGV.Rows.Count; i++)
            {
                if (notesDGV.Rows[i].Cells[1].Value != null && notesDGV.Rows[i].Cells[1].Value.ToString().Contains(studentName))
                {
                    notesDGV.Rows[i].Selected = true;
                    break;
                }
            }

            handleCellClick(false);
        }

        private void courseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classeCombo.SelectedIndex > -1)
            {
                noteUpDown.Value = 0;
                loadNotes(classeCombo.SelectedItem.ToString(), ((Course)courseCombo.SelectedItem).Id);
            }
        }

        private void searchStudTxt_TextChanged(object sender, EventArgs e)
        {
            var searchString = searchStudTxt.Text.ToLower();
            if (searchString == "")
            {

            }
            studentsListBox.SelectedItems.Clear();
            noteUpDown.Value = 0;
            for(var i = 0; i < studentsListBox.Items.Count; i++)
            {
                Student student = (Student)studentsListBox.Items[i];
                if (student.FirstName.ToLower().Contains(searchString) || student.LastName.ToLower().Contains(searchString))
                {
                    studentsListBox.SetSelected(i, true);
                    return;
                }
            }
            studentsListBox.SelectedIndex = -1;
            studentsListBox.SelectedItems.Clear();
        }

        private void notesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            handleCellClick();
        }

        private void handleCellClick(bool setSelection = true)
        {
            if (notesDGV.SelectedCells.Count == 0)
            {
                return;
            }
            int rowIndex = notesDGV.SelectedCells[0].RowIndex;
            if (rowIndex < notesDGV.RowCount - 1)
            {
                DataGridViewRow selectedRow = notesDGV.Rows[rowIndex];
                idTxt.Text = selectedRow.Cells[0].Value.ToString();
                noteUpDown.Value = (decimal)selectedRow.Cells[2].Value;

                if (!setSelection)
                {
                    return;
                }

                for (var i = 0; i < studentsListBox.Items.Count; i++)
                {
                    Student student = (Student)studentsListBox.Items[i];
                    if (selectedRow.Cells[1].Value.ToString().Contains(student.FirstName.TrimEnd()) && selectedRow.Cells[1].Value.ToString().Contains(student.LastName.TrimEnd()))
                    {
                        studentsListBox.SetSelected(i, true);
                        return;
                    }
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (classeCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Il faut sélectionner la classe");
            }
            else if (courseCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Il faut sélctionner le cours");
            }
            else if (studentsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Il faut sélectionner l'étudiant");
            }
            else if (noteUpDown.Value == 0)
            {
                if (MessageBox.Show("Confirmation", "La note est 0, êtes-vous sûr de vouloir continuer ?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }

            }

            if (Note.CreateNote(((Course)courseCombo.SelectedItem).Id, ((Student)studentsListBox.SelectedItem).Id, noteUpDown.Value))
            {
                loadNotes(classeCombo.SelectedItem.ToString(), ((Course)courseCombo.SelectedItem).Id);
                MessageBox.Show("Note Ajouté");
                resetControls();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Note.Delete(int.Parse(idTxt.Text));
            loadNotes(classeCombo.SelectedItem.ToString(), ((Course)courseCombo.SelectedItem).Id);
        }
    }
}
