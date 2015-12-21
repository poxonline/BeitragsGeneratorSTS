using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeitragsgeneratorSTS2
{
    public partial class Auswahl : Form
    {
        public Auswahl()
        {
            InitializeComponent();
            version.Text = "Version: 0.4.0.1";
        }

        private void beenden_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
        //Wenn Form geschlossen wird
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Soll die Anwendung wirklich geschlossen werden?" + Environment.NewLine +
                                "Es wird danach die Zwischenablage geleert.",
                                "Anwendung schliessen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //Wenn Form geschlossen ist
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }
        //Aufruf Eine Anlage
        private void auswahl1_Click(object sender, EventArgs e)
        {
            EineAnlage Form2 = new EineAnlage();
            Form2.ShowDialog();
        }
        //Aufruf Fenster mehere Anlagen
        private void auswahl2_Click(object sender, EventArgs e)
        {
            MehrereAnlagen Form3 = new MehrereAnlagen();
            MessageBox.Show("Betaversion: Beim skalieren des Fensters treten noch Fehler auf!"+Environment.NewLine+"Ebenfalls sind die Auswahlmöglichkeiten der Region noch ohne Funktion und nur vorbereitet.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form3.ShowDialog();
        }
        //Aufruf erbauer austragen
        private void erbauer_Click(object sender, EventArgs e)
        {
            ErbauerAustragen Form4 = new ErbauerAustragen();
            Form4.ShowDialog();
        }
        //Aufruf Changelog
        private void changelog_Click(object sender, EventArgs e)
        {
            MessageBox.Show(//"Anlage Geändert Feld mach bei mehr als einer Zeile Automatisch eine Liste" + Environment.NewLine +
                            "Version 0.4.0.1:" + Environment.NewLine +
                            "-Verhinderung von Buchstabennutzung bei AIDs" + Environment.NewLine + Environment.NewLine +
                            "Version 0.4:" + Environment.NewLine +
                            "-\"Anlage ist Neubau\" bei Auswahl: \"Anlage vorabprüfung\" dazu" + Environment.NewLine +
                            "-Mehrere Anlagen gleichzeitig sind nun auch möglich"+ Environment.NewLine +
                            "-Neuer Aufbau des Programms, nicht mehr nur eine Eingabemaske"+Environment.NewLine+
                            "-Codeoptimierung" + Environment.NewLine + Environment.NewLine +
                            "Version 0.3.5:" + Environment.NewLine +
                            "-\"Anlage ist neubau\" bei Auswahl: \"Anlage sichtbar\" nun als Auswahl möglich" + Environment.NewLine +
                            "-Erbauer grund nun wieder mehrzeilig" + Environment.NewLine + Environment.NewLine +
                            "Version 0.3.4:" + Environment.NewLine +
                            "-Skalierbarkeit" + Environment.NewLine + Environment.NewLine +
                            "Version 0.3.3:" + Environment.NewLine +
                            "-kleinere Bugfixes" + Environment.NewLine +
                            "-Umbennung \"Dein Name\"" + Environment.NewLine +
                            "-Überraschungs-Feature" + Environment.NewLine + Environment.NewLine +
                            "Version 0.3.2:" + Environment.NewLine +
                            "-Beim Start wird nur die Formularauswahl angezeigt" + Environment.NewLine +
                            "-Einige Felder wurden umbenannt" + Environment.NewLine +
                            "-Formatierungen der Texte wurden angepasst" + Environment.NewLine +
                            "-Bei nicht aktivierten Checkboxen werden Felder deaktiviert" + Environment.NewLine + Environment.NewLine +
                            "Version 0.3.1:" + Environment.NewLine +
                            "-Fenstergröße angepasst" + Environment.NewLine +
                            "-Alle Auswahlmöglichkeiten haben nun die Funktion der Zwischenablage" + Environment.NewLine +
                            "-Zwischenablage wird bei Programmende geleert und ist selber leerbar" + Environment.NewLine +
                            "-neues User Menü" + Environment.NewLine +
                            "-Sicherheitsfrage vor beenden (Testweise)" + Environment.NewLine + Environment.NewLine +
                            "Version 0.3:" + Environment.NewLine +
                            "-Anlagen vorabprüfung möglich" + Environment.NewLine +
                            "-zur Eingabe unnötige Elemente werden ausgeblendet" + Environment.NewLine +
                            "-\"einmal\" aus Ausgabe entfernt" + Environment.NewLine + Environment.NewLine +
                            "Version 0.2:" + Environment.NewLine +
                            "-Text wird nach generierung in Zwischenablage kopiert" + Environment.NewLine +
                            "-Pflichtfelder werden angezeigt" + Environment.NewLine +
                            "-Ein 'AID:' in die Ausgabe gepackt" + Environment.NewLine +
                            "-Changelog hinzugefügt" + Environment.NewLine + Environment.NewLine +
                            "Version 0.1:" + Environment.NewLine +
                            "-Veröffentlichung der ersten Version",
                            "Changelog", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
