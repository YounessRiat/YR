namespace Pharmacie
{
    partial class FrmEntree_Sortie
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
            this.label3 = new System.Windows.Forms.Label();
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
            this.cbChercher = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Affichage)).BeginInit();
            this.Affichage.SuspendLayout();
            this.mise.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 52);
            this.label3.TabIndex = 14;
            this.label3.Text = "Entrée-Sortie";
            // 
            // Affichage
            // 
            this.Affichage.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Affichage.Appearance.Options.UseBackColor = true;
            this.Affichage.Location = new System.Drawing.Point(12, 76);
            this.Affichage.Name = "Affichage";
            this.Affichage.SelectedTabPage = this.mise;
            this.Affichage.Size = new System.Drawing.Size(698, 324);
            this.Affichage.TabIndex = 37;
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
            this.mise.Size = new System.Drawing.Size(692, 296);
            this.mise.Text = "Mise à jour";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Location = new System.Drawing.Point(461, 69);
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
            this.panel2.Location = new System.Drawing.Point(23, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 216);
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
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Quantité";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Evenement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID-Sortie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID-Entrée";
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
            this.tbnTerminer.Location = new System.Drawing.Point(68, 243);
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
            this.xtraTabPage1.Controls.Add(this.dataGridView1);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.btnChercher);
            this.xtraTabPage1.Controls.Add(this.cbChercher);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(692, 296);
            this.xtraTabPage1.Text = "Affichage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Les medicaments qui appartiennent a cette Famille sont :\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Famille";
            // 
            // btnChercher
            // 
            this.btnChercher.BackColor = System.Drawing.Color.LightCyan;
            this.btnChercher.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercher.ForeColor = System.Drawing.Color.Black;
            this.btnChercher.Location = new System.Drawing.Point(364, 19);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(105, 33);
            this.btnChercher.TabIndex = 20;
            this.btnChercher.Text = "Chercher:";
            this.btnChercher.UseVisualStyleBackColor = false;
            // 
            // cbChercher
            // 
            this.cbChercher.FormattingEnabled = true;
            this.cbChercher.Location = new System.Drawing.Point(187, 26);
            this.cbChercher.Name = "cbChercher";
            this.cbChercher.Size = new System.Drawing.Size(160, 21);
            this.cbChercher.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 204);
            this.dataGridView1.TabIndex = 23;
            // 
            // FrmEntree_Sortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacie.Properties.Resources.labo;
            this.ClientSize = new System.Drawing.Size(722, 408);
            this.Controls.Add(this.Affichage);
            this.Controls.Add(this.label3);
            this.Name = "FrmEntree_Sortie";
            this.Text = "FrmEntree_Sortie";
            this.Load += new System.EventHandler(this.FrmEntree_Sortie_Load);
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

        private System.Windows.Forms.Label label3;
        private DevExpress.XtraTab.XtraTabControl Affichage;
        private DevExpress.XtraTab.XtraTabPage mise;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.ComboBox cbChercher;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}