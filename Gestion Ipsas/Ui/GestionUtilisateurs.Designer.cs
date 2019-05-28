namespace Gestion_Ipsas.Ui
{
    partial class GestionUtilisateurs
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
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.usersDgv = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roleCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roleCombo);
            this.groupBox1.Controls.Add(this.passwordTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.usersDgv);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.birthDate);
            this.groupBox1.Controls.Add(this.fNameTxt);
            this.groupBox1.Controls.Add(this.lNameTxt);
            this.groupBox1.Controls.Add(this.idTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 487);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etudiant";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passwordTxt.Location = new System.Drawing.Point(647, 43);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(257, 24);
            this.passwordTxt.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(644, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Mot de passe";
            // 
            // usersDgv
            // 
            this.usersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDgv.Location = new System.Drawing.Point(23, 197);
            this.usersDgv.Name = "usersDgv";
            this.usersDgv.ReadOnly = true;
            this.usersDgv.RowTemplate.Height = 24;
            this.usersDgv.ShowEditingIcon = false;
            this.usersDgv.Size = new System.Drawing.Size(881, 273);
            this.usersDgv.TabIndex = 34;
            this.usersDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDgv_CellClick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(763, 139);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(141, 33);
            this.add.TabIndex = 33;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.update.Location = new System.Drawing.Point(616, 139);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(141, 33);
            this.update.TabIndex = 32;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.delete.Location = new System.Drawing.Point(469, 139);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(141, 33);
            this.delete.TabIndex = 31;
            this.delete.Text = "Supprimer";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.reset.Location = new System.Drawing.Point(322, 139);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(141, 33);
            this.reset.TabIndex = 30;
            this.reset.Text = "Nouveau";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // birthDate
            // 
            this.birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.birthDate.Location = new System.Drawing.Point(23, 100);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(440, 24);
            this.birthDate.TabIndex = 28;
            // 
            // fNameTxt
            // 
            this.fNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fNameTxt.Location = new System.Drawing.Point(371, 43);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(270, 24);
            this.fNameTxt.TabIndex = 26;
            // 
            // lNameTxt
            // 
            this.lNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lNameTxt.Location = new System.Drawing.Point(191, 43);
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(174, 24);
            this.lNameTxt.TabIndex = 25;
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.idTxt.Location = new System.Drawing.Point(23, 43);
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(162, 24);
            this.idTxt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(20, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date de naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(368, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(188, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Identifiant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(466, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Role";
            // 
            // roleCombo
            // 
            this.roleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCombo.FormattingEnabled = true;
            this.roleCombo.Items.AddRange(new object[] {
            "Etudiant",
            "Enseignant",
            "Responsable Formation",
            "Responsable Stages",
            "Responsable Examens",
            "Directeur"});
            this.roleCombo.Location = new System.Drawing.Point(469, 100);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.Size = new System.Drawing.Size(435, 24);
            this.roleCombo.TabIndex = 29;
            // 
            // GestionUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 532);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionUtilisateurs";
            this.Text = "GestionUtilisateurs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox roleCombo;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView usersDgv;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.TextBox lNameTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}