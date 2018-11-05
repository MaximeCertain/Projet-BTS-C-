namespace gesAMM
{
    partial class ConsultationNombreMedicamentsFamille
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
            this.lvTableau = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnConsultationMedicament = new System.Windows.Forms.Button();
            this.lvMedicamentsAutorisees = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvTableau
            // 
            this.lvTableau.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvTableau.FullRowSelect = true;
            this.lvTableau.Location = new System.Drawing.Point(12, 37);
            this.lvTableau.Name = "lvTableau";
            this.lvTableau.Size = new System.Drawing.Size(1267, 340);
            this.lvTableau.TabIndex = 0;
            this.lvTableau.UseCompatibleStateImageBehavior = false;
            this.lvTableau.View = System.Windows.Forms.View.Details;
            this.lvTableau.SelectedIndexChanged += new System.EventHandler(this.lvTableau_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "codeFamille";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Désignation";
            this.columnHeader2.Width = 211;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre de médicaments acceptés";
            this.columnHeader3.Width = 345;
            // 
            // BtnConsultationMedicament
            // 
            this.BtnConsultationMedicament.Location = new System.Drawing.Point(432, 398);
            this.BtnConsultationMedicament.Name = "BtnConsultationMedicament";
            this.BtnConsultationMedicament.Size = new System.Drawing.Size(276, 36);
            this.BtnConsultationMedicament.TabIndex = 1;
            this.BtnConsultationMedicament.Text = "Consultation Médicament ";
            this.BtnConsultationMedicament.UseVisualStyleBackColor = true;
            this.BtnConsultationMedicament.Click += new System.EventHandler(this.BtnConsultationMedicament_Click);
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
            this.lvMedicamentsAutorisees.Location = new System.Drawing.Point(12, 450);
            this.lvMedicamentsAutorisees.Name = "lvMedicamentsAutorisees";
            this.lvMedicamentsAutorisees.Size = new System.Drawing.Size(1279, 201);
            this.lvMedicamentsAutorisees.TabIndex = 2;
            this.lvMedicamentsAutorisees.UseCompatibleStateImageBehavior = false;
            this.lvMedicamentsAutorisees.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DepotLegal";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "nomCommercial";
            this.columnHeader5.Width = 157;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "composition";
            this.columnHeader6.Width = 131;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Familles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Médicaments de la famille";
            // 
            // ConsultationNombreMedicamentsFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMedicamentsAutorisees);
            this.Controls.Add(this.BtnConsultationMedicament);
            this.Controls.Add(this.lvTableau);
            this.Name = "ConsultationNombreMedicamentsFamille";
            this.Text = "ConsultationNombreMedicamentsFamille";
            this.Load += new System.EventHandler(this.ConsultationNombreMedicamentsFamille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTableau;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BtnConsultationMedicament;
        private System.Windows.Forms.ListView lvMedicamentsAutorisees;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}