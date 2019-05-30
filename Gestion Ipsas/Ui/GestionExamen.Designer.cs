namespace Gestion_Ipsas.Ui
{
    partial class GestionExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionExamen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateExamen = new System.Windows.Forms.DateTimePicker();
            this.courseCombo = new System.Windows.Forms.ComboBox();
            this.dureeUpDown = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.examenDgv = new System.Windows.Forms.DataGridView();
            this.teacherTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateExamen);
            this.groupBox1.Controls.Add(this.courseCombo);
            this.groupBox1.Controls.Add(this.dureeUpDown);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.examenDgv);
            this.groupBox1.Controls.Add(this.teacherTxt);
            this.groupBox1.Controls.Add(this.idTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 507);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Examen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date";
            // 
            // dateExamen
            // 
            this.dateExamen.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateExamen.Location = new System.Drawing.Point(9, 107);
            this.dateExamen.Name = "dateExamen";
            this.dateExamen.Size = new System.Drawing.Size(422, 24);
            this.dateExamen.TabIndex = 7;
            // 
            // courseCombo
            // 
            this.courseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.courseCombo.FormattingEnabled = true;
            this.courseCombo.Location = new System.Drawing.Point(142, 45);
            this.courseCombo.Name = "courseCombo";
            this.courseCombo.Size = new System.Drawing.Size(289, 26);
            this.courseCombo.TabIndex = 5;
            this.courseCombo.SelectedIndexChanged += new System.EventHandler(this.courseCombo_SelectedIndexChanged);
            // 
            // dureeUpDown
            // 
            this.dureeUpDown.DecimalPlaces = 1;
            this.dureeUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dureeUpDown.Location = new System.Drawing.Point(437, 45);
            this.dureeUpDown.Name = "dureeUpDown";
            this.dureeUpDown.Size = new System.Drawing.Size(333, 24);
            this.dureeUpDown.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(632, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "Ajouter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.add_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.Location = new System.Drawing.Point(485, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.update_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(338, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(191, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.new_Click);
            // 
            // examenDgv
            // 
            this.examenDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examenDgv.Location = new System.Drawing.Point(9, 185);
            this.examenDgv.Name = "examenDgv";
            this.examenDgv.RowTemplate.Height = 24;
            this.examenDgv.Size = new System.Drawing.Size(764, 313);
            this.examenDgv.TabIndex = 13;
            this.examenDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.examenDgv_CellClick);
            // 
            // teacherTxt
            // 
            this.teacherTxt.Enabled = false;
            this.teacherTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.teacherTxt.Location = new System.Drawing.Point(437, 107);
            this.teacherTxt.Name = "teacherTxt";
            this.teacherTxt.ReadOnly = true;
            this.teacherTxt.Size = new System.Drawing.Size(333, 24);
            this.teacherTxt.TabIndex = 8;
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.idTxt.Location = new System.Drawing.Point(9, 45);
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(127, 24);
            this.idTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(434, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enseignant";
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labl.Location = new System.Drawing.Point(434, 24);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(48, 18);
            this.labl.TabIndex = 2;
            this.labl.Text = "Durée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(139, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // GestionExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionExamen";
            this.Text = "Gestion Examen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown dureeUpDown;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView examenDgv;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateExamen;
        private System.Windows.Forms.TextBox teacherTxt;
    }
}