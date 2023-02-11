namespace iPad_Verwaltung
{
    partial class frmAuswahl
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuswahl));
            this.lblIpad = new System.Windows.Forms.Label();
            this.btnAuswahlSchließen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeraete = new System.Windows.Forms.Button();
            this.btnRueckgabe = new System.Windows.Forms.Button();
            this.pnlMenue = new System.Windows.Forms.Panel();
            this.btnDatenbank = new System.Windows.Forms.Button();
            this.btnAusgabe = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pctIpad = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnAuswahlMinimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenue.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIpad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIpad
            // 
            this.lblIpad.AutoSize = true;
            this.lblIpad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpad.Location = new System.Drawing.Point(237, 47);
            this.lblIpad.Name = "lblIpad";
            this.lblIpad.Size = new System.Drawing.Size(139, 20);
            this.lblIpad.TabIndex = 7;
            this.lblIpad.Text = "iPad Verwaltung";
            // 
            // btnAuswahlSchließen
            // 
            this.btnAuswahlSchließen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAuswahlSchließen.FlatAppearance.BorderSize = 0;
            this.btnAuswahlSchließen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuswahlSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuswahlSchließen.Image = ((System.Drawing.Image)(resources.GetObject("btnAuswahlSchließen.Image")));
            this.btnAuswahlSchließen.Location = new System.Drawing.Point(500, 4);
            this.btnAuswahlSchließen.Name = "btnAuswahlSchließen";
            this.btnAuswahlSchließen.Size = new System.Drawing.Size(31, 28);
            this.btnAuswahlSchließen.TabIndex = 6;
            this.btnAuswahlSchließen.UseVisualStyleBackColor = false;
            this.btnAuswahlSchließen.Click += new System.EventHandler(this.btnAuswahlSchließen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGeraete
            // 
            this.btnGeraete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGeraete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGeraete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeraete.FlatAppearance.BorderSize = 0;
            this.btnGeraete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeraete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraete.Location = new System.Drawing.Point(0, 195);
            this.btnGeraete.Name = "btnGeraete";
            this.btnGeraete.Size = new System.Drawing.Size(111, 62);
            this.btnGeraete.TabIndex = 3;
            this.btnGeraete.Text = "Geräte";
            this.btnGeraete.UseVisualStyleBackColor = false;
            this.btnGeraete.Click += new System.EventHandler(this.btnGeraete_Click_1);
            // 
            // btnRueckgabe
            // 
            this.btnRueckgabe.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRueckgabe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRueckgabe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRueckgabe.FlatAppearance.BorderSize = 0;
            this.btnRueckgabe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRueckgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRueckgabe.Location = new System.Drawing.Point(0, 133);
            this.btnRueckgabe.Name = "btnRueckgabe";
            this.btnRueckgabe.Size = new System.Drawing.Size(111, 62);
            this.btnRueckgabe.TabIndex = 2;
            this.btnRueckgabe.Text = "Rückgabe";
            this.btnRueckgabe.UseVisualStyleBackColor = false;
            this.btnRueckgabe.Click += new System.EventHandler(this.btnRueckgabe_Click_1);
            // 
            // pnlMenue
            // 
            this.pnlMenue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlMenue.Controls.Add(this.btnDatenbank);
            this.pnlMenue.Controls.Add(this.btnGeraete);
            this.pnlMenue.Controls.Add(this.btnRueckgabe);
            this.pnlMenue.Controls.Add(this.btnAusgabe);
            this.pnlMenue.Controls.Add(this.pnlLogo);
            this.pnlMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenue.Location = new System.Drawing.Point(0, 0);
            this.pnlMenue.Name = "pnlMenue";
            this.pnlMenue.Size = new System.Drawing.Size(111, 287);
            this.pnlMenue.TabIndex = 5;
            // 
            // btnDatenbank
            // 
            this.btnDatenbank.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDatenbank.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatenbank.FlatAppearance.BorderSize = 0;
            this.btnDatenbank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatenbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatenbank.Location = new System.Drawing.Point(0, 257);
            this.btnDatenbank.Name = "btnDatenbank";
            this.btnDatenbank.Size = new System.Drawing.Size(111, 30);
            this.btnDatenbank.TabIndex = 4;
            this.btnDatenbank.Text = "Klassenwechsel";
            this.btnDatenbank.UseVisualStyleBackColor = false;
            this.btnDatenbank.Click += new System.EventHandler(this.btnDatenbank_Click);
            // 
            // btnAusgabe
            // 
            this.btnAusgabe.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAusgabe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAusgabe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAusgabe.FlatAppearance.BorderSize = 0;
            this.btnAusgabe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAusgabe.Location = new System.Drawing.Point(0, 71);
            this.btnAusgabe.Name = "btnAusgabe";
            this.btnAusgabe.Size = new System.Drawing.Size(111, 62);
            this.btnAusgabe.TabIndex = 1;
            this.btnAusgabe.Text = "Ausgabe";
            this.btnAusgabe.UseVisualStyleBackColor = false;
            this.btnAusgabe.Click += new System.EventHandler(this.btnAusgabe_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(111, 71);
            this.pnlLogo.TabIndex = 0;
            // 
            // pctIpad
            // 
            this.pctIpad.Image = ((System.Drawing.Image)(resources.GetObject("pctIpad.Image")));
            this.pctIpad.Location = new System.Drawing.Point(237, 91);
            this.pctIpad.Name = "pctIpad";
            this.pctIpad.Size = new System.Drawing.Size(139, 143);
            this.pctIpad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctIpad.TabIndex = 8;
            this.pctIpad.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(470, 259);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 28);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblLogin.Location = new System.Drawing.Point(238, 259);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(82, 13);
            this.lblLogin.TabIndex = 34;
            this.lblLogin.Text = "Angemeldet als:";
            // 
            // btnAuswahlMinimize
            // 
            this.btnAuswahlMinimize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAuswahlMinimize.FlatAppearance.BorderSize = 0;
            this.btnAuswahlMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuswahlMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuswahlMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuswahlMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnAuswahlMinimize.Image")));
            this.btnAuswahlMinimize.Location = new System.Drawing.Point(465, 1);
            this.btnAuswahlMinimize.Name = "btnAuswahlMinimize";
            this.btnAuswahlMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnAuswahlMinimize.TabIndex = 35;
            this.btnAuswahlMinimize.UseVisualStyleBackColor = false;
            this.btnAuswahlMinimize.Click += new System.EventHandler(this.btnAuswahlMinimize_Click);
            // 
            // frmAuswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(535, 287);
            this.Controls.Add(this.btnAuswahlMinimize);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnAuswahlSchließen);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pctIpad);
            this.Controls.Add(this.lblIpad);
            this.Controls.Add(this.pnlMenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuswahl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auswahl";
            this.Load += new System.EventHandler(this.frmAuswahl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenue.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctIpad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIpad;
        private System.Windows.Forms.Button btnAuswahlSchließen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGeraete;
        private System.Windows.Forms.Button btnRueckgabe;
        private System.Windows.Forms.Panel pnlMenue;
        private System.Windows.Forms.Button btnAusgabe;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pctIpad;
        private System.Windows.Forms.Button btnDatenbank;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnAuswahlMinimize;
    }
}

