namespace iPad_Verwaltung
{
    partial class frmAusgabe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAusgabe));
            this.btnAusgabeZurueck = new System.Windows.Forms.Button();
            this.pnlAusgabe = new System.Windows.Forms.Panel();
            this.btnAusgabeSchließen = new System.Windows.Forms.Button();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.chkUnterschrift = new System.Windows.Forms.CheckBox();
            this.ausgabeDatum = new System.Windows.Forms.DateTimePicker();
            this.lblAusgabeDatum = new System.Windows.Forms.Label();
            this.cmdGeraet = new System.Windows.Forms.ComboBox();
            this.lblGeraet = new System.Windows.Forms.Label();
            this.cmbSchueler = new System.Windows.Forms.ComboBox();
            this.lblSchueler = new System.Windows.Forms.Label();
            this.lblKlasse = new System.Windows.Forms.Label();
            this.lblTrenner = new System.Windows.Forms.Label();
            this.cmbKlasse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAusgabeMinimize = new System.Windows.Forms.Button();
            this.pnlAusgabe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAusgabeZurueck
            // 
            this.btnAusgabeZurueck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAusgabeZurueck.FlatAppearance.BorderSize = 0;
            this.btnAusgabeZurueck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAusgabeZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAusgabeZurueck.Image = ((System.Drawing.Image)(resources.GetObject("btnAusgabeZurueck.Image")));
            this.btnAusgabeZurueck.Location = new System.Drawing.Point(3, 4);
            this.btnAusgabeZurueck.Name = "btnAusgabeZurueck";
            this.btnAusgabeZurueck.Size = new System.Drawing.Size(34, 29);
            this.btnAusgabeZurueck.TabIndex = 14;
            this.btnAusgabeZurueck.UseVisualStyleBackColor = false;
            this.btnAusgabeZurueck.Click += new System.EventHandler(this.btnAusgabeZurueck_Click_1);
            // 
            // pnlAusgabe
            // 
            this.pnlAusgabe.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlAusgabe.Controls.Add(this.btnAusgabeMinimize);
            this.pnlAusgabe.Controls.Add(this.btnAusgabeZurueck);
            this.pnlAusgabe.Controls.Add(this.btnAusgabeSchließen);
            this.pnlAusgabe.Controls.Add(this.lblAusgabe);
            this.pnlAusgabe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAusgabe.Location = new System.Drawing.Point(0, 0);
            this.pnlAusgabe.Name = "pnlAusgabe";
            this.pnlAusgabe.Size = new System.Drawing.Size(469, 38);
            this.pnlAusgabe.TabIndex = 19;
            // 
            // btnAusgabeSchließen
            // 
            this.btnAusgabeSchließen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAusgabeSchließen.FlatAppearance.BorderSize = 0;
            this.btnAusgabeSchließen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAusgabeSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAusgabeSchließen.Image = ((System.Drawing.Image)(resources.GetObject("btnAusgabeSchließen.Image")));
            this.btnAusgabeSchließen.Location = new System.Drawing.Point(429, 2);
            this.btnAusgabeSchließen.Name = "btnAusgabeSchließen";
            this.btnAusgabeSchließen.Size = new System.Drawing.Size(39, 33);
            this.btnAusgabeSchließen.TabIndex = 12;
            this.btnAusgabeSchließen.UseVisualStyleBackColor = false;
            this.btnAusgabeSchließen.Click += new System.EventHandler(this.btnAusgabeSchließen_Click);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAusgabe.Location = new System.Drawing.Point(172, 9);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(131, 20);
            this.lblAusgabe.TabIndex = 0;
            this.lblAusgabe.Text = "iPad - Ausgabe";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSpeichern.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSpeichern.FlatAppearance.BorderSize = 0;
            this.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(0, 344);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(469, 55);
            this.btnSpeichern.TabIndex = 31;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = false;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // chkUnterschrift
            // 
            this.chkUnterschrift.AutoSize = true;
            this.chkUnterschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnterschrift.Location = new System.Drawing.Point(40, 298);
            this.chkUnterschrift.Name = "chkUnterschrift";
            this.chkUnterschrift.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUnterschrift.Size = new System.Drawing.Size(253, 20);
            this.chkUnterschrift.TabIndex = 30;
            this.chkUnterschrift.Text = "Unterschrift vom Schüler erhalten";
            this.chkUnterschrift.UseVisualStyleBackColor = true;
            // 
            // ausgabeDatum
            // 
            this.ausgabeDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabeDatum.Location = new System.Drawing.Point(176, 221);
            this.ausgabeDatum.Name = "ausgabeDatum";
            this.ausgabeDatum.Size = new System.Drawing.Size(253, 22);
            this.ausgabeDatum.TabIndex = 29;
            // 
            // lblAusgabeDatum
            // 
            this.lblAusgabeDatum.AutoSize = true;
            this.lblAusgabeDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAusgabeDatum.Location = new System.Drawing.Point(37, 224);
            this.lblAusgabeDatum.Name = "lblAusgabeDatum";
            this.lblAusgabeDatum.Size = new System.Drawing.Size(127, 16);
            this.lblAusgabeDatum.TabIndex = 28;
            this.lblAusgabeDatum.Text = "Datum (Ausgabe)";
            // 
            // cmdGeraet
            // 
            this.cmdGeraet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdGeraet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGeraet.FormattingEnabled = true;
            this.cmdGeraet.Location = new System.Drawing.Point(107, 172);
            this.cmdGeraet.Name = "cmdGeraet";
            this.cmdGeraet.Size = new System.Drawing.Size(263, 21);
            this.cmdGeraet.TabIndex = 27;
            // 
            // lblGeraet
            // 
            this.lblGeraet.AutoSize = true;
            this.lblGeraet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeraet.Location = new System.Drawing.Point(37, 173);
            this.lblGeraet.Name = "lblGeraet";
            this.lblGeraet.Size = new System.Drawing.Size(45, 16);
            this.lblGeraet.TabIndex = 26;
            this.lblGeraet.Text = "Gerät";
            // 
            // cmbSchueler
            // 
            this.cmbSchueler.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbSchueler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSchueler.FormattingEnabled = true;
            this.cmbSchueler.Location = new System.Drawing.Point(107, 121);
            this.cmbSchueler.Name = "cmbSchueler";
            this.cmbSchueler.Size = new System.Drawing.Size(263, 21);
            this.cmbSchueler.TabIndex = 25;
            // 
            // lblSchueler
            // 
            this.lblSchueler.AutoSize = true;
            this.lblSchueler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchueler.Location = new System.Drawing.Point(37, 122);
            this.lblSchueler.Name = "lblSchueler";
            this.lblSchueler.Size = new System.Drawing.Size(59, 16);
            this.lblSchueler.TabIndex = 24;
            this.lblSchueler.Text = "Schüler";
            // 
            // lblKlasse
            // 
            this.lblKlasse.AutoSize = true;
            this.lblKlasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlasse.Location = new System.Drawing.Point(37, 69);
            this.lblKlasse.Name = "lblKlasse";
            this.lblKlasse.Size = new System.Drawing.Size(54, 16);
            this.lblKlasse.TabIndex = 20;
            this.lblKlasse.Text = "Klasse";
            // 
            // lblTrenner
            // 
            this.lblTrenner.AutoSize = true;
            this.lblTrenner.Location = new System.Drawing.Point(-12, 270);
            this.lblTrenner.Name = "lblTrenner";
            this.lblTrenner.Size = new System.Drawing.Size(511, 13);
            this.lblTrenner.TabIndex = 32;
            this.lblTrenner.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // cmbKlasse
            // 
            this.cmbKlasse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbKlasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKlasse.FormattingEnabled = true;
            this.cmbKlasse.Location = new System.Drawing.Point(107, 69);
            this.cmbKlasse.Name = "cmbKlasse";
            this.cmbKlasse.Size = new System.Drawing.Size(263, 21);
            this.cmbKlasse.TabIndex = 33;
            this.cmbKlasse.SelectedIndexChanged += new System.EventHandler(this.cmbKlasse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // btnAusgabeMinimize
            // 
            this.btnAusgabeMinimize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAusgabeMinimize.FlatAppearance.BorderSize = 0;
            this.btnAusgabeMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAusgabeMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAusgabeMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAusgabeMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnAusgabeMinimize.Image")));
            this.btnAusgabeMinimize.Location = new System.Drawing.Point(397, 0);
            this.btnAusgabeMinimize.Name = "btnAusgabeMinimize";
            this.btnAusgabeMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnAusgabeMinimize.TabIndex = 20;
            this.btnAusgabeMinimize.UseVisualStyleBackColor = false;
            this.btnAusgabeMinimize.Click += new System.EventHandler(this.btnAusgabeMinimize_Click);
            // 
            // frmAusgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(469, 399);
            this.Controls.Add(this.cmbKlasse);
            this.Controls.Add(this.lblTrenner);
            this.Controls.Add(this.pnlAusgabe);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.chkUnterschrift);
            this.Controls.Add(this.ausgabeDatum);
            this.Controls.Add(this.lblAusgabeDatum);
            this.Controls.Add(this.cmdGeraet);
            this.Controls.Add(this.lblGeraet);
            this.Controls.Add(this.cmbSchueler);
            this.Controls.Add(this.lblSchueler);
            this.Controls.Add(this.lblKlasse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAusgabe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ausgabe";
            this.Load += new System.EventHandler(this.frmAusgabe_Load);
            this.pnlAusgabe.ResumeLayout(false);
            this.pnlAusgabe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAusgabeZurueck;
        private System.Windows.Forms.Panel pnlAusgabe;
        private System.Windows.Forms.Button btnAusgabeSchließen;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.CheckBox chkUnterschrift;
        private System.Windows.Forms.DateTimePicker ausgabeDatum;
        private System.Windows.Forms.Label lblAusgabeDatum;
        private System.Windows.Forms.ComboBox cmdGeraet;
        private System.Windows.Forms.Label lblGeraet;
        private System.Windows.Forms.ComboBox cmbSchueler;
        private System.Windows.Forms.Label lblSchueler;
        private System.Windows.Forms.Label lblKlasse;
        private System.Windows.Forms.Label lblTrenner;
        private System.Windows.Forms.ComboBox cmbKlasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAusgabeMinimize;
    }
}