using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using static iPad_Verwaltung.DatenbankHelfer;

namespace iPad_Verwaltung
{
    public partial class frmRueckgabe : Form
    {
        private readonly DatenbankHelfer _datenbankHelfer = new DatenbankHelfer();
        private readonly string _benutzer = GlobaleVariablen.Anmeldung;
        private bool _ziehen;
        private Point _startpunkt = new Point(0, 0);

        public frmRueckgabe()
        {
            InitializeComponent();
            pnlAusgabe.MouseDown += new MouseEventHandler(frmRueckgabe_MouseDown);
            pnlAusgabe.MouseMove += new MouseEventHandler(frmRueckgabe_MouseMove);
            pnlAusgabe.MouseUp += new MouseEventHandler(frmRueckgabe_MouseUp);
            this.MouseDown += new MouseEventHandler(frmRueckgabe_MouseDown);
            this.MouseMove += new MouseEventHandler(frmRueckgabe_MouseMove);
            this.MouseUp += new MouseEventHandler(frmRueckgabe_MouseUp);
        }

        private void frmRueckgabe_Load(object sender, EventArgs e)
        {
            GetModellAusIPadsDb();
            GetBeschreibungAusSchadeninDb();

            this.cmdGeraete.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSchaden1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSchaden2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSchaden3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSchaden4.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSchaden5.DropDownStyle = ComboBoxStyle.DropDownList;

            this.dtpRueckgabeDatum.Value = DateTime.Now;
            this.Height = 410;

            btnSonstigeZurueck.Hide();
            rtxtSchaden.Hide();
        }


