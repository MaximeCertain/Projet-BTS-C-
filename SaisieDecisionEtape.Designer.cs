namespace gesAMM
{
    partial class SaisieDecisionEtape
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
            this.lvMedicamentsAutorisees = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbNumEtape = new System.Windows.Forms.TextBox();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpNorme = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtValider = new System.Windows.Forms.Button();
            this.cbEtape = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDerniereDateNorme = new System.Windows.Forms.DateTimePicker();
            this.dtpDerniereDate = new System.Windows.Forms.DateTimePicker();
            this.tbDerniereNorme = new System.Windows.Forms.TextBox();
            this.tbDernierLibelle = new System.Windows.Forms.TextBox();
            this.tbNumDerniereEtape = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAMM = new System.Windows.Forms.TextBox();
            this.lblAMM = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMedicamentsAutorisees
            // 
            this.lvMedicamentsAutorisees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvMedicamentsAutorisees.FullRowSelect = true;
            this.lvMedicamentsAutorisees.Location = new System.Drawing.Point(5, 30);
            this.lvMedicamentsAutorisees.Name = "lvMedicamentsAutorisees";
            this.lvMedicamentsAutorisees.Size = new System.Drawing.Size(1261, 223);
            this.lvMedicamentsAutorisees.TabIndex = 3;
            this.lvMedicamentsAutorisees.UseCompatibleStateImageBehavior = false;
            this.lvMedicamentsAutorisees.View = System.Windows.Forms.View.Details;
            this.lvMedicamentsAutorisees.SelectedIndexChanged += new System.EventHandler(this.lvMedicamentsAutorisees_SelectedIndexChanged);
            this.lvMedicamentsAutorisees.Click += new System.EventHandler(this.lvMedicamentsAutorisees_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DepotLegal";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "nomCommercial";
            this.columnHeader5.Width = 252;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "composition";
            this.columnHeader6.Width = 243;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "effets";
            this.columnHeader7.Width = 158;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "contreIndications";
            this.columnHeader8.Width = 144;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "amm";
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "derniereEtape";
            this.columnHeader10.Width = 138;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "codeFamille";
            this.columnHeader11.Width = 142;
            // 
            // tbNumEtape
            // 
            this.tbNumEtape.Enabled = false;
            this.tbNumEtape.Location = new System.Drawing.Point(190, 34);
            this.tbNumEtape.Name = "tbNumEtape";
            this.tbNumEtape.Size = new System.Drawing.Size(100, 22);
            this.tbNumEtape.TabIndex = 4;
            // 
            // tbLibelle
            // 
            this.tbLibelle.Enabled = false;
            this.tbLibelle.Location = new System.Drawing.Point(191, 94);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(100, 22);
            this.tbLibelle.TabIndex = 5;
            this.tbLibelle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbNorme
            // 
            this.tbNorme.Enabled = false;
            this.tbNorme.Location = new System.Drawing.Point(190, 160);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.Size = new System.Drawing.Size(100, 22);
            this.tbNorme.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(190, 66);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(274, 22);
            this.dtpDate.TabIndex = 7;
            // 
            // dtpNorme
            // 
            this.dtpNorme.Enabled = false;
            this.dtpNorme.Location = new System.Drawing.Point(191, 130);
            this.dtpNorme.Name = "dtpNorme";
            this.dtpNorme.Size = new System.Drawing.Size(273, 22);
            this.dtpNorme.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numéro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Libellé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Norme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "DateNorme Nécéssaire";
            // 
            // BtValider
            // 
            this.BtValider.Location = new System.Drawing.Point(33, 253);
            this.BtValider.Name = "BtValider";
            this.BtValider.Size = new System.Drawing.Size(223, 43);
            this.BtValider.TabIndex = 14;
            this.BtValider.Text = "Valider";
            this.BtValider.UseVisualStyleBackColor = true;
            this.BtValider.Click += new System.EventHandler(this.BtValider_Click);
            // 
            // cbEtape
            // 
            this.cbEtape.AutoSize = true;
            this.cbEtape.Location = new System.Drawing.Point(177, 193);
            this.cbEtape.Name = "cbEtape";
            this.cbEtape.Size = new System.Drawing.Size(114, 21);
            this.cbEtape.TabIndex = 15;
            this.cbEtape.Text = "EtapeValidee";
            this.cbEtape.UseVisualStyleBackColor = true;
            this.cbEtape.CheckedChanged += new System.EventHandler(this.cbEtape_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Validee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "DateNorme Nécéssaire";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Norme";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Libellé";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Numéro";
            // 
            // dtpDerniereDateNorme
            // 
            this.dtpDerniereDateNorme.Enabled = false;
            this.dtpDerniereDateNorme.Location = new System.Drawing.Point(189, 125);
            this.dtpDerniereDateNorme.Name = "dtpDerniereDateNorme";
            this.dtpDerniereDateNorme.Size = new System.Drawing.Size(277, 22);
            this.dtpDerniereDateNorme.TabIndex = 21;
            // 
            // dtpDerniereDate
            // 
            this.dtpDerniereDate.Enabled = false;
            this.dtpDerniereDate.Location = new System.Drawing.Point(189, 56);
            this.dtpDerniereDate.Name = "dtpDerniereDate";
            this.dtpDerniereDate.Size = new System.Drawing.Size(277, 22);
            this.dtpDerniereDate.TabIndex = 20;
            // 
            // tbDerniereNorme
            // 
            this.tbDerniereNorme.Enabled = false;
            this.tbDerniereNorme.Location = new System.Drawing.Point(189, 155);
            this.tbDerniereNorme.Name = "tbDerniereNorme";
            this.tbDerniereNorme.Size = new System.Drawing.Size(100, 22);
            this.tbDerniereNorme.TabIndex = 19;
            // 
            // tbDernierLibelle
            // 
            this.tbDernierLibelle.Enabled = false;
            this.tbDernierLibelle.Location = new System.Drawing.Point(189, 91);
            this.tbDernierLibelle.Name = "tbDernierLibelle";
            this.tbDernierLibelle.Size = new System.Drawing.Size(100, 22);
            this.tbDernierLibelle.TabIndex = 18;
            // 
            // tbNumDerniereEtape
            // 
            this.tbNumDerniereEtape.Enabled = false;
            this.tbNumDerniereEtape.Location = new System.Drawing.Point(189, 27);
            this.tbNumDerniereEtape.Name = "tbNumDerniereEtape";
            this.tbNumDerniereEtape.Size = new System.Drawing.Size(100, 22);
            this.tbNumDerniereEtape.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbNumDerniereEtape);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbDernierLibelle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbDerniereNorme);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpDerniereDate);
            this.groupBox1.Controls.Add(this.dtpDerniereDateNorme);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 243);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dernière Etape";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAMM);
            this.groupBox2.Controls.Add(this.tbAMM);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbNumEtape);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbLibelle);
            this.groupBox2.Controls.Add(this.cbEtape);
            this.groupBox2.Controls.Add(this.tbNorme);
            this.groupBox2.Controls.Add(this.BtValider);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpNorme);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(567, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 302);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nouvelle Etape";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbAMM
            // 
            this.tbAMM.Location = new System.Drawing.Point(190, 220);
            this.tbAMM.Name = "tbAMM";
            this.tbAMM.Size = new System.Drawing.Size(135, 22);
            this.tbAMM.TabIndex = 29;
            this.tbAMM.Visible = false;
            // 
            // lblAMM
            // 
            this.lblAMM.AutoSize = true;
            this.lblAMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMM.Location = new System.Drawing.Point(8, 217);
            this.lblAMM.Name = "lblAMM";
            this.lblAMM.Size = new System.Drawing.Size(163, 25);
            this.lblAMM.TabIndex = 30;
            this.lblAMM.Text = "AMM de l\'étape";
            this.lblAMM.Visible = false;
            this.lblAMM.Click += new System.EventHandler(this.lblAMM_Click);
            // 
            // SaisieDecisionEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvMedicamentsAutorisees);
            this.Name = "SaisieDecisionEtape";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "SaisieDecisionEtape";
            this.Load += new System.EventHandler(this.SaisieDecisionEtape_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMedicamentsAutorisees;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TextBox tbNumEtape;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.TextBox tbNorme;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpNorme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtValider;
        private System.Windows.Forms.CheckBox cbEtape;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDerniereDateNorme;
        private System.Windows.Forms.DateTimePicker dtpDerniereDate;
        private System.Windows.Forms.TextBox tbDerniereNorme;
        private System.Windows.Forms.TextBox tbDernierLibelle;
        private System.Windows.Forms.TextBox tbNumDerniereEtape;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAMM;
        private System.Windows.Forms.Label lblAMM;
    }
}