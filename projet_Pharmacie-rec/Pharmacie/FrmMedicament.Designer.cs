namespace Pharmacie
{
    partial class FrmMedicament
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
            this.Affichage = new DevExpress.XtraTab.XtraTabControl();
            this.mise = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIDmedi = new System.Windows.Forms.ComboBox();
            this.cbIDfamille = new System.Windows.Forms.ComboBox();
            this.tbDesignation = new System.Windows.Forms.TextBox();
            this.tbnTerminer = new System.Windows.Forms.Button();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChercher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Affichage)).BeginInit();
            this.Affichage.SuspendLayout();
            this.mise.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Affichage
            // 
            this.Affichage.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Affichage.Appearance.Options.UseBackColor = true;
            this.Affichage.Location = new System.Drawing.Point(12, 94);
            this.Affichage.Name = "Affichage";
            this.Affichage.SelectedTabPage = this.mise;
            this.Affichage.Size = new System.Drawing.Size(771, 406);
            this.Affichage.TabIndex = 38;
            this.Affichage.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.mise});
            // 
            // mise
            // 
            this.mise.Appearance.PageClient.BackColor = System.Drawing.Color.Silver;
            this.mise.Appearance.PageClient.Options.UseBackColor = true;
            this.mise.Controls.Add(this.panel1);
            this.mise.Controls.Add(this.panel2);
            this.mise.Controls.Add(this.tbnTerminer);
            this.mise.Name = "mise";
            this.mise.Size = new System.Drawing.Size(765, 378);
            this.mise.Text = "Mise à jour";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Location = new System.Drawing.Point(520, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 142);
            this.panel1.TabIndex = 24;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LightCyan;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnAjouter.Location = new System.Drawing.Point(0, 0);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(192, 43);
            this.btnAjouter.TabIndex = 16;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LightCyan;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnModifier.Location = new System.Drawing.Point(0, 49);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(192, 43);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LightCyan;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSupprimer.Location = new System.Drawing.Point(0, 98);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(192, 43);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbIDmedi);
            this.panel2.Controls.Add(this.cbIDfamille);
            this.panel2.Controls.Add(this.tbDesignation);
            this.panel2.Location = new System.Drawing.Point(44, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 216);
            this.panel2.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(128, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 30);
            this.textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(128, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 30);
            this.textBox1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Quantité:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Marque :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Prix:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID-Form:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID-Médicament:";
            // 
            // cbIDmedi
            // 
            this.cbIDmedi.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cbIDmedi.FormattingEnabled = true;
            this.cbIDmedi.Location = new System.Drawing.Point(128, 48);
            this.cbIDmedi.Name = "cbIDmedi";
            this.cbIDmedi.Size = new System.Drawing.Size(193, 29);
            this.cbIDmedi.TabIndex = 29;
            // 
            // cbIDfamille
            // 
            this.cbIDfamille.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cbIDfamille.FormattingEnabled = true;
            this.cbIDfamille.Location = new System.Drawing.Point(128, 8);
            this.cbIDfamille.Name = "cbIDfamille";
            this.cbIDfamille.Size = new System.Drawing.Size(193, 29);
            this.cbIDfamille.TabIndex = 28;
            // 
            // tbDesignation
            // 
            this.tbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesignation.Location = new System.Drawing.Point(128, 88);
            this.tbDesignation.Name = "tbDesignation";
            this.tbDesignation.Size = new System.Drawing.Size(193, 30);
            this.tbDesignation.TabIndex = 27;
            // 
            // tbnTerminer
            // 
            this.tbnTerminer.BackColor = System.Drawing.Color.LightCyan;
            this.tbnTerminer.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.tbnTerminer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnTerminer.ForeColor = System.Drawing.Color.Black;
            this.tbnTerminer.Location = new System.Drawing.Point(87, 309);
            this.tbnTerminer.Name = "tbnTerminer";
            this.tbnTerminer.Size = new System.Drawing.Size(177, 46);
            this.tbnTerminer.TabIndex = 34;
            this.tbnTerminer.Text = "Terminer";
            this.tbnTerminer.UseVisualStyleBackColor = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Black;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Controls.Add(this.textBox3);
            this.xtraTabPage1.Controls.Add(this.dataGridView1);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.btnChercher);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(765, 378);
            this.xtraTabPage1.Text = "Affichage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Les médicaments sont :\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Médicament :";
            // 
            // btnChercher
            // 
            this.btnChercher.BackColor = System.Drawing.Color.LightCyan;
            this.btnChercher.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercher.ForeColor = System.Drawing.Color.Black;
            this.btnChercher.Location = new System.Drawing.Point(404, 19);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(105, 33);
            this.btnChercher.TabIndex = 20;
            this.btnChercher.Text = "Chercher:";
            this.btnChercher.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 52);
            this.label3.TabIndex = 39;
            this.label3.Text = "Médicament";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 287);
            this.dataGridView1.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textBox3.Location = new System.Drawing.Point(220, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 30);
            this.textBox3.TabIndex = 24;
            // 
            // FrmMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacie.Properties.Resources.labo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Affichage);
            this.DoubleBuffered = true;
            this.Name = "FrmMedicament";
            this.Text = "FrmMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.Affichage)).EndInit();
            this.Affichage.ResumeLayout(false);
            this.mise.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl Affichage;
        private DevExpress.XtraTab.XtraTabPage mise;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIDmedi;
        private System.Windows.Forms.ComboBox cbIDfamille;
        private System.Windows.Forms.TextBox tbDesignation;
        private System.Windows.Forms.Button tbnTerminer;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}