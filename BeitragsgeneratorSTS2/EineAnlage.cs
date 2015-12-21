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
    public partial class EineAnlage : Form
    {
        public EineAnlage()
        {
            InitializeComponent();
            gemacht.Cursor = Cursors.No;
        }
        //Klick auf Button zum Erzeugen der Texte, hier so getippt und nicht objekt orientiert
        private void button1_Click(object sender, EventArgs e)
        {
            //Anlage sichtbar setzen
            if (auswahl.Text == "Anlage sichtbar")
            {
                if (aid.Text == "")
                {
                    MessageBox.Show("Bitte gib eine AID ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (anlagenname.Text == "")
                    {
                        MessageBox.Show("Bitte gib den Anlagennamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (geaendertcheck.Checked == true)
                        {
                            if (gemacht.Text != "")
                            {
                                ausgabe.Text = "Hallo zusammen," +
                                                Environment.NewLine +
                                                Environment.NewLine + "bitte die Anlage [b]" + anlagenname.Text + " (AID: " + aid.Text + ")[/b] sichtbar setzen." +
                                                Environment.NewLine +
                                                Environment.NewLine + "Es wurde folgendes gemacht:" +
                                                Environment.NewLine + gemacht.Text +
                                                Environment.NewLine +
                                                Environment.NewLine +
                                                "Danke und Gruß" +
                                                Environment.NewLine +
                                                name.Text;
                            }
                            else
                                MessageBox.Show("Bitte gib an was gemacht wurde.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ausgabe.Text = "Hallo zusammen," +
                                            Environment.NewLine +
                                            Environment.NewLine + "bitte die Anlage [b]" + anlagenname.Text + " (AID: " + aid.Text + ")[/b] sichtbar setzen." +
                                            Environment.NewLine +
                                            Environment.NewLine + "Die Anlage ist ein Neubau." +
                                            Environment.NewLine +
                                            Environment.NewLine +
                                            "Danke und Gruß" +
                                            Environment.NewLine +
                                            name.Text;
                        }

                        System.Windows.Forms.Clipboard.SetDataObject(ausgabe.Text, false);
                    }
                }
            }

            //Anlage updaten
            if (auswahl.Text == "Anlage updaten")
            {
                if (aid.Text == "")
                {
                    MessageBox.Show("Bitte gib eine AID ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (anlagenname.Text == "")
                    {
                        MessageBox.Show("Bitte gib den Anlagennamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (geaendertcheck.Checked == true)
                        {
                            if (gemacht.Text != "")
                            {
                                ausgabe.Text = "Hallo zusammen," +
                                                Environment.NewLine +
                                                Environment.NewLine + "bitte die Anlage [b]" + anlagenname.Text + " (AID: " + aid.Text + ")[/b] updaten." +
                                                Environment.NewLine +
                                                Environment.NewLine + "Es wurde folgendes geändert:" +
                                                Environment.NewLine + gemacht.Text +
                                                Environment.NewLine +
                                                Environment.NewLine +
                                                "Danke und Gruß" +
                                                Environment.NewLine +
                                                name.Text;
                            }
                            else
                                MessageBox.Show("Bitte gib an was gemacht wurde.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ausgabe.Text = "Hallo zusammen," +
                                            Environment.NewLine +
                                            Environment.NewLine + "bitte die Anlage [b]" + anlagenname.Text + " (AID: " + aid.Text + ")[/b] updaten." +
                                            Environment.NewLine +
                                            Environment.NewLine +
                                            "Danke und Gruß" +
                                            Environment.NewLine +
                                            name.Text;
                        }

                        System.Windows.Forms.Clipboard.SetDataObject(ausgabe.Text, false);
                    }
                }
            }

            //Anlage vorabprüfen
            if (auswahl.Text == "Anlage vorabprüfen")
            {
                if (aid.Text == "")
                {
                    MessageBox.Show("Bitte gib eine AID ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (anlagenname.Text == "")
                    {
                        MessageBox.Show("Bitte gib den Anlagennamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (geaendertcheck.Checked == true)
                        {
                            if (gemacht.Text != "")
                            {
                                ausgabe.Text = "Hallo zusammen," +
                                                Environment.NewLine +
                                                Environment.NewLine + "bitte die Anlage [b]" + anlagenname.Text + " (AID: " + aid.Text + ")[/b] zur späteren Sichtbarsetzung vorabprüfen." +
                                                Environment.NewLine +
                                                Environment.NewLine + "Es wurde folgendes gemacht:" +
                                                Environment.NewLine + gemacht.Text +
                                                Environment.NewLine +
                                                Environment.NewLine +
                                                "Danke und Gruß" +
                                                Environment.NewLine +
                                                name.Text;
                            }
                            else
                                MessageBox.Show("Bitte gib an was gemacht wurde.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ausgabe.Text = "Hallo zusammen," +
                                            Environment.NewLine +
                                            Environment.NewLine + "bitte die Anlage [b]" + anlagenname.Text + " (AID: " + aid.Text + ")[/b] zur späteren Sichtbarsetzung vorabprüfen." +
                                            Environment.NewLine +
                                            Environment.NewLine +
                                            "Danke und Gruß" +
                                            Environment.NewLine +
                                            name.Text;
                        }

                        System.Windows.Forms.Clipboard.SetDataObject(ausgabe.Text, false);

                    }
                }
            }
        }
        private void auswahl_SelectedValueChanged(object sender, EventArgs e)
        {
            if (auswahl.Text == "Anlage sichtbar")
                AnlageSichtbar();
            if (auswahl.Text == "Anlage updaten")
                AnlagenAktion();
            if (auswahl.Text == "Anlage vorabprüfen")
                AnlageSichtbar();
        }
        public void AnlageSichtbar()
        {
            label1.Visible = true;
            label1.Text = "AID:*";
            aid.Visible = true;

            label2.Visible = true;
            label2.Text = "Anlagenname:*";
            anlagenname.Visible = true;

            geaendertcheck.Visible = true;
            label3.Visible = true;
            gemacht.Visible = true;
            neubau.Visible = true;

            name.Visible = true;
        }
        public void AnlagenAktion()
        {
            label1.Visible = true;
            label1.Text = "AID:*";
            aid.Visible = true;

            label2.Visible = true;
            label2.Text = "Anlagenname:*";
            anlagenname.Visible = true;

            geaendertcheck.Visible = true;
            geaendertcheck.Checked = true;
            label3.Visible = true;
            gemacht.Visible = true;

            neubau.Visible = false;

            label4.Visible = true;
            name.Visible = true;
        }

        private void geaendertcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!geaendertcheck.Checked)
            {
                gemacht.ReadOnly = true;
                gemacht.Cursor = Cursors.No;
            }
            else
            {
                gemacht.ReadOnly = false;
                gemacht.Cursor = Cursors.IBeam;
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void mehrereAnlagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MehrereAnlagen Form3 = new MehrereAnlagen();
            Form3.ShowDialog();
        }

        private void hauptauswahlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();           
        }

        private void zwischenablageLeerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }
        //Auswahl in Menüleiste Erbauer austragen lassen
        private void erbauerAustragenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
            this.Hide();
            ErbauerAustragen Form4 = new ErbauerAustragen();
            Form4.ShowDialog();
        }
        //Wenn Form geschlossen wird...
        private void EineAnlage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Auskommentiert da dann auch bei ändern der Auswahl das Menü zur Abfrage kommt
            //System.Windows.Forms.Application.Exit();
        }
    }
}
