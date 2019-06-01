namespace Gestion_Ipsas.Ui
{
    partial class GestionNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchStudTxt = new System.Windows.Forms.TextBox();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.courseCombo = new System.Windows.Forms.ComboBox();
            this.classeCombo = new System.Windows.Forms.ComboBox();
            this.noteUpDown = new System.Windows.Forms.NumericUpDown();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.notesDGV = new System.Windows.Forms.DataGridView();
            this.Notelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.IdentifiantLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IdentifiantLbl);
            this.groupBox1.Controls.Add(this.idTxt);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.courseCombo);
            this.groupBox1.Controls.Add(this.classeCombo);
            this.groupBox1.Controls.Add(this.noteUpDown);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.notesDGV);
            this.groupBox1.Controls.Add(this.Notelbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 612);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.searchStudTxt);
            this.groupBox2.Controls.Add(this.studentsListBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 181);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etudiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chercher Etudiant";
            // 
            // searchStudTxt
            // 
            this.searchStudTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.searchStudTxt.Location = new System.Drawing.Point(6, 41);
            this.searchStudTxt.Name = "searchStudTxt";
            this.searchStudTxt.Size = new System.Drawing.Size(749, 24);
            this.searchStudTxt.TabIndex = 2;
            this.searchStudTxt.TextChanged += new System.EventHandler(this.searchStudTxt_TextChanged);
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.ItemHeight = 16;
            this.studentsListBox.Location = new System.Drawing.Point(6, 71);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(749, 100);
            this.studentsListBox.TabIndex = 1;
            this.studentsListBox.SelectedIndexChanged += new System.EventHandler(this.studentsListBox_SelectedIndexChanged);
            // 
            // courseCombo
            // 
            this.courseCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.courseCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.courseCombo.FormattingEnabled = true;
            this.courseCombo.Location = new System.Drawing.Point(259, 44);
            this.courseCombo.Name = "courseCombo";
            this.courseCombo.Size = new System.Drawing.Size(289, 26);
            this.courseCombo.TabIndex = 16;
            this.courseCombo.SelectedIndexChanged += new System.EventHandler(this.courseCombo_SelectedIndexChanged);
            // 
            // classeCombo
            // 
            this.classeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.classeCombo.FormattingEnabled = true;
            this.classeCombo.Location = new System.Drawing.Point(123, 43);
            this.classeCombo.Name = "classeCombo";
            this.classeCombo.Size = new System.Drawing.Size(127, 26);
            this.classeCombo.TabIndex = 15;
            this.classeCombo.SelectedIndexChanged += new System.EventHandler(this.classeCombo_SelectedIndexChanged);
            // 
            // noteUpDown
            // 
            this.noteUpDown.DecimalPlaces = 2;
            this.noteUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.noteUpDown.Location = new System.Drawing.Point(554, 45);
            this.noteUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.noteUpDown.Name = "noteUpDown";
            this.noteUpDown.Size = new System.Drawing.Size(216, 24);
            this.noteUpDown.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(629, 264);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(141, 33);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.updateBtn.Location = new System.Drawing.Point(482, 264);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(141, 33);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Modifier";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deleteBtn.Location = new System.Drawing.Point(335, 264);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(141, 33);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Supprimer";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // notesDGV
            // 
            this.notesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesDGV.Location = new System.Drawing.Point(6, 303);
            this.notesDGV.Name = "notesDGV";
            this.notesDGV.RowTemplate.Height = 24;
            this.notesDGV.Size = new System.Drawing.Size(764, 299);
            this.notesDGV.TabIndex = 12;
            this.notesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notesDGV_CellClick);
            // 
            // Notelbl
            // 
            this.Notelbl.AutoSize = true;
            this.Notelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Notelbl.Location = new System.Drawing.Point(551, 24);
            this.Notelbl.Name = "Notelbl";
            this.Notelbl.Size = new System.Drawing.Size(40, 18);
            this.Notelbl.TabIndex = 2;
            this.Notelbl.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(256, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(120, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classe";
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.idTxt.Location = new System.Drawing.Point(15, 44);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(102, 24);
            this.idTxt.TabIndex = 4;
            // 
            // IdentifiantLbl
            // 
            this.IdentifiantLbl.AutoSize = true;
            this.IdentifiantLbl.Location = new System.Drawing.Point(12, 26);
            this.IdentifiantLbl.Name = "IdentifiantLbl";
            this.IdentifiantLbl.Size = new System.Drawing.Size(69, 17);
            this.IdentifiantLbl.TabIndex = 4;
            this.IdentifiantLbl.Text = "Identifiant";
            // 
            // GestionNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 631);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionNotes";
            this.Text = "GestionNotes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox classeCombo;
        private System.Windows.Forms.NumericUpDown noteUpDown;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView notesDGV;
        private System.Windows.Forms.Label Notelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchStudTxt;
        private System.Windows.Forms.Label IdentifiantLbl;
        private System.Windows.Forms.TextBox idTxt;
    }
}