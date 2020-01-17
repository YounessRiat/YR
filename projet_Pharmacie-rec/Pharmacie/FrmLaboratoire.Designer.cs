namespace Pharmacie
{
    partial class FrmLaboratoire
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbNumLabo = new System.Windows.Forms.TextBox();
            this.tbNomLabo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.tbChercher = new System.Windows.Forms.TextBox();
            this.Chercher = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbNumLabo
            // 
            this.tbNumLabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumLabo.Location = new System.Drawing.Point(234, 125);
            this.tbNumLabo.Name = "tbNumLabo";
            this.tbNumLabo.Size = new System.Drawing.Size(174, 30);
            this.tbNumLabo.TabIndex = 1;
            // 
            // tbNomLabo
            // 
            this.tbNomLabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomLabo.Location = new System.Drawing.Point(234, 163);
            this.tbNomLabo.Name = "tbNomLabo";
            this.tbNomLabo.Size = new System.Drawing.Size(174, 30);
            this.tbNomLabo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom du laboratoire:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numéro de laboratoire:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 52);
            this.label3.TabIndex = 13;
            this.label3.Text = "Laboratoire";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button3.Location = new System.Drawing.Point(23, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.LightCyan;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnValider.Location = new System.Drawing.Point(126, 5);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(89, 43);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // tbChercher
            // 
            this.tbChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChercher.Location = new System.Drawing.Point(234, 86);
            this.tbChercher.Name = "tbChercher";
            this.tbChercher.Size = new System.Drawing.Size(174, 30);
            this.tbChercher.TabIndex = 17;
            // 
            // Chercher
            // 
            this.Chercher.AutoSize = true;
            this.Chercher.BackColor = System.Drawing.Color.Transparent;
            this.Chercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chercher.Location = new System.Drawing.Point(36, 86);
            this.Chercher.Name = "Chercher";
            this.Chercher.Size = new System.Drawing.Size(0, 20);
            this.Chercher.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(139, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Chercher:";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnValider);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(391, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 59);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Location = new System.Drawing.Point(414, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 142);
            this.panel1.TabIndex = 25;
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
            // FrmLaboratoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacie.Properties.Resources.labo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 309);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Chercher);
            this.Controls.Add(this.tbChercher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomLabo);
            this.Controls.Add(this.tbNumLabo);
            this.Name = "FrmLaboratoire";
            this.Text = "FrmLaboratoire";
            this.Load += new System.EventHandler(this.FrmLaboratoire_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbNumLabo;
        private System.Windows.Forms.TextBox tbNomLabo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox tbChercher;
        private System.Windows.Forms.Label Chercher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
    }
}