        private void btnRueckgabeSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRueckgabeZurueck_Click(object sender, EventArgs e)
        {
            frmAuswahl f1 = new frmAuswahl();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void btnSchadenH1_Click(object sender, EventArgs e)
        {
            if (this.Height == 410)
            {
                this.Height += 40;
            }

            this.btnSchadenH1.Hide();
        }

        private void btnSchadenR1_Click(object sender, EventArgs e)
        {
            if (this.Height == 450)
            {
                this.Height = 410;
            }

            this.btnSchadenH1.Show();
            this.cmbSchaden2.Text = "";
        }

        private void btnSchadenH2_Click(object sender, EventArgs e)
        {
            if (this.Height == 450)
            {
                this.Height += 40;
            }

            this.btnSchadenH2.Hide();
            this.btnSchadenR1.Hide();
        }

        private void btnSchadenR2_Click(object sender, EventArgs e)
        {
            if (this.Height == 490)
            {
                this.Height = 450;
            }

            this.btnSchadenH2.Show();
            this.btnSchadenR1.Show();
            this.cmbSchaden3.Text = "";
        }

        private void btnSchadenH3_Click(object sender, EventArgs e)
        {
            if (this.Height == 490)
            {
                this.Height += 40;
            }

            this.btnSchadenH3.Hide();
            this.btnSchadenR2.Hide();
        }

        private void btnSchadenR3_Click(object sender, EventArgs e)
        {
            if (this.Height == 530)
            {
                this.Height = 490;
            }

            this.btnSchadenH3.Show();
            this.btnSchadenR2.Show();
            this.cmbSchaden4.Text = "";
        }

        private void btnSchadenH4_Click(object sender, EventArgs e)
        {
            if (this.Height == 530)
            {
                this.Height += 40;
            }

            this.btnSchadenH4.Hide();
            this.btnSchadenR3.Hide();
        }

        private void btnSchadenR4_Click(object sender, EventArgs e)
        {
            if (this.Height == 570)
            {
                this.Height = 530;
            }

            this.btnSchadenH4.Show();
            this.btnSchadenR3.Show();
            this.cmbSchaden5.Text = "";
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (cmdGeraete.Text == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!", "Felder-Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!chkZuruekgesetzt.Checked)
            {
                MessageBox.Show("Bitte erst das Gerät zurücksetzen.", "Zurücksetzen-Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbSchaden1.Text == ""  && cmbSchaden3.Text != "" )
                {
                    MessageBox.Show("Schäden bitte der Reihe nach eingeben.", "Reihenfolge-Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {  
                    string sqlAnfrage = "UPDATE Ausleihschein SET Schaden = @Schaden, [Rueckgabe-Datum] = @Rueckgabe WHERE Geraet ='" + cmdGeraete.Text + "' AND Schueler = '" + txtSchueler.Text + "'  AND [Rueckgabe-Datum] IS NULL "; 
                    OleDbConnection dbVerbindung = new OleDbConnection(_datenbankHelfer.DatenbankPfad);
                    string schaden = "";
                    string getSchadenMitKomma;
                    using (OleDbCommand dbBefehl = new OleDbCommand(sqlAnfrage, dbVerbindung))
                    {
                        dbVerbindung.Open();

                        string[] textBoxes = { txtSchaeden.Text, this.cmbSchaden1.Text, this.cmbSchaden2.Text, this.cmbSchaden3.Text, this.cmbSchaden4.Text, this.cmbSchaden5.Text, this.rtxtSchaden.Text };
                        getSchadenMitKomma = _datenbankHelfer.FuegeKommaHinzu(textBoxes, schaden);

                        dbBefehl.Parameters.AddWithValue("@Schaden", getSchadenMitKomma);
                        dbBefehl.Parameters.AddWithValue("@Rueckgabe", this.dtpRueckgabeDatum.Value.Date);
                        dbBefehl.ExecuteNonQuery();
                        dbVerbindung.Close();

                        MessageBox.Show("Die Rückgabe ist abgeschlossen!", "Rückgabe erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    _datenbankHelfer.SqlAktualisierungAnfrage(dbVerbindung, cmdGeraete, "IPads", "Status", "Modell", "Verfügbar");
                    _datenbankHelfer.SqlAktualisierungAnfrage(dbVerbindung, cmdGeraete, "IPads", "Schaden", "Modell", getSchadenMitKomma);
                }
            }
        }

        private void GetModellAusIPadsDb()
        {     
            string sqlAnfrage = "Select Ipads.Modell FROM Ipads INNER JOIN Klasse ON Klasse.Lehrer = Ipads.VerliehenVon WHERE Klasse.Lehrer = '" + _benutzer + "' AND Ipads.Status = \"Verliehen\" OR Klasse.Lehrer2 = '" + _benutzer + "' AND Ipads.Status = \"Verliehen\" ORDER BY Ipads.Modell";
            _datenbankHelfer.GetListenDatenAusDb(cmdGeraete, sqlAnfrage);
        }

        private void GetSchuelerAusAusleihscheinDb()
        {
            string sqlAnfrage = "SELECT Schueler FROM Ausleihschein Where Geraet  = '" + cmdGeraete.Text + "' AND [Rueckgabe-Datum] IS NULL";
            _datenbankHelfer.GetTextDatenAusDb(txtSchueler, sqlAnfrage);
        }

        private void GetSchadenAusIpadsDb()
        {
            string sqlAnfrage = "SELECT Schaden FROM Ipads WHERE Modell = '" + cmdGeraete.Text + "'";
            _datenbankHelfer.GetTextDatenAusDb(txtSchaeden, sqlAnfrage);
        }

        private void GetBeschreibungAusSchadeninDb()
        {
            string sqlAnfrage = "SELECT Beschreibung FROM Schaden ORDER BY Beschreibung;";
            _datenbankHelfer.GetListenDatenAusDb(cmbSchaden1, sqlAnfrage);
            _datenbankHelfer.GetListenDatenAusDb(cmbSchaden2, sqlAnfrage);
            _datenbankHelfer.GetListenDatenAusDb(cmbSchaden3, sqlAnfrage);
            _datenbankHelfer.GetListenDatenAusDb(cmbSchaden4, sqlAnfrage);
            _datenbankHelfer.GetListenDatenAusDb(cmbSchaden5, sqlAnfrage);
        }

        private void cmdGeraete_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSchuelerAusAusleihscheinDb();
            GetSchadenAusIpadsDb();
        }

        private void btnSonstige_Click(object sender, EventArgs e)
        {
           
            btnSonstigeZurueck.Show();
            btnSonstige.Hide();
            cmbSchaden1.Hide();
            cmbSchaden2.Hide();
            cmbSchaden3.Hide();
            cmbSchaden4.Hide();
            cmbSchaden5.Hide();
            btnSchadenH1.Hide();
            btnSchadenH2.Hide();
            btnSchadenH3.Hide();
            btnSchadenH4.Hide();
            btnSchadenR1.Hide();
            btnSchadenR2.Hide();
            btnSchadenR3.Hide();
            btnSchadenR4.Hide();
            rtxtSchaden.Show();

            this.Height = 450;
        }

        private void btnSonstigeZurueck_Click(object sender, EventArgs e)
        {
            this.Height = 410;

            btnSonstigeZurueck.Hide();
            btnSonstige.Show();
            cmbSchaden1.Show();
            cmbSchaden2.Show();
            cmbSchaden3.Show();
            cmbSchaden4.Show();
            cmbSchaden5.Show();
            btnSchadenH1.Show();
            btnSchadenH2.Show();
            btnSchadenH3.Show();
            btnSchadenH4.Show();
            btnSchadenR1.Show();
            btnSchadenR2.Show();
            btnSchadenR3.Show();
            btnSchadenR4.Show();
            rtxtSchaden.Hide();           
        }

        private void frmRueckgabe_MouseDown(object sender, MouseEventArgs e)
        {
            _ziehen = true;  
            _startpunkt = new Point(e.X, e.Y);
        }

        private void frmRueckgabe_MouseMove(object sender, MouseEventArgs e)
        {
            if (_ziehen)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startpunkt.X, p.Y - this._startpunkt.Y);
            }
        }

        private void frmRueckgabe_MouseUp(object sender, MouseEventArgs e)
        {
            _ziehen = false;
        }

        private void btnRueckgabeMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
