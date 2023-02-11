namespace iPad_Verwaltung
{
    partial class frmGeraete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeraete));
            this.lblGeraete = new System.Windows.Forms.Label();
            this.pnlGeraete = new System.Windows.Forms.Panel();
            this.btnGeraeteZurueck = new System.Windows.Forms.Button();
            this.btnGeraeteSchließen = new System.Windows.Forms.Button();
            this.cmbGeraet = new System.Windows.Forms.ComboBox();
            this.lblGeraet = new System.Windows.Forms.Label();
            this.txtMarke = new System.Windows.Forms.TextBox();
            this.lblMarke = new System.Windows.Forms.Label();
            this.lblTrenner = new System.Windows.Forms.Label();
            this.txtModell = new System.Windows.Forms.TextBox();
            this.lblModell = new System.Windows.Forms.Label();
            this.txtArt2 = new System.Windows.Forms.TextBox();
            this.txtArt = new System.Windows.Forms.Label();
            this.txtSpeicher = new System.Windows.Forms.TextBox();
            this.lblSpeicher = new System.Windows.Forms.Label();
            this.txtWert = new System.Windows.Forms.TextBox();
            this.lblWert = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtGeliehen2 = new System.Windows.Forms.TextBox();
            this.lblGeliehen2 = new System.Windows.Forms.Label();
            this.txtVerliehen = new System.Windows.Forms.TextBox();
            this.lblVerliehen = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtKlasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSchaeden = new System.Windows.Forms.Label();
            this.lstSchaeden = new System.Windows.Forms.ListBox();
            this.txtSchaeden = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeraeteMinimize = new System.Windows.Forms.Button();
            this.pnlGeraete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGeraete
            // 
            this.lblGeraete.AutoSize = true;
            this.lblGeraete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeraete.Location = new System.Drawing.Point(154, 8);
            this.lblGeraete.Name = "lblGeraete";
            this.lblGeraete.Size = new System.Drawing.Size(147, 20);
            this.lblGeraete.TabIndex = 0;
            this.lblGeraete.Text = "Geräte Übersicht";
            // 
            // pnlGeraete
            // 
            this.pnlGeraete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlGeraete.Controls.Add(this.btnGeraeteMinimize);
            this.pnlGeraete.Controls.Add(this.btnGeraeteZurueck);
            this.pnlGeraete.Controls.Add(this.btnGeraeteSchließen);
            this.pnlGeraete.Controls.Add(this.lblGeraete);
            this.pnlGeraete.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGeraete.Location = new System.Drawing.Point(0, 0);
            this.pnlGeraete.Name = "pnlGeraete";
            this.pnlGeraete.Size = new System.Drawing.Size(469, 38);
            this.pnlGeraete.TabIndex = 3;
            // 
            // btnGeraeteZurueck
            // 
            this.btnGeraeteZurueck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGeraeteZurueck.FlatAppearance.BorderSize = 0;
            this.btnGeraeteZurueck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeraeteZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraeteZurueck.Image = ((System.Drawing.Image)(resources.GetObject("btnGeraeteZurueck.Image")));
            this.btnGeraeteZurueck.Location = new System.Drawing.Point(2, 4);
            this.btnGeraeteZurueck.Name = "btnGeraeteZurueck";
            this.btnGeraeteZurueck.Size = new System.Drawing.Size(34, 29);
            this.btnGeraeteZurueck.TabIndex = 50;
            this.btnGeraeteZurueck.UseVisualStyleBackColor = false;
            this.btnGeraeteZurueck.Click += new System.EventHandler(this.btnGeraeteZurueck_Click);
            // 
            // btnGeraeteSchließen
            // 
            this.btnGeraeteSchließen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGeraeteSchließen.FlatAppearance.BorderSize = 0;
            this.btnGeraeteSchließen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeraeteSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraeteSchließen.Image = ((System.Drawing.Image)(resources.GetObject("btnGeraeteSchließen.Image")));
            this.btnGeraeteSchließen.Location = new System.Drawing.Point(428, 2);
            this.btnGeraeteSchließen.Name = "btnGeraeteSchließen";
            this.btnGeraeteSchließen.Size = new System.Drawing.Size(39, 33);
            this.btnGeraeteSchließen.TabIndex = 49;
            this.btnGeraeteSchließen.UseVisualStyleBackColor = false;
            this.btnGeraeteSchließen.Click += new System.EventHandler(this.btnGeraeteSchließen_Click);
            // 
            // cmbGeraet
            // 
            this.cmbGeraet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbGeraet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGeraet.FormattingEnabled = true;
            this.cmbGeraet.Location = new System.Drawing.Point(112, 74);
            this.cmbGeraet.Name = "cmbGeraet";
            this.cmbGeraet.Size = new System.Drawing.Size(263, 21);
            this.cmbGeraet.TabIndex = 10;
            this.cmbGeraet.SelectedIndexChanged += new System.EventHandler(this.cmbGeraet_SelectedIndexChanged);
            // 
            // lblGeraet
            // 
            this.lblGeraet.AutoSize = true;
            this.lblGeraet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeraet.Location = new System.Drawing.Point(37, 75);
            this.lblGeraet.Name = "lblGeraet";
            this.lblGeraet.Size = new System.Drawing.Size(45, 16);
            this.lblGeraet.TabIndex = 9;
            this.lblGeraet.Text = "Gerät";
            // 
            // txtMarke
            // 
            this.txtMarke.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtMarke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarke.Location = new System.Drawing.Point(112, 233);
            this.txtMarke.Name = "txtMarke";
            this.txtMarke.ReadOnly = true;
            this.txtMarke.Size = new System.Drawing.Size(263, 20);
            this.txtMarke.TabIndex = 14;
            // 
            // lblMarke
            // 
            this.lblMarke.AutoSize = true;
            this.lblMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarke.Location = new System.Drawing.Point(37, 234);
            this.lblMarke.Name = "lblMarke";
            this.lblMarke.Size = new System.Drawing.Size(50, 16);
            this.lblMarke.TabIndex = 13;
            this.lblMarke.Text = "Marke";
            // 
            // lblTrenner
            // 
            this.lblTrenner.AutoSize = true;
            this.lblTrenner.Location = new System.Drawing.Point(-17, 103);
            this.lblTrenner.Name = "lblTrenner";
            this.lblTrenner.Size = new System.Drawing.Size(511, 13);
            this.lblTrenner.TabIndex = 33;
            this.lblTrenner.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // txtModell
            // 
            this.txtModell.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtModell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModell.Location = new System.Drawing.Point(112, 281);
            this.txtModell.Name = "txtModell";
            this.txtModell.ReadOnly = true;
            this.txtModell.Size = new System.Drawing.Size(263, 20);
            this.txtModell.TabIndex = 35;
            // 
            // lblModell
            // 
            this.lblModell.AutoSize = true;
            this.lblModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModell.Location = new System.Drawing.Point(37, 282);
            this.lblModell.Name = "lblModell";
            this.lblModell.Size = new System.Drawing.Size(54, 16);
            this.lblModell.TabIndex = 34;
            this.lblModell.Text = "Modell";
            // 
            // txtArt2
            // 
            this.txtArt2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtArt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArt2.Location = new System.Drawing.Point(112, 184);
            this.txtArt2.Name = "txtArt2";
            this.txtArt2.ReadOnly = true;
            this.txtArt2.Size = new System.Drawing.Size(263, 20);
            this.txtArt2.TabIndex = 37;
            // 
            // txtArt
            // 
            this.txtArt.AutoSize = true;
            this.txtArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArt.Location = new System.Drawing.Point(37, 185);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(26, 16);
            this.txtArt.TabIndex = 36;
            this.txtArt.Text = "Art";
            // 
            // txtSpeicher
            // 
            this.txtSpeicher.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSpeicher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpeicher.Location = new System.Drawing.Point(112, 328);
            this.txtSpeicher.Name = "txtSpeicher";
            this.txtSpeicher.ReadOnly = true;
            this.txtSpeicher.Size = new System.Drawing.Size(263, 20);
            this.txtSpeicher.TabIndex = 39;
            // 
            // lblSpeicher
            // 
            this.lblSpeicher.AutoSize = true;
            this.lblSpeicher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeicher.Location = new System.Drawing.Point(37, 329);
            this.lblSpeicher.Name = "lblSpeicher";
            this.lblSpeicher.Size = new System.Drawing.Size(69, 16);
            this.lblSpeicher.TabIndex = 38;
            this.lblSpeicher.Text = "Speicher";
            // 
            // txtWert
            // 
            this.txtWert.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtWert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWert.Location = new System.Drawing.Point(186, 376);
            this.txtWert.Name = "txtWert";
            this.txtWert.ReadOnly = true;
            this.txtWert.Size = new System.Drawing.Size(189, 20);
            this.txtWert.TabIndex = 41;
            // 
            // lblWert
            // 
            this.lblWert.AutoSize = true;
            this.lblWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWert.Location = new System.Drawing.Point(37, 377);
            this.lblWert.Name = "lblWert";
            this.lblWert.Size = new System.Drawing.Size(127, 16);
            this.lblWert.TabIndex = 40;
            this.lblWert.Text = "Anschaffungswert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-17, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(37, 138);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Location = new System.Drawing.Point(112, 137);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(263, 20);
            this.txtStatus.TabIndex = 12;
            // 
            // txtGeliehen2
            // 
            this.txtGeliehen2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtGeliehen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGeliehen2.Location = new System.Drawing.Point(158, 488);
            this.txtGeliehen2.Name = "txtGeliehen2";
            this.txtGeliehen2.ReadOnly = true;
            this.txtGeliehen2.Size = new System.Drawing.Size(217, 20);
            this.txtGeliehen2.TabIndex = 44;
            // 
            // lblGeliehen2
            // 
            this.lblGeliehen2.AutoSize = true;
            this.lblGeliehen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeliehen2.Location = new System.Drawing.Point(37, 489);
            this.lblGeliehen2.Name = "lblGeliehen2";
            this.lblGeliehen2.Size = new System.Drawing.Size(94, 16);
            this.lblGeliehen2.TabIndex = 43;
            this.lblGeliehen2.Text = "Verliehen an";
            // 
            // txtVerliehen
            // 
            this.txtVerliehen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtVerliehen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVerliehen.Location = new System.Drawing.Point(158, 629);
            this.txtVerliehen.Name = "txtVerliehen";
            this.txtVerliehen.ReadOnly = true;
            this.txtVerliehen.Size = new System.Drawing.Size(217, 20);
            this.txtVerliehen.TabIndex = 46;
            // 
            // lblVerliehen
            // 
            this.lblVerliehen.AutoSize = true;
            this.lblVerliehen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerliehen.Location = new System.Drawing.Point(37, 630);
            this.lblVerliehen.Name = "lblVerliehen";
            this.lblVerliehen.Size = new System.Drawing.Size(102, 16);
            this.lblVerliehen.TabIndex = 45;
            this.lblVerliehen.Text = "Verliehen von";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(37, 583);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(98, 16);
            this.lblDatum.TabIndex = 47;
            this.lblDatum.Text = "Verliehen am";
            // 
            // txtKlasse
            // 
            this.txtKlasse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtKlasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKlasse.Location = new System.Drawing.Point(158, 535);
            this.txtKlasse.Name = "txtKlasse";
            this.txtKlasse.ReadOnly = true;
            this.txtKlasse.Size = new System.Drawing.Size(217, 20);
            this.txtKlasse.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Klasse";
            // 
            // lblSchaeden
            // 
            this.lblSchaeden.AutoSize = true;
            this.lblSchaeden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchaeden.Location = new System.Drawing.Point(37, 421);
            this.lblSchaeden.Name = "lblSchaeden";
            this.lblSchaeden.Size = new System.Drawing.Size(137, 16);
            this.lblSchaeden.TabIndex = 51;
            this.lblSchaeden.Text = "Bekannte Schäden";
            // 
            // lstSchaeden
            // 
            this.lstSchaeden.FormattingEnabled = true;
            this.lstSchaeden.Location = new System.Drawing.Point(196, 421);
            this.lstSchaeden.Name = "lstSchaeden";
            this.lstSchaeden.Size = new System.Drawing.Size(179, 17);
            this.lstSchaeden.TabIndex = 52;
            // 
            // txtSchaeden
            // 
            this.txtSchaeden.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSchaeden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchaeden.Location = new System.Drawing.Point(196, 421);
            this.txtSchaeden.Name = "txtSchaeden";
            this.txtSchaeden.ReadOnly = true;
            this.txtSchaeden.Size = new System.Drawing.Size(179, 20);
            this.txtSchaeden.TabIndex = 53;
            // 
            // txtDatum
            // 
            this.txtDatum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDatum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatum.Location = new System.Drawing.Point(158, 583);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(217, 20);
            this.txtDatum.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // btnGeraeteMinimize
            // 
            this.btnGeraeteMinimize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGeraeteMinimize.FlatAppearance.BorderSize = 0;
            this.btnGeraeteMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeraeteMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraeteMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGeraeteMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnGeraeteMinimize.Image")));
            this.btnGeraeteMinimize.Location = new System.Drawing.Point(397, 1);
            this.btnGeraeteMinimize.Name = "btnGeraeteMinimize";
            this.btnGeraeteMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnGeraeteMinimize.TabIndex = 51;
            this.btnGeraeteMinimize.UseVisualStyleBackColor = false;
            this.btnGeraeteMinimize.Click += new System.EventHandler(this.btnGeraeteMinimize_Click);
            // 
            // frmGeraete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(469, 666);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtSchaeden);
            this.Controls.Add(this.lstSchaeden);
            this.Controls.Add(this.lblSchaeden);
            this.Controls.Add(this.txtKlasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.txtVerliehen);
            this.Controls.Add(this.lblVerliehen);
            this.Controls.Add(this.txtGeliehen2);
            this.Controls.Add(this.lblGeliehen2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWert);
            this.Controls.Add(this.lblWert);
            this.Controls.Add(this.txtSpeicher);
            this.Controls.Add(this.lblSpeicher);
            this.Controls.Add(this.txtArt2);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.txtModell);
            this.Controls.Add(this.lblModell);
            this.Controls.Add(this.lblTrenner);
            this.Controls.Add(this.txtMarke);
            this.Controls.Add(this.lblMarke);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbGeraet);
            this.Controls.Add(this.lblGeraet);
            this.Controls.Add(this.pnlGeraete);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeraete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geräte";
            this.Load += new System.EventHandler(this.frmGeraete_Load);
            this.pnlGeraete.ResumeLayout(false);
            this.pnlGeraete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGeraete;
        private System.Windows.Forms.Panel pnlGeraete;
        private System.Windows.Forms.ComboBox cmbGeraet;
        private System.Windows.Forms.Label lblGeraet;
        private System.Windows.Forms.TextBox txtMarke;
        private System.Windows.Forms.Label lblMarke;
        private System.Windows.Forms.Label lblTrenner;
        private System.Windows.Forms.TextBox txtModell;
        private System.Windows.Forms.Label lblModell;
        private System.Windows.Forms.TextBox txtArt2;
        private System.Windows.Forms.Label txtArt;
        private System.Windows.Forms.TextBox txtSpeicher;
        private System.Windows.Forms.Label lblSpeicher;
        private System.Windows.Forms.TextBox txtWert;
        private System.Windows.Forms.Label lblWert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtGeliehen2;
        private System.Windows.Forms.Label lblGeliehen2;
        private System.Windows.Forms.TextBox txtVerliehen;
        private System.Windows.Forms.Label lblVerliehen;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtKlasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSchaeden;
        private System.Windows.Forms.ListBox lstSchaeden;
        private System.Windows.Forms.TextBox txtSchaeden;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnGeraeteZurueck;
        private System.Windows.Forms.Button btnGeraeteSchließen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeraeteMinimize;
    }
}