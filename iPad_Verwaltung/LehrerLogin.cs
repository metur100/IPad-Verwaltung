using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using static iPad_Verwaltung.DatenbankHelfer;

namespace iPad_Verwaltung
{
    public partial class frmLehrerLogin : Form
    {
        private readonly DatenbankHelfer _datenbankHelfer = new DatenbankHelfer();
        private bool _ziehen;
        private Point _startpunkt = new Point(0, 0);

        public frmLehrerLogin()
        {
            InitializeComponent();
            txtKuerzel.KeyDown += txtKuerzel_KeyDown;
            txtKuerzel.TextChanged += txtKuerzel_TextChanged;
            pnlGeraete.MouseDown += new MouseEventHandler(frmLehrerLogin_MouseDown);
            pnlGeraete.MouseMove += new MouseEventHandler(frmLehrerLogin_MouseMove);
            pnlGeraete.MouseUp += new MouseEventHandler(frmLehrerLogin_MouseUp);
            this.MouseDown += new MouseEventHandler(frmLehrerLogin_MouseDown);
            this.MouseMove += new MouseEventHandler(frmLehrerLogin_MouseMove);
            this.MouseUp += new MouseEventHandler(frmLehrerLogin_MouseUp);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            using (OleDbConnection dbVerbindung = new OleDbConnection(_datenbankHelfer.DatenbankPfad))
            {
                if (txtKuerzel.Text == "")
                {
                    MessageBox.Show("Bitte Login Daten eingeben!", "Login error!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        dbVerbindung.Open();
                        string sqlAnfrage = "Select * FROM Klasse WHERE [Lehrer] = @Lehrer";
                        using (OleDbCommand dbBefehl = new OleDbCommand(sqlAnfrage, dbVerbindung))
                        {
                            dbBefehl.Parameters.AddWithValue("@Lehrer", txtKuerzel.Text);

                            using (OleDbDataReader dbLeser = dbBefehl.ExecuteReader())
                            {
                                if (dbLeser.HasRows)
                                {
                                    GlobaleVariablen.Anmeldung = txtKuerzel.Text;
                                    frmAuswahl f2 = new frmAuswahl();
                                    f2.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Falsche Anmeldungdaten! Versuchen Sie erneut!", "Anmeldung-Fehler!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtKuerzel.Clear();
                                }
                            }
                        }
                    }

                    catch (Exception ausnahme)
                    {
                        MessageBox.Show(ausnahme.Message);
                    }

                    dbVerbindung.Close();
                }
            }
        }
        private void txtKuerzel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }

            else if (e.KeyCode == Keys.Back)
            {
                if (txtKuerzel.Text.Length > 0)
                txtKuerzel.Text = txtKuerzel.Text.Remove(txtKuerzel.Text.Length - 1);
                txtKuerzel.SelectionStart = txtKuerzel.Text.Length;

            }
        }

        private void txtKuerzel_TextChanged(object sender, EventArgs e)
        {
            txtKuerzel.Text = txtKuerzel.Text.ToUpper();
            txtKuerzel.SelectionStart = txtKuerzel.Text.Length;

            if (txtKuerzel.Text.Length > 3)
            {
                txtKuerzel.Text = txtKuerzel.Text.Remove(3);
                txtKuerzel.SelectionStart = txtKuerzel.Text.Length;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            txtKuerzel.Clear();
            txtKuerzel.Select();
        }

        private void btnLoginSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLehrerLogin_Load(object sender, EventArgs e)
        {
            txtKuerzel.Select();
        }

        private void frmLehrerLogin_MouseDown(object sender, MouseEventArgs e)
        {
            _ziehen = true;  
            _startpunkt = new Point(e.X, e.Y);
        }

        private void frmLehrerLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (_ziehen)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startpunkt.X, p.Y - this._startpunkt.Y);
            }
        }

        private void frmLehrerLogin_MouseUp(object sender, MouseEventArgs e)
        {
            _ziehen = false;
        }

        private void btnLoginMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
