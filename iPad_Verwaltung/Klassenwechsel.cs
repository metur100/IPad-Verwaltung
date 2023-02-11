using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;

namespace iPad_Verwaltung
{
    public partial class frmKlassenwechsel : Form
    {
        private readonly DatenbankHelfer _datenbankHelfer = new DatenbankHelfer();
        private bool _ziehen;
        private Point _startpunkt = new Point(0, 0);

        public frmKlassenwechsel()
        {
            InitializeComponent();
            pnlWechsel.MouseDown += new MouseEventHandler(frmKlassenwechsel_MouseDown);
            pnlWechsel.MouseMove += new MouseEventHandler(frmKlassenwechsel_MouseMove);
            pnlWechsel.MouseUp += new MouseEventHandler(frmKlassenwechsel_MouseUp);
            this.MouseDown += new MouseEventHandler(frmKlassenwechsel_MouseDown);
            this.MouseMove += new MouseEventHandler(frmKlassenwechsel_MouseMove);
            this.MouseUp += new MouseEventHandler(frmKlassenwechsel_MouseUp);
        }

        private void frmDatenbank_Load(object sender, EventArgs e)
        {
            this.cmbKlasse.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSchueler.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbKlasseNeu.DropDownStyle = ComboBoxStyle.DropDownList;
            btnWechseln.Hide();
            this.Height = 115;

            GetBezeichnungAusKlasseDb(cmbKlasse);
        }

        private void btnKlassenwechselSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKlassenwechselZurueck_Click(object sender, EventArgs e)
        {
            frmAuswahl f1 = new frmAuswahl();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void cmbKlasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKlasseNeu.Items.Clear();
            cmbSchueler.Items.Clear();
            this.Height = 265;
            GetBezeichnungAusKlasseDb(cmbKlasseNeu);
            GetNameAusSchuelerDb();
            btnWechseln.Show();
        }

        private void GetBezeichnungAusKlasseDb(ComboBox comboBox)
        {
            string sqlAnfrage = "SELECT Bezeichnung FROM Klasse ORDER BY Bezeichnung;";
            _datenbankHelfer.GetListenDatenAusDb(comboBox, sqlAnfrage);
        }

        private void GetNameAusSchuelerDb()
        {
            string sqlAnfrage = "SELECT Vorname + ' ' + Nachname FROM Schueler WHERE Klasse = '" + cmbKlasse.Text + "'";
            _datenbankHelfer.GetListenDatenAusDb(cmbSchueler, sqlAnfrage);
        }

        private void btnWechseln_Click(object sender, EventArgs e)
        {
            string[] teile = cmbSchueler.Text.Split(' ');
            string vorname = teile[0];
            string nachname = teile[1];

            DialogResult ergebnis = MessageBox.Show("Sind Sie Sicher, dass Sie die Klasse für den Schüler " + vorname + " " + nachname + " wechseln möchten?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ergebnis == DialogResult.Yes)
            {
                string sqlAnfrage = "UPDATE Schueler SET Klasse = @Klasse WHERE Klasse ='" + cmbKlasse.Text + "' AND Vorname ='" + vorname + "' AND Nachname ='" + nachname + "'";
                OleDbConnection dbVerbindung = new OleDbConnection(_datenbankHelfer.DatenbankPfad);
                using (OleDbCommand dbBefehl = new OleDbCommand(sqlAnfrage, dbVerbindung))
                {
                    dbVerbindung.Open();
                    dbBefehl.Parameters.AddWithValue("@Klasse", cmbKlasseNeu.Text);
                    dbBefehl.ExecuteNonQuery();
                    dbVerbindung.Close();

                    MessageBox.Show(vorname + " " + nachname + " wurde zu Klasse " + cmbKlasseNeu.Text + " gewechselt!", "Klasse erfolgreich gewechselt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is ComboBox)
                    {
                        (c as ComboBox).SelectedIndex = -1;
                    }
                }
            }

            this.Refresh();

        }
        private void frmKlassenwechsel_MouseDown(object sender, MouseEventArgs e)
        {
            _ziehen = true;
            _startpunkt = new Point(e.X, e.Y);
        }

        private void frmKlassenwechsel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_ziehen)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startpunkt.X, p.Y - this._startpunkt.Y);
            }
        }

        private void frmKlassenwechsel_MouseUp(object sender, MouseEventArgs e)
        {
            _ziehen = false;
        }

        private void btnWechselMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
