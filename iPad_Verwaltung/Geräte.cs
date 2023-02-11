using System;
using System.Windows.Forms;
using System.Drawing;

namespace iPad_Verwaltung
{
    public partial class frmGeraete : Form
    {
        private readonly DatenbankHelfer _datenbankHelfer = new DatenbankHelfer();
        private bool _ziehen;
        private Point _startpunkt = new Point(0, 0);

        public frmGeraete()
        {
            InitializeComponent();
            pnlGeraete.MouseDown += new MouseEventHandler(frmGeraete_MouseDown);
            pnlGeraete.MouseMove += new MouseEventHandler(frmGeraete_MouseMove);
            pnlGeraete.MouseUp += new MouseEventHandler(frmGeraete_MouseUp);
            this.MouseDown += new MouseEventHandler(frmGeraete_MouseDown);
            this.MouseMove += new MouseEventHandler(frmGeraete_MouseMove);
            this.MouseUp += new MouseEventHandler(frmGeraete_MouseUp);
        }
        private void frmGeraete_Load(object sender, EventArgs e)
        {
            this.cmbGeraet.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Height = 115;

            LeseModelleAusIpadsDb();
        }

        private void btnGeraeteSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeraeteZurueck_Click(object sender, EventArgs e)
        {
            frmAuswahl f1 = new frmAuswahl();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void cmbGeraet_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Height = 175; 

            GetArtAusIpadsDb();
            GetStatusAusIpadsDb();
            GetMarkeAusIpadsDb();
            GetModelleAusIpadsDb();
            GetSpeicherAusIpadsDb();
            GetAnschaffungswertAusIpadsDb();
            GetGeliehenAnAusAusleihscheinDb();
            GetKlasseAusAusleihscheinDb();
            GetVerliehenAmAusAusleihscheinDb();
            GetVerliehenVomAusAusleihscheinDb();
            GetSchadenAusAusleihscheinDb();

            if (txtStatus.Text == "Verfügbar")
            {
                txtStatus.BackColor = Color.Green;
                this.Height = 465;
            }
            else
            {
                txtStatus.BackColor = Color.Firebrick;
                this.Height = 665;
            }
        }

        private void LeseModelleAusIpadsDb()
        {
            string sqlAnfrage = "SELECT Modell FROM Ipads ORDER BY Modell;";
            _datenbankHelfer.GetListenDatenAusDb(cmbGeraet, sqlAnfrage);
        }

        private void GetStatusAusIpadsDb()
        {
            string sqlAnfrage = "SELECT Status FROM Ipads WHERE Modell = '" + cmbGeraet.Text + "'";
            _datenbankHelfer.GetTextDatenAusDb(txtStatus, sqlAnfrage);
        }

        private void GetArtAusIpadsDb()
        {
            string sqlAnfrage = "SELECT Art FROM Ipads WHERE Modell ='" + cmbGeraet.Text + "'";
            _datenbankHelfer.GetTextDatenAusDb(txtArt2, sqlAnfrage);
        }

        private void GetMarkeAusIpadsDb()
        {
            string sqlAnfrage = "SELECT Marke FROM Ipads WHERE Modell ='" + cmbGeraet.Text + "'";
            _datenbankHelfer.GetTextDatenAusDb(txtMarke, sqlAnfrage);
        }

        private void GetModelleAusIpadsDb()
        {
            string sqlAnfrage = "SELECT Modell FROM Ipads WHERE Modell ='" + cmbGeraet.Text + "'";
            _datenbankHelfer.GetTextDatenAusDb(txtModell, sqlAnfrage);
        }

        private void GetSpeicherAusIpadsDb()
        {
            string sqlAnfrage = "SELECT Speicher FROM Ipads WHERE Modell ='" + cmbGeraet.Text + "'";
            _datenbankHelfer.GetNummerDatenAusDb(txtSpeicher, sqlAnfrage);
        }

        private void GetAnschaffungswertAusIpadsDb()
        {
            string sqlAnfrage = "SELECT Anschaffungswert FROM Ipads WHERE Modell ='" + cmbGeraet.Text + "'";
            _datenbankHelfer.GetNummerDatenAusDb(txtWert, sqlAnfrage);
        }

        private void GetGeliehenAnAusAusleihscheinDb()
        {
            string sqlAnfrage = "SELECT Schueler FROM Ausleihschein WHERE Geraet ='" + cmbGeraet.Text + "' AND [Rueckgabe-Datum] IS NULL ";
            _datenbankHelfer.GetTextDatenAusDb(txtGeliehen2, sqlAnfrage);
        }

        private void GetKlasseAusAusleihscheinDb()
        {
            string sqlAnfrage = "SELECT Klasse FROM Ausleihschein WHERE Geraet ='" + cmbGeraet.Text + "' AND [Rueckgabe-Datum] IS NULL ";
            _datenbankHelfer.GetTextDatenAusDb(txtKlasse, sqlAnfrage);
        }

        private void GetVerliehenAmAusAusleihscheinDb()
        {
            string sqlAnfrage = "SELECT [Ausleih-Datum] FROM Ausleihschein WHERE Geraet ='" + cmbGeraet.Text + "' AND [Rueckgabe-Datum] IS NULL ";
            _datenbankHelfer.GetDatumUndUhrzeitAusDb(txtDatum, sqlAnfrage);
        }

        private void GetVerliehenVomAusAusleihscheinDb()
        {
            string sqlAnfrage = "SELECT Lehrer FROM Ausleihschein WHERE Geraet ='" + cmbGeraet.Text + "' AND [Rueckgabe-Datum] IS NULL ";
            _datenbankHelfer.GetTextDatenAusDb(txtVerliehen, sqlAnfrage);
        }

        private void GetSchadenAusAusleihscheinDb()
        {
            string sqlAnfrage = "SELECT Schaden FROM IPads WHERE Modell ='" + cmbGeraet.Text + "'";
            _datenbankHelfer.GetTextDatenAusDb(txtSchaeden, sqlAnfrage);
        }

        private void frmGeraete_MouseDown(object sender, MouseEventArgs e)
        {
            _ziehen = true;  
            _startpunkt = new Point(e.X, e.Y);
        }

        private void frmGeraete_MouseMove(object sender, MouseEventArgs e)
        {
            if (_ziehen)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startpunkt.X, p.Y - this._startpunkt.Y);
            }
        }

        private void frmGeraete_MouseUp(object sender, MouseEventArgs e)
        {
            _ziehen = false;
        }

        private void btnGeraeteMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
