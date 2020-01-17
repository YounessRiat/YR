namespace Pharmacie
{
    partial class FrmFamille
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.cbFamille = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.cbChercher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 60);
            this.label3.TabIndex = 14;
            this.label3.Text = "Famille";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(13, 72);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(698, 380);
            this.xtraTabControl1.TabIndex = 39;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.Color.Gray;
            this.xtraTabPage2.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage2.Controls.Add(this.panel3);
            this.xtraTabPage2.Controls.Add(this.panel4);
            this.xtraTabPage2.Controls.Add(this.button4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(692, 352);
            this.xtraTabPage2.Text = "Mise à jour";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(461, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 142);
            this.panel3.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button2.Location = new System.Drawing.Point(0, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button3.Location = new System.Drawing.Point(0, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 43);
            this.button3.TabIndex = 12;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.cbMedicament);
            this.panel4.Controls.Add(this.cbFamille);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Location = new System.Drawing.Point(68, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 131);
            this.panel4.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Designation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "ID-Medicament";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "ID-Famille";
            // 
            // cbMedicament
            // 
            this.cbMedicament.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(128, 48);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(193, 29);
            this.cbMedicament.TabIndex = 29;
            // 
            // cbFamille
            // 
            this.cbFamille.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cbFamille.FormattingEnabled = true;
            this.cbFamille.Location = new System.Drawing.Point(128, 8);
            this.cbFamille.Name = "cbFamille";
            this.cbFamille.Size = new System.Drawing.Size(193, 29);
            this.cbFamille.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(128, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 30);
            this.textBox3.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(68, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 46);
            this.button4.TabIndex = 34;
            this.button4.Text = "Terminer";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Appearance.PageClient.BackColor = System.Drawing.Color.Black;
            this.xtraTabPage3.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage3.Controls.Add(this.dataGridView1);
            this.xtraTabPage3.Controls.Add(this.label12);
            this.xtraTabPage3.Controls.Add(this.label13);
            this.xtraTabPage3.Controls.Add(this.button5);
            this.xtraTabPage3.Controls.Add(this.cbChercher);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(692, 352);
            this.xtraTabPage3.Text = "Affichage";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 258);
            this.dataGridView1.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(375, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Les medicaments qui appartiennent a cette Famille sont :\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(126, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Famille";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCyan;
            this.button5.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(364, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 33);
            this.button5.TabIndex = 20;
            this.button5.Text = "Chercher:";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // cbChercher
            // 
            this.cbChercher.FormattingEnabled = true;
            this.cbChercher.Location = new System.Drawing.Point(187, 26);
            this.cbChercher.Name = "cbChercher";
            this.cbChercher.Size = new System.Drawing.Size(160, 21);
            this.cbChercher.TabIndex = 15;
            // 
            // FrmFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacie.Properties.Resources.labo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 455);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.label3);
            this.Name = "FrmFamille";
            this.Text = "FrmFamille";
            this.Load += new System.EventHandler(this.FrmFamille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.ComboBox cbFamille;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbChercher;
    }
}