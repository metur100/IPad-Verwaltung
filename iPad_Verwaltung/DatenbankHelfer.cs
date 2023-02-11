using System.Data.OleDb;
using System.Windows.Forms;

namespace iPad_Verwaltung
{
    public class DatenbankHelfer
    {
        public string DatenbankPfad = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= G:\\Coding\\Visual Studio\\Main\\iPad_Verwaltung\\IPad.accdb"; // D:\\iPad_Verwaltung\\IPad.accdb"; 

        public void GetListenDatenAusDb(ComboBox comboBox, string sqlAnfrage)
        {
            OleDbConnection dbVerbindung = new OleDbConnection(DatenbankPfad);
            dbVerbindung.Open();
            OleDbCommand dbBefehl = dbVerbindung.CreateCommand();
            dbBefehl.Connection = dbVerbindung;
            dbBefehl.CommandText = sqlAnfrage;
            OleDbDataReader dbLeser = dbBefehl.ExecuteReader();

            while (dbLeser.Read())
            {
                comboBox.Items.Add(dbLeser.GetString(0));
            }
            dbLeser.Close();
            dbVerbindung.Close();
        }

        public void GetTextDatenAusDb(TextBox textBox, string sqlAnfrage)
        {
            OleDbConnection dbVerbindung = new OleDbConnection(DatenbankPfad);
            dbVerbindung.Open();
            OleDbCommand dbBefehl = dbVerbindung.CreateCommand();
            dbBefehl.Connection = dbVerbindung;
            dbBefehl.CommandText = sqlAnfrage;
            OleDbDataReader dbLeser = dbBefehl.ExecuteReader();

            while (dbLeser.Read())
            {
                if (!dbLeser.IsDBNull(0))
                {
                    textBox.Text = dbLeser.GetString(0);
                }
                else
                {
                    textBox.Text = string.Empty;
                }
            }
            dbLeser.Close();
            dbVerbindung.Close();
        }

        public void GetNummerDatenAusDb(TextBox textBox, string sqlAnfrage)
        {
            OleDbConnection dbVerbindung = new OleDbConnection(DatenbankPfad);
            dbVerbindung.Open();
            OleDbCommand dbBefehl = dbVerbindung.CreateCommand();
            dbBefehl.Connection = dbVerbindung;
            dbBefehl.CommandText = sqlAnfrage;
            OleDbDataReader dbLeser = dbBefehl.ExecuteReader();

            while (dbLeser.Read())
            {
                if (!dbLeser.IsDBNull(0))
                {
                    textBox.Text = dbLeser.GetInt32(0).ToString();
                }
                else
                {
                    textBox.Text = string.Empty;
                }
            }
            dbLeser.Close();
            dbVerbindung.Close();
        }

        public void GetDatumUndUhrzeitAusDb(TextBox textBox, string sqlAnfrage)
        {
            OleDbConnection dbVerbindung = new OleDbConnection(DatenbankPfad);
            dbVerbindung.Open();
            OleDbCommand dbBefehl = dbVerbindung.CreateCommand();
            dbBefehl.Connection = dbVerbindung;
            dbBefehl.CommandText = sqlAnfrage;
            OleDbDataReader dbLeser = dbBefehl.ExecuteReader();

            while (dbLeser.Read())
            {
                if (!dbLeser.IsDBNull(0))
                {
                    textBox.Text = dbLeser.GetDateTime(0).ToString("dd.MM.yyyy");
                }
                else
                {
                    textBox.Text = string.Empty;
                }
            }
            dbLeser.Close();
            dbVerbindung.Close();
        }

        public string GetStringWertAusDb(string wert, string sqlAnfrage)
        {
            OleDbConnection dbVerbindung = new OleDbConnection(DatenbankPfad);
            dbVerbindung.Open();
            OleDbCommand dbBefehl = dbVerbindung.CreateCommand();
            dbBefehl.Connection = dbVerbindung;
            dbBefehl.CommandText = sqlAnfrage;
            OleDbDataReader dbLeser = dbBefehl.ExecuteReader();

            while (dbLeser.Read())
            {
                if (!dbLeser.IsDBNull(0))
                {
                    wert = dbLeser.GetString(0);
                }
                else
                {
                    wert = string.Empty;
                }
            }
            dbLeser.Close();
            dbVerbindung.Close();

            return wert;
        }

        public void SqlAktualisierungAnfrage(OleDbConnection dbVerbindung, ComboBox comboBox, string tabelle, string reihe, string zustand, string werte)
        {
            string sqlSchadenAnfrage = $"UPDATE {tabelle} SET {reihe} = @{reihe} WHERE {zustand} ='" + comboBox.Text + "'";
            using (OleDbCommand dbBefehl = new OleDbCommand(sqlSchadenAnfrage, dbVerbindung))
            {
                dbVerbindung.Open();
                dbBefehl.Parameters.AddWithValue($"@{reihe}", werte);
                dbBefehl.ExecuteNonQuery();
                dbVerbindung.Close();
            }
        }

        public string FuegeKommaHinzu(string[] textBoxes, string schaden)
        {
            bool letztesNichtLeer = false;
            char letztesZeichen = ' ';

            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (!string.IsNullOrEmpty(textBoxes[i]))
                {
                    if (!letztesNichtLeer)
                    {
                        letztesNichtLeer = true;
                    }
                    else
                    {
                        schaden += ", ";
                        letztesZeichen = ',';
                    }
                    if (letztesZeichen != ',')
                    {
                        schaden += "";
                    }
                    schaden += textBoxes[i];
                    letztesZeichen = textBoxes[i][textBoxes[i].Length - 1];
                }
                else
                {
                    schaden += "";
                }
            }

            return schaden;
        }

        public static class GlobaleVariablen
        {
            public static string Anmeldung;
            public static bool AnmeldungGeoeffnet;
        }
    }
}

