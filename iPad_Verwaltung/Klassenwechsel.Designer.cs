namespace iPad_Verwaltung
{
    partial class frmKlassenwechsel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKlassenwechsel));
            this.pnlWechsel = new System.Windows.Forms.Panel();
            this.btnKlassenwechselZurueck = new System.Windows.Forms.Button();
            this.btnKlassenwechselSchließen = new System.Windows.Forms.Button();
            this.lblGeraete = new System.Windows.Forms.Label();
            this.lblTrenner = new System.Windows.Forms.Label();
            this.cmbKlasse = new System.Windows.Forms.ComboBox();
            this.lblKlasse = new System.Windows.Forms.Label();
            this.btnWechseln = new System.Windows.Forms.Button();
            this.cmbSchueler = new System.Windows.Forms.ComboBox();
            this.lblSchueler = new System.Windows.Forms.Label();
            this.cmbKlasseNeu = new System.Windows.Forms.ComboBox();
            this.lblKlasseNeu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWechselMinimize = new System.Windows.Forms.Button();
            this.pnlWechsel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWechsel
            // 
            this.pnlWechsel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlWechsel.Controls.Add(this.btnWechselMinimize);
            this.pnlWechsel.Controls.Add(this.btnKlassenwechselZurueck);
            this.pnlWechsel.Controls.Add(this.btnKlassenwechselSchließen);
            this.pnlWechsel.Controls.Add(this.lblGeraete);
            this.pnlWechsel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWechsel.Location = new System.Drawing.Point(0, 0);
            this.pnlWechsel.Name = "pnlWechsel";
            this.pnlWechsel.Size = new System.Drawing.Size(469, 38);
            this.pnlWechsel.TabIndex = 42;
            // 
            // btnKlassenwechselZurueck
            // 
            this.btnKlassenwechselZurueck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKlassenwechselZurueck.FlatAppearance.BorderSize = 0;
            this.btnKlassenwechselZurueck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlassenwechselZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlassenwechselZurueck.Image = ((System.Drawing.Image)(resources.GetObject("btnKlassenwechselZurueck.Image")));
            this.btnKlassenwechselZurueck.Location = new System.Drawing.Point(2, 4);
            this.btnKlassenwechselZurueck.Name = "btnKlassenwechselZurueck";
            this.btnKlassenwechselZurueck.Size = new System.Drawing.Size(34, 29);
            this.btnKlassenwechselZurueck.TabIndex = 49;
            this.btnKlassenwechselZurueck.UseVisualStyleBackColor = false;
            this.btnKlassenwechselZurueck.Click += new System.EventHandler(this.btnKlassenwechselZurueck_Click);
            // 
            // btnKlassenwechselSchließen
            // 
            this.btnKlassenwechselSchließen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKlassenwechselSchließen.FlatAppearance.BorderSize = 0;
            this.btnKlassenwechselSchließen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlassenwechselSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlassenwechselSchließen.Image = ((System.Drawing.Image)(resources.GetObject("btnKlassenwechselSchließen.Image")));
            this.btnKlassenwechselSchließen.Location = new System.Drawing.Point(428, 2);
            this.btnKlassenwechselSchließen.Name = "btnKlassenwechselSchließen";
            this.btnKlassenwechselSchließen.Size = new System.Drawing.Size(39, 33);
            this.btnKlassenwechselSchließen.TabIndex = 48;
            this.btnKlassenwechselSchließen.UseVisualStyleBackColor = false;
            this.btnKlassenwechselSchließen.Click += new System.EventHandler(this.btnKlassenwechselSchließen_Click);
            // 
            // lblGeraete
            // 
            this.lblGeraete.AutoSize = true;
            this.lblGeraete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeraete.Location = new System.Drawing.Point(154, 8);
            this.lblGeraete.Name = "lblGeraete";
            this.lblGeraete.Size = new System.Drawing.Size(136, 20);
            this.lblGeraete.TabIndex = 0;
            this.lblGeraete.Text = "Klassenwechsel";
            // 
            // lblTrenner
            // 
            this.lblTrenner.AutoSize = true;
            this.lblTrenner.Location = new System.Drawing.Point(-17, 103);
            this.lblTrenner.Name = "lblTrenner";
            this.lblTrenner.Size = new System.Drawing.Size(511, 13);
            this.lblTrenner.TabIndex = 36;
            this.lblTrenner.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // cmbKlasse
            // 
            this.cmbKlasse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbKlasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKlasse.FormattingEnabled = true;
            this.cmbKlasse.Location = new System.Drawing.Point(112, 74);
            this.cmbKlasse.Name = "cmbKlasse";
            this.cmbKlasse.Size = new System.Drawing.Size(263, 21);
            this.cmbKlasse.TabIndex = 35;
            this.cmbKlasse.SelectedIndexChanged += new System.EventHandler(this.cmbKlasse_SelectedIndexChanged);
            // 
            // lblKlasse
            // 
            this.lblKlasse.AutoSize = true;
            this.lblKlasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlasse.Location = new System.Drawing.Point(37, 75);
            this.lblKlasse.Name = "lblKlasse";
            this.lblKlasse.Size = new System.Drawing.Size(54, 16);
            this.lblKlasse.TabIndex = 34;
            this.lblKlasse.Text = "Klasse";
            // 
            // btnWechseln
            // 
            this.btnWechseln.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWechseln.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnWechseln.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWechseln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWechseln.Location = new System.Drawing.Point(0, 244);
            this.btnWechseln.Name = "btnWechseln";
            this.btnWechseln.Size = new System.Drawing.Size(469, 55);
            this.btnWechseln.TabIndex = 41;
            this.btnWechseln.Text = "Klasse Wechseln";
            this.btnWechseln.UseVisualStyleBackColor = false;
            this.btnWechseln.Click += new System.EventHandler(this.btnWechseln_Click);
            // 
            // cmbSchueler
            // 
            this.cmbSchueler.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbSchueler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSchueler.FormattingEnabled = true;
            this.cmbSchueler.Location = new System.Drawing.Point(138, 137);
            this.cmbSchueler.Name = "cmbSchueler";
            this.cmbSchueler.Size = new System.Drawing.Size(237, 21);
            this.cmbSchueler.TabIndex = 44;
            // 
            // lblSchueler
            // 
            this.lblSchueler.AutoSize = true;
            this.lblSchueler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchueler.Location = new System.Drawing.Point(37, 138);
            this.lblSchueler.Name = "lblSchueler";
            this.lblSchueler.Size = new System.Drawing.Size(68, 16);
            this.lblSchueler.TabIndex = 43;
            this.lblSchueler.Text = "Schueler";
            // 
            // cmbKlasseNeu
            // 
            this.cmbKlasseNeu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbKlasseNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKlasseNeu.FormattingEnabled = true;
            this.cmbKlasseNeu.Location = new System.Drawing.Point(138, 180);
            this.cmbKlasseNeu.Name = "cmbKlasseNeu";
            this.cmbKlasseNeu.Size = new System.Drawing.Size(237, 21);
            this.cmbKlasseNeu.TabIndex = 46;
            // 
            // lblKlasseNeu
            // 
            this.lblKlasseNeu.AutoSize = true;
            this.lblKlasseNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlasseNeu.Location = new System.Drawing.Point(37, 181);
            this.lblKlasseNeu.Name = "lblKlasseNeu";
            this.lblKlasseNeu.Size = new System.Drawing.Size(95, 16);
            this.lblKlasseNeu.TabIndex = 45;
            this.lblKlasseNeu.Text = "Neue Klasse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // btnWechselMinimize
            // 
            this.btnWechselMinimize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWechselMinimize.FlatAppearance.BorderSize = 0;
            this.btnWechselMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWechselMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWechselMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWechselMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnWechselMinimize.Image")));
            this.btnWechselMinimize.Location = new System.Drawing.Point(396, 1);
            this.btnWechselMinimize.Name = "btnWechselMinimize";
            this.btnWechselMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnWechselMinimize.TabIndex = 50;
            this.btnWechselMinimize.UseVisualStyleBackColor = false;
            this.btnWechselMinimize.Click += new System.EventHandler(this.btnWechselMinimize_Click);
            // 
            // frmKlassenwechsel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(469, 299);
            this.Controls.Add(this.cmbKlasseNeu);
            this.Controls.Add(this.lblKlasseNeu);
            this.Controls.Add(this.cmbSchueler);
            this.Controls.Add(this.lblSchueler);
            this.Controls.Add(this.lblTrenner);
            this.Controls.Add(this.pnlWechsel);
            this.Controls.Add(this.cmbKlasse);
            this.Controls.Add(this.lblKlasse);
            this.Controls.Add(this.btnWechseln);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKlassenwechsel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datenbank";
            this.Load += new System.EventHandler(this.frmDatenbank_Load);
            this.pnlWechsel.ResumeLayout(false);
            this.pnlWechsel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlWechsel;
        private System.Windows.Forms.Label lblGeraete;
        private System.Windows.Forms.Label lblTrenner;
        private System.Windows.Forms.ComboBox cmbKlasse;
        private System.Windows.Forms.Label lblKlasse;
        private System.Windows.Forms.Button btnWechseln;
        private System.Windows.Forms.ComboBox cmbSchueler;
        private System.Windows.Forms.Label lblSchueler;
        private System.Windows.Forms.ComboBox cmbKlasseNeu;
        private System.Windows.Forms.Label lblKlasseNeu;
        private System.Windows.Forms.Button btnKlassenwechselZurueck;
        private System.Windows.Forms.Button btnKlassenwechselSchließen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWechselMinimize;
    }
}