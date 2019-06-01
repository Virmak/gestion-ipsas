namespace Gestion_Ipsas.Ui
{
    partial class GestionStages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionStages));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.entrepriseTxt = new System.Windows.Forms.TextBox();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.classeCombo = new System.Windows.Forms.ComboBox();
            this.studentsCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stagesDGV = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stagesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.stagesDGV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.studentsCombo);
            this.groupBox1.Controls.Add(this.classeCombo);
            this.groupBox1.Controls.Add(this.dateFin);
            this.groupBox1.Controls.Add(this.dateDebut);
            this.groupBox1.Controls.Add(this.entrepriseTxt);
            this.groupBox1.Controls.Add(this.idTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entreprise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Fin";
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.idTxt.Location = new System.Drawing.Point(6, 54);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(123, 24);
            this.idTxt.TabIndex = 3;
            // 
            // entrepriseTxt
            // 
            this.entrepriseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.entrepriseTxt.Location = new System.Drawing.Point(135, 54);
            this.entrepriseTxt.Name = "entrepriseTxt";
            this.entrepriseTxt.Size = new System.Drawing.Size(412, 24);
            this.entrepriseTxt.TabIndex = 4;
            // 
            // dateDebut
            // 
            this.dateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateDebut.Location = new System.Drawing.Point(553, 54);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(283, 24);
            this.dateDebut.TabIndex = 6;
            // 
            // dateFin
            // 
            this.dateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateFin.Location = new System.Drawing.Point(6, 113);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(289, 24);
            this.dateFin.TabIndex = 7;
            // 
            // classeCombo
            // 
            this.classeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.classeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.classeCombo.FormattingEnabled = true;
            this.classeCombo.Location = new System.Drawing.Point(301, 113);
            this.classeCombo.Name = "classeCombo";
            this.classeCombo.Size = new System.Drawing.Size(246, 26);
            this.classeCombo.TabIndex = 8;
            this.classeCombo.SelectedIndexChanged += new System.EventHandler(this.classeCombo_SelectedIndexChanged);
            // 
            // studentsCombo
            // 
            this.studentsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.studentsCombo.FormattingEnabled = true;
            this.studentsCombo.Location = new System.Drawing.Point(553, 113);
            this.studentsCombo.Name = "studentsCombo";
            this.studentsCombo.Size = new System.Drawing.Size(283, 26);
            this.studentsCombo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date Debut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Classe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Etudiant";
            // 
            // stagesDGV
            // 
            this.stagesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stagesDGV.Location = new System.Drawing.Point(6, 184);
            this.stagesDGV.Name = "stagesDGV";
            this.stagesDGV.RowTemplate.Height = 24;
            this.stagesDGV.Size = new System.Drawing.Size(830, 275);
            this.stagesDGV.TabIndex = 13;
            this.stagesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stagesDGV_CellClick);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(695, 145);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(141, 33);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.add_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.updateBtn.Location = new System.Drawing.Point(548, 145);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(141, 33);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Modifier";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deleteBtn.Location = new System.Drawing.Point(401, 145);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(141, 33);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Supprimer";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newBtn.Location = new System.Drawing.Point(254, 145);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(141, 33);
            this.newBtn.TabIndex = 17;
            this.newBtn.Text = "Nouveau";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionStages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 489);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionStages";
            this.Text = "Gestion Stages";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stagesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox classeCombo;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.TextBox entrepriseTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stagesDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox studentsCombo;
    }
}