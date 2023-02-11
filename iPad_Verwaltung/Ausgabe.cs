using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using static iPad_Verwaltung.DatenbankHelfer;

namespace iPad_Verwaltung
{
    public partial class frmAusgabe : Form
    {
        private readonly DatenbankHelfer _datenbankHelfer = new DatenbankHelfer();
        private readonly string _benutzer = GlobaleVariablen.Anmeldung;
        private bool _ziehen;
        private Point _startpunkt = new Point(0, 0);

        public frmAusgabe()
        {
            InitializeComponent();
            pnlAusgabe.MouseDown += new MouseEventHandler(frmAusgabe_MouseDown);
            pnlAusgabe.MouseMove += new MouseEventHandler(frmAusgabe_MouseMove);
            pnlAusgabe.MouseUp += new MouseEventHandler(frmAusgabe_MouseUp);
            this.MouseDown += new MouseEventHandler(frmAusgabe_MouseDown);
            this.MouseMove += new MouseEventHandler(frmAusgabe_MouseMove);
            this.MouseUp += new MouseEventHandler(frmAusgabe_MouseUp);
        }

        private void btnAusgabeZurueck_Click_1(object sender, EventArgs e)
        {
            frmAuswahl f1 = new frmAuswahl();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void btnAusgabeSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (UeberprufeObSchulerBereitsIPadHat()) return;

            if (cmbKlasse.Text == "" || cmbSchueler.Text == "" || cmdGeraet.Text == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen", "Felder-Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!chkUnterschrift.Checked)
            {
                MessageBox.Show("Bitte erst die Unterschrift des Schüler einholen!", "Unterschrift-Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sqlAnfrage = "INSERT INTO Ausleihschein ([Ausleih-Datum], [Rueckgabe-Datum], [Schueler], " +
                    "[Schaden], [Unterschrift], [Klasse], [Lehrer], [Geraet]) Values (?,?,?,?,?,?,?,?)";

                OleDbConnection dbVerbindung = new OleDbConnection(_datenbankHelfer.DatenbankPfad);
                using (OleDbCommand dbBefehl = new OleDbCommand(sqlAnfrage, dbVerbindung))
                {
                    dbVerbindung.Open();
                    dbBefehl.Parameters.AddWithValue("@Ausleih-Datum", ausgabeDatum.Value.Date);
                    dbBefehl.Parameters.AddWithValue("@Rueckgabe-Datum", DBNull.Value);
                    dbBefehl.Parameters.AddWithValue("@Schueler", cmbSchueler.Text);
                    dbBefehl.Parameters.AddWithValue("@Schaden", string.Empty);
                    dbBefehl.Parameters.AddWithValue("@Unterschrift", chkUnterschrift.Checked);
                    dbBefehl.Parameters.AddWithValue("@Klasse", cmbKlasse.Text);
                    dbBefehl.Parameters.AddWithValue("@Lehrer", _benutzer);
                    dbBefehl.Parameters.AddWithValue("@Geraet", cmdGeraet.Text);
                    dbBefehl.ExecuteNonQuery();
                    dbVerbindung.Close();
                }

                _datenbankHelfer.SqlAktualisierungAnfrage(dbVerbindung, cmdGeraet, "IPads", "Status", "Modell", "Verliehen");
                _datenbankHelfer.SqlAktualisierungAnfrage(dbVerbindung, cmdGeraet, "IPads", "VerliehenVon", "Modell", _benutzer);
                _datenbankHelfer.SqlAktualisierungAnfrage(dbVerbindung, cmdGeraet, "IPads", "Lehrer2", "Modell", GetLehrer2AusKlasseDb());

                MessageBox.Show("Das Gerät " + cmdGeraet.Text + " wurde an den Schüler " + cmbSchueler.Text + " verliehen. \nAusleihschein erstellt! \nBitte in die Schülerakte einheften.", "Ausgabe erflogreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAusgabe_Load(object sender, EventArgs e)
        {
            this.cmbKlasse.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSchueler.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmdGeraet.DropDownStyle = ComboBoxStyle.DropDownList;

            GetBezeichnungAusKlasseDb();
            GetModelleAusIpadsDb();
        }

        private bool UeberprufeObSchulerBereitsIPadHat()
        {
            string sqlAnfrage = "SELECT [Rueckgabe-Datum] FROM Ausleihschein WHERE Schueler = @schueler AND [Rueckgabe-Datum] IS NULL";

            OleDbConnection dbVerbindung = new OleDbConnection(_datenbankHelfer.DatenbankPfad);
            using (OleDbCommand dbBefehl = new OleDbCommand(sqlAnfrage, dbVerbindung))
            {
                if (dbVerbindung.State != ConnectionState.Open)
                    dbVerbindung.Open();
                dbBefehl.Parameters.AddWithValue("@schueler", cmbSchueler.Text);
                OleDbDataReader reader = dbBefehl.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Dieser Schüler hat bereits ein iPad ausgeliehen und hat es noch nicht zurückgegeben.", "Ausgabe-Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }

                reader.Close();
                dbVerbindung.Close();

                return false;
            }
        }

        private void cmbKlasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSchueler.Items.Clear();
            GetVornameAndNachnameAusSchuelerDb();
        }

        private void GetBezeichnungAusKlasseDb()
        {
            string sqlAnfrage = "SELECT Bezeichnung FROM Klasse WHERE Lehrer ='" + _benutzer + "' OR Lehrer2 = '" + _benutzer + "'";
            _datenbankHelfer.GetListenDatenAusDb(cmbKlasse, sqlAnfrage);
        }

        private void GetVornameAndNachnameAusSchuelerDb()
        {
            string sqlAnfrage = "SELECT Vorname + ' ' + Nachname FROM Schueler WHERE Klasse ='" + cmbKlasse.Text + "'";
            _datenbankHelfer.GetListenDatenAusDb(cmbSchueler, sqlAnfrage);
        }

        private void GetModelleAusIpadsDb()
        {
            string sqlAnfrage = "SELECT Modell FROM Ipads WHERE Status = \"Verfügbar\" ORDER BY Modell;";
            _datenbankHelfer.GetListenDatenAusDb(cmdGeraet, sqlAnfrage);
        }

        private string GetLehrer2AusKlasseDb()
        {
            string sqlAnfrage = "SELECT Lehrer2 FROM Klasse WHERE Lehrer ='" + _benutzer + "'";
            string value = _datenbankHelfer.GetStringWertAusDb(_benutzer, sqlAnfrage);

            return value;
        }

        private void frmAusgabe_MouseDown(object sender, MouseEventArgs e)
        {
            _ziehen = true;  
            _startpunkt = new Point(e.X, e.Y);
        }

        private void frmAusgabe_MouseMove(object sender, MouseEventArgs e)
        {
            if (_ziehen)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startpunkt.X, p.Y - this._startpunkt.Y);
            }
        }

        private void frmAusgabe_MouseUp(object sender, MouseEventArgs e)
        {
            _ziehen = false;
        }

        private void btnAusgabeMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
