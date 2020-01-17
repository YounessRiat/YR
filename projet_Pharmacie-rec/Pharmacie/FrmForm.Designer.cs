namespace Pharmacie
{
    partial class FrmForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnChercher = new System.Windows.Forms.Button();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIDmedi = new System.Windows.Forms.ComboBox();
            this.cbIDfamille = new System.Windows.Forms.ComboBox();
            this.tbDesignation = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.tbnTerminer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "La Forme";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 64);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(689, 397);
            this.xtraTabControl1.TabIndex = 35;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.textBox4);
            this.xtraTabPage2.Controls.Add(this.dataGridView1);
            this.xtraTabPage2.Controls.Add(this.label10);
            this.xtraTabPage2.Controls.Add(this.label11);
            this.xtraTabPage2.Controls.Add(this.btnChercher);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(683, 369);
            this.xtraTabPage2.Text = "Afficher";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.textBox4.Location = new System.Drawing.Point(151, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 28);
            this.textBox4.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 287);
            this.dataGridView1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "La forme  est :\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 29);
            this.label11.TabIndex = 27;
            this.label11.Text = "Form:";
            // 
            // btnChercher
            // 
            this.btnChercher.BackColor = System.Drawing.Color.LightCyan;
            this.btnChercher.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercher.ForeColor = System.Drawing.Color.Black;
            this.btnChercher.Location = new System.Drawing.Point(306, 13);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(105, 33);
            this.btnChercher.TabIndex = 25;
            this.btnChercher.Text = "Chercher:";
            this.btnChercher.UseVisualStyleBackColor = false;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.panel2);
            this.xtraTabPage3.Controls.Add(this.panel1);
            this.xtraTabPage3.Controls.Add(this.tbnTerminer);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(683, 369);
            this.xtraTabPage3.Text = "Mise à jour";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbIDmedi);
            this.panel2.Controls.Add(this.cbIDfamille);
            this.panel2.Controls.Add(this.tbDesignation);
            this.panel2.Location = new System.Drawing.Point(25, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 173);
            this.panel2.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Poids";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "libellé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID-Forme";
            // 
            // cbIDmedi
            // 
            this.cbIDmedi.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cbIDmedi.FormattingEnabled = true;
            this.cbIDmedi.Location = new System.Drawing.Point(157, 63);
            this.cbIDmedi.Name = "cbIDmedi";
            this.cbIDmedi.Size = new System.Drawing.Size(193, 29);
            this.cbIDmedi.TabIndex = 29;
            // 
            // cbIDfamille
            // 
            this.cbIDfamille.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cbIDfamille.FormattingEnabled = true;
            this.cbIDfamille.Location = new System.Drawing.Point(157, 30);
            this.cbIDfamille.Name = "cbIDfamille";
            this.cbIDfamille.Size = new System.Drawing.Size(193, 29);
            this.cbIDfamille.TabIndex = 28;
            // 
            // tbDesignation
            // 
            this.tbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesignation.Location = new System.Drawing.Point(157, 103);
            this.tbDesignation.Name = "tbDesignation";
            this.tbDesignation.Size = new System.Drawing.Size(193, 30);
            this.tbDesignation.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Location = new System.Drawing.Point(452, 74);
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
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
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
            // tbnTerminer
            // 
            this.tbnTerminer.BackColor = System.Drawing.Color.LightCyan;
            this.tbnTerminer.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.tbnTerminer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnTerminer.ForeColor = System.Drawing.Color.Black;
            this.tbnTerminer.Location = new System.Drawing.Point(25, 255);
            this.tbnTerminer.Name = "tbnTerminer";
            this.tbnTerminer.Size = new System.Drawing.Size(177, 46);
            this.tbnTerminer.TabIndex = 36;
            this.tbnTerminer.Text = "Terminer";
            this.tbnTerminer.UseVisualStyleBackColor = false;
            // 
            // FrmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacie.Properties.Resources.labo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 473);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmForm";
            this.Text = "FrmForm";
            this.Load += new System.EventHandler(this.FrmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnChercher;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIDmedi;
        private System.Windows.Forms.ComboBox cbIDfamille;
        private System.Windows.Forms.TextBox tbDesignation;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button tbnTerminer;
        private System.Windows.Forms.Panel panel1;
    }
}