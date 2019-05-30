namespace Gestion_Ipsas.Ui
{
    partial class GestionEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEtudiant));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.classeTxt = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.studentsDataGridView);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.classeTxt);
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
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etudiant";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passwordTxt.Location = new System.Drawing.Point(23, 100);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(162, 24);
            this.passwordTxt.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(20, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Mot de passe";
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(23, 197);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.RowTemplate.Height = 24;
            this.studentsDataGridView.ShowEditingIcon = false;
            this.studentsDataGridView.Size = new System.Drawing.Size(881, 273);
            this.studentsDataGridView.TabIndex = 35;
            this.studentsDataGridView.Click += new System.EventHandler(this.studentsDataGridView_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(763, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 33);
            this.button4.TabIndex = 34;
            this.button4.Text = "Ajouter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.save_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.Location = new System.Drawing.Point(616, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 33);
            this.button3.TabIndex = 33;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.update_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(469, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 33);
            this.button2.TabIndex = 32;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(322, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.new_Click);
            // 
            // classeTxt
            // 
            this.classeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.classeTxt.Location = new System.Drawing.Point(528, 100);
            this.classeTxt.Name = "classeTxt";
            this.classeTxt.Size = new System.Drawing.Size(376, 24);
            this.classeTxt.TabIndex = 29;
            // 
            // birthDate
            // 
            this.birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.birthDate.Location = new System.Drawing.Point(191, 100);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(331, 24);
            this.birthDate.TabIndex = 28;
            // 
            // fNameTxt
            // 
            this.fNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fNameTxt.Location = new System.Drawing.Point(528, 43);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(376, 24);
            this.fNameTxt.TabIndex = 26;
            // 
            // lNameTxt
            // 
            this.lNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lNameTxt.Location = new System.Drawing.Point(191, 43);
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(331, 24);
            this.lNameTxt.TabIndex = 25;
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
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
            this.label5.Location = new System.Drawing.Point(191, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date de naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(528, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Classe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(528, 22);
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
            // GestionEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 511);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionEtudiant";
            this.Text = "Gérer Etudiant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox classeTxt;
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