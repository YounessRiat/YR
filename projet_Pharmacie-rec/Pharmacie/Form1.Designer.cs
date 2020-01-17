namespace Pharmacie
{
    partial class FrmAcceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcceuil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.laboratoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entreéEtSortieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratoireToolStripMenuItem,
            this.familleToolStripMenuItem,
            this.formToolStripMenuItem,
            this.entreéEtSortieToolStripMenuItem,
            this.medicamentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laboratoireToolStripMenuItem
            // 
            this.laboratoireToolStripMenuItem.Name = "laboratoireToolStripMenuItem";
            this.laboratoireToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.laboratoireToolStripMenuItem.Text = "Laboratoire ";
            this.laboratoireToolStripMenuItem.Click += new System.EventHandler(this.laboratoireToolStripMenuItem_Click);
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.familleToolStripMenuItem.Text = "Famille";
            this.familleToolStripMenuItem.Click += new System.EventHandler(this.familleToolStripMenuItem_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            this.formToolStripMenuItem.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
            // 
            // entreéEtSortieToolStripMenuItem
            // 
            this.entreéEtSortieToolStripMenuItem.Name = "entreéEtSortieToolStripMenuItem";
            this.entreéEtSortieToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.entreéEtSortieToolStripMenuItem.Text = "Entreé et Sortie";
            this.entreéEtSortieToolStripMenuItem.Click += new System.EventHandler(this.entreéEtSortieToolStripMenuItem_Click);
            // 
            // medicamentToolStripMenuItem
            // 
            this.medicamentToolStripMenuItem.Name = "medicamentToolStripMenuItem";
            this.medicamentToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.medicamentToolStripMenuItem.Text = "Medicament";
            this.medicamentToolStripMenuItem.Click += new System.EventHandler(this.medicamentToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.Silver;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(549, 152);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(204, 30);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.Silver;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(549, 222);
            this.tbPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(204, 30);
            this.tbPass.TabIndex = 3;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(549, 310);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(202, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Enter += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(426, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(889, 463);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacie.Properties.Resources.Capture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAcceuil";
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.FrmAcceuil_Load);
            this.Enter += new System.EventHandler(this.btnLogin_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLogin_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laboratoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entreéEtSortieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

