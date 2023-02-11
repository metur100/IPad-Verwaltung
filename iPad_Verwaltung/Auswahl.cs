using System;
using System.Windows.Forms;
using System.Drawing;
using static iPad_Verwaltung.DatenbankHelfer;

namespace iPad_Verwaltung
{
    public partial class frmAuswahl : Form
    {
        private readonly string _benutzer = GlobaleVariablen.Anmeldung;
        private bool _ziehen;
        private Point _startpunkt = new Point(0, 0);

        public frmAuswahl()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(frmAuswahl_MouseDown);
            this.MouseMove += new MouseEventHandler(frmAuswahl_MouseMove);
            this.MouseUp += new MouseEventHandler(frmAuswahl_MouseUp);
        }

        private void btnAuswahlSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAusgabe_Click(object sender, EventArgs e)
        {
            frmAusgabe f2 = new frmAusgabe();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
        private void btnRueckgabe_Click_1(object sender, EventArgs e)
        {
            frmRueckgabe f3 = new frmRueckgabe();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void btnGeraete_Click_1(object sender, EventArgs e)
        {
            frmGeraete f4 = new frmGeraete();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void btnDatenbank_Click(object sender, EventArgs e)
        {
            frmKlassenwechsel f5 = new frmKlassenwechsel();
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }

        private void frmAuswahl_Load(object sender, EventArgs e)
        {
            lblLogin.Text = lblLogin.Text + " " + _benutzer;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLehrerLogin f6 = new frmLehrerLogin();
            f6.Show();
        }

        private void frmAuswahl_MouseDown(object sender, MouseEventArgs e)
        {
            _ziehen = true; 
            _startpunkt = new Point(e.X, e.Y);
        }

        private void frmAuswahl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_ziehen)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startpunkt.X, p.Y - this._startpunkt.Y);
            }
        }

        private void frmAuswahl_MouseUp(object sender, MouseEventArgs e)
        {
            _ziehen = false;
        }

        private void btnAuswahlMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
