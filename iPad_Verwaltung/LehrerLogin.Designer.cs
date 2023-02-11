namespace iPad_Verwaltung
{
    partial class frmLehrerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLehrerLogin));
            this.lblLehrerLogin = new System.Windows.Forms.Label();
            this.pnlGeraete = new System.Windows.Forms.Panel();
            this.btnLoginSchließen = new System.Windows.Forms.Button();
            this.txtKuerzel = new System.Windows.Forms.TextBox();
            this.lblKuerzel = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoginMinimize = new System.Windows.Forms.Button();
            this.pnlGeraete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLehrerLogin
            // 
            this.lblLehrerLogin.AutoSize = true;
            this.lblLehrerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLehrerLogin.Location = new System.Drawing.Point(137, 9);
            this.lblLehrerLogin.Name = "lblLehrerLogin";
            this.lblLehrerLogin.Size = new System.Drawing.Size(110, 20);
            this.lblLehrerLogin.TabIndex = 0;
            this.lblLehrerLogin.Text = "Lehrer Login";
            // 
            // pnlGeraete
            // 
            this.pnlGeraete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlGeraete.Controls.Add(this.btnLoginMinimize);
            this.pnlGeraete.Controls.Add(this.btnLoginSchließen);
            this.pnlGeraete.Controls.Add(this.lblLehrerLogin);
            this.pnlGeraete.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGeraete.Location = new System.Drawing.Point(0, 0);
            this.pnlGeraete.Name = "pnlGeraete";
            this.pnlGeraete.Size = new System.Drawing.Size(385, 38);
            this.pnlGeraete.TabIndex = 4;
            // 
            // btnLoginSchließen
            // 
            this.btnLoginSchließen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoginSchließen.FlatAppearance.BorderSize = 0;
            this.btnLoginSchließen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginSchließen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoginSchließen.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginSchließen.Image")));
            this.btnLoginSchließen.Location = new System.Drawing.Point(347, 1);
            this.btnLoginSchließen.Name = "btnLoginSchließen";
            this.btnLoginSchließen.Size = new System.Drawing.Size(38, 35);
            this.btnLoginSchließen.TabIndex = 18;
            this.btnLoginSchließen.UseVisualStyleBackColor = false;
            this.btnLoginSchließen.Click += new System.EventHandler(this.btnLoginSchließen_Click);
            // 
            // txtKuerzel
            // 
            this.txtKuerzel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKuerzel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKuerzel.Location = new System.Drawing.Point(112, 81);
            this.txtKuerzel.Name = "txtKuerzel";
            this.txtKuerzel.Size = new System.Drawing.Size(118, 20);
            this.txtKuerzel.TabIndex = 14;
            // 
            // lblKuerzel
            // 
            this.lblKuerzel.AutoSize = true;
            this.lblKuerzel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKuerzel.Location = new System.Drawing.Point(46, 83);
            this.lblKuerzel.Name = "lblKuerzel";
            this.lblKuerzel.Size = new System.Drawing.Size(49, 16);
            this.lblKuerzel.TabIndex = 13;
            this.lblKuerzel.Text = "Kürzel";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(280, 80);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 23);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Log in ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Beispiel: XXX";
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLeer.FlatAppearance.BorderSize = 0;
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeer.Image = ((System.Drawing.Image)(resources.GetObject("btnLeer.Image")));
            this.btnLeer.Location = new System.Drawing.Point(235, 79);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(29, 23);
            this.btnLeer.TabIndex = 17;
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-63, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // btnLoginMinimize
            // 
            this.btnLoginMinimize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoginMinimize.FlatAppearance.BorderSize = 0;
            this.btnLoginMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoginMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginMinimize.Image")));
            this.btnLoginMinimize.Location = new System.Drawing.Point(315, 1);
            this.btnLoginMinimize.Name = "btnLoginMinimize";
            this.btnLoginMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnLoginMinimize.TabIndex = 19;
            this.btnLoginMinimize.UseVisualStyleBackColor = false;
            this.btnLoginMinimize.Click += new System.EventHandler(this.btnLoginMinimize_Click);
            // 
            // frmLehrerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(385, 134);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtKuerzel);
            this.Controls.Add(this.lblKuerzel);
            this.Controls.Add(this.pnlGeraete);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLehrerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LehrerLogin";
            this.Load += new System.EventHandler(this.frmLehrerLogin_Load);
            this.pnlGeraete.ResumeLayout(false);
            this.pnlGeraete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLehrerLogin;
        private System.Windows.Forms.Panel pnlGeraete;
        private System.Windows.Forms.TextBox txtKuerzel;
        private System.Windows.Forms.Label lblKuerzel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnLoginSchließen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoginMinimize;
    }
}