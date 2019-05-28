namespace Gestion_Ipsas.Ui
{
    partial class GestionEnseignant
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
            this.teachersDGV = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.naissanceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.newTeacher = new System.Windows.Forms.Button();
            this.specialiteTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.fnameTxt = new System.Windows.Forms.TextBox();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teachersDGV);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.naissanceDatePicker);
            this.groupBox1.Controls.Add(this.newTeacher);
            this.groupBox1.Controls.Add(this.specialiteTxt);
            this.groupBox1.Controls.Add(this.passTxt);
            this.groupBox1.Controls.Add(this.fnameTxt);
            this.groupBox1.Controls.Add(this.lnameTxt);
            this.groupBox1.Controls.Add(this.idTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enseignant";
            // 
            // teachersDGV
            // 
            this.teachersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDGV.Location = new System.Drawing.Point(8, 209);
            this.teachersDGV.Name = "teachersDGV";
            this.teachersDGV.RowTemplate.Height = 24;
            this.teachersDGV.Size = new System.Drawing.Size(860, 225);
            this.teachersDGV.TabIndex = 16;
            this.teachersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teachersDGV_CellClick);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(725, 156);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(141, 33);
            this.save.TabIndex = 15;
            this.save.Text = "Ajouter";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.edit.Location = new System.Drawing.Point(578, 156);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(141, 33);
            this.edit.TabIndex = 14;
            this.edit.Text = "Modifier";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(242, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date de naissance";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.delete.Location = new System.Drawing.Point(431, 156);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(141, 33);
            this.delete.TabIndex = 13;
            this.delete.Text = "Supprimer";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // naissanceDatePicker
            // 
            this.naissanceDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.naissanceDatePicker.Location = new System.Drawing.Point(242, 114);
            this.naissanceDatePicker.Name = "naissanceDatePicker";
            this.naissanceDatePicker.Size = new System.Drawing.Size(320, 24);
            this.naissanceDatePicker.TabIndex = 10;
            // 
            // newTeacher
            // 
            this.newTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newTeacher.Location = new System.Drawing.Point(284, 156);
            this.newTeacher.Name = "newTeacher";
            this.newTeacher.Size = new System.Drawing.Size(141, 33);
            this.newTeacher.TabIndex = 12;
            this.newTeacher.Text = "Nouveau";
            this.newTeacher.UseVisualStyleBackColor = true;
            this.newTeacher.Click += new System.EventHandler(this.newTeacher_Click);
            // 
            // specialiteTxt
            // 
            this.specialiteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.specialiteTxt.Location = new System.Drawing.Point(568, 114);
            this.specialiteTxt.Name = "specialiteTxt";
            this.specialiteTxt.Size = new System.Drawing.Size(298, 24);
            this.specialiteTxt.TabIndex = 11;
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passTxt.Location = new System.Drawing.Point(18, 114);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(218, 24);
            this.passTxt.TabIndex = 9;
            // 
            // fnameTxt
            // 
            this.fnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fnameTxt.Location = new System.Drawing.Point(568, 55);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(298, 24);
            this.fnameTxt.TabIndex = 8;
            // 
            // lnameTxt
            // 
            this.lnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lnameTxt.Location = new System.Drawing.Point(242, 55);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(320, 24);
            this.lnameTxt.TabIndex = 7;
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.idTxt.Location = new System.Drawing.Point(18, 55);
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(218, 24);
            this.idTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(565, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Spécialité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(565, 34);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(239, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // GestionEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 463);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionEnseignant";
            this.Text = "GestionEnseignant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker naissanceDatePicker;
        private System.Windows.Forms.TextBox specialiteTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox fnameTxt;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button newTeacher;
        private System.Windows.Forms.DataGridView teachersDGV;
    }
}