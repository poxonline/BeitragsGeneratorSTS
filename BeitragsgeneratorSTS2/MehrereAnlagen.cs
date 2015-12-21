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
    public partial class MehrereAnlagen : Form
    {
        public MehrereAnlagen()
        {
            InitializeComponent();  
        }

        //Instanziieren der Objekte
        Anlage Anlage0 = new Anlage();
        Anlage Anlage1 = new Anlage();
        Anlage Anlage2 = new Anlage();
        Anlage Anlage3 = new Anlage();
        Anlage Anlage4 = new Anlage();
        //Erstellen des AnlagenArrays
        Anlage[] AnlagenArray = new Anlage[5];
             
        public void MehrereAnlagen_Load(object sender, EventArgs e)
        {
            //Objekte den Arrays Zuordnen
            AnlagenArray[0] = Anlage0;
            AnlagenArray[1] = Anlage1;
            AnlagenArray[2] = Anlage2;
            AnlagenArray[3] = Anlage3;
            AnlagenArray[4] = Anlage4;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void hauptauswahlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void eineAnlageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EineAnlage Form2 = new EineAnlage();
            Form2.ShowDialog();
        }

        private void zwischenablageLeerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }

        private void beitragNeuInZwischenablageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(ausgabebox.Text, false);
        }

        private void erbauerAustragenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
            this.Hide();
            ErbauerAustragen Form4 = new ErbauerAustragen();
            Form4.ShowDialog();
        }

        private void MehrereAnlagen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Auskommentiert aus gleichen Gründen wie bei EineAnlage.cs
            //System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int azAnlagen = Convert.ToInt16(anzahlanlagen.Value);
            switch (azAnlagen)
            {
                case 2:
                    Anlage0Einlesen();
                    Anlage1Einlesen();
                    break;
                case 3:
                    Anlage0Einlesen();
                    Anlage1Einlesen();
                    Anlage2Einlesen();
                    break;
                case 4:
                    Anlage0Einlesen();
                    Anlage1Einlesen();
                    Anlage2Einlesen();
                    Anlage3Einlesen();
                    break;
                case 5:
                    Anlage0Einlesen();
                    Anlage1Einlesen();
                    Anlage2Einlesen();
                    Anlage3Einlesen();
                    Anlage4Einlesen();
                    break;
            }

            if (auswahlArt.Text=="Anlagen sichtbar")
            {
                string liste="";
                for(int i=0;i<Convert.ToInt16(anzahlanlagen.Value);i++)
                {
                    liste = liste+AusgabeNeubau(AnlagenArray[i]);
                }
                ausgabebox.Text="Hallo zusammen,"+Environment.NewLine+Environment.NewLine+"bitte einmal folgende Anlagen sichtbar setzen:"+Environment.NewLine+liste+Environment.NewLine+Environment.NewLine+"Danke und Gruß"+Environment.NewLine+grußname.Text;
            }
            if (auswahlArt.Text == "Anlagen updaten")
            {
                string liste="";
                for (int i = 0; i < Convert.ToInt16(anzahlanlagen.Value); i++)
                {
                    liste = liste + AusgabeUpdaten(AnlagenArray[i]);
                }
                ausgabebox.Text = "Hallo zusammen," + Environment.NewLine + Environment.NewLine + "bitte einmal folgende Anlagen updaten:" + Environment.NewLine + liste + Environment.NewLine + Environment.NewLine + "Danke und Gruß" + Environment.NewLine + grußname.Text;
            }
            if (auswahlArt.Text == "Anlagen vorabprüfen")
            {
                string liste = "";
                for (int i = 0; i < Convert.ToInt16(anzahlanlagen.Value); i++)
                {
                    liste = liste + AusgabeNeubau(AnlagenArray[i]);
                }
                ausgabebox.Text = "Hallo zusammen," + Environment.NewLine + Environment.NewLine + "bitte einmal folgende Anlagen vorabprüfen:" + Environment.NewLine + liste + Environment.NewLine + Environment.NewLine + "Danke und Gruß" + Environment.NewLine + grußname.Text;
            }
            Clipboard.SetDataObject(ausgabebox.Text, false);
        }
        /// <summary>
        /// Prüft ob Anlage als Neubau zu bewerten ist oder gibt die Änderungen die gemacht wurden aus als Listenpunkt
        /// </summary>
        /// <param name="Anlagen">Ein Objekt der Klasse Anlagen muss übergeben werden</param>
        /// <returns>Einen String mit dem Textinhalt des Ergenbnisses der Prüfung</returns>
        public string AusgabeNeubau(Anlage Anlagen)
        {
            string neubau;
            string text;
            if(Anlagen.neubau==true)
            {
                neubau = "Diese Anlage ist ein nebau.";
            }
            else
            {
                neubau= "Das wurde gemacht:"+Environment.NewLine+Anlagen.aenderungen;
            }

            text = "- [b]" + Anlagen.name + " (AID=" + Anlagen.aid + ")[/b]" + Environment.NewLine + neubau+Environment.NewLine;

            return text;       
        }
        /// <summary>
        /// Gibt Ändeurngen für die Übergebe Anlage aus in Auflistungsform
        /// </summary>
        /// <param name="Anlagen">Anlageobjekt</param>
        /// <returns>Anlagen Name+AID+Änderungsliste</returns>
        public string AusgabeUpdaten(Anlage Anlagen)
        {
            string neubau;
            string text;
            neubau = "Das wurde gemacht:" + Environment.NewLine + Anlagen.aenderungen;
            text = "- [b]" + Anlagen.name + " (AID=" + Anlagen.aid + ")[/b]" + Environment.NewLine + neubau + Environment.NewLine;

            return text; 
        }
        /// <summary>
        /// Werte aus Einagebmenü dort Anlage 1 einlesen
        /// </summary>
        public void Anlage0Einlesen()
        {
            try
            {
                Anlage0.aid = Convert.ToInt32(taid1.Text);
            }
            catch
            {
                MessageBox.Show("Bitte eine gültige Zahl eingeben!", "Fehler in Anlage 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Anlage0.name = tname1.Text;
            Anlage0.region = auswahl1.Text;
            if (auswahl1.Checked)
                Anlage0.neubau=true;
            if (auswahl2.Checked)
                Anlage0.neubau=false;
            Anlage0.aenderungen = aenderungen1.Text;
        }
        /// <summary>
        /// Werte aus Einagebmenü dort Anlage 2 einlesen
        /// </summary>
        public void Anlage1Einlesen()
        {
            try
            { 
            Anlage1.aid = Convert.ToInt32(taid2.Text);
            }
            catch
            {
                MessageBox.Show("Bitte eine gültige Zahl eingeben!", "Fehler in Anlage 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Anlage1.name = tname2.Text;
            Anlage1.region = auswahl2.Text;
            if (auswahl3.Checked)
                Anlage1.neubau = true;
            if (auswahl4.Checked)
                Anlage1.neubau = false;
            Anlage1.aenderungen = aenderungen2.Text;
        }
        /// <summary>
        /// Werte aus Einagebmenü dort Anlage 3 einlesen
        /// </summary>
        public void Anlage2Einlesen()
        {
            try
            {
                Anlage2.aid = Convert.ToInt32(taid3.Text);
            }
            catch
            {
                MessageBox.Show("Bitte eine gültige Zahl eingeben!", "Fehler in Anlage 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Anlage2.name = tname3.Text;
            Anlage2.region = auswahl3.Text;
            if (auswahl5.Checked)
                Anlage2.neubau = true;
            if (auswahl6.Checked)
                Anlage2.neubau = false;
            Anlage2.aenderungen = aenderungen3.Text;
        }
        /// <summary>
        /// Werte aus Einagebmenü dort Anlage 4 einlesen
        /// </summary>
        public void Anlage3Einlesen()
        {
            try
            { 
            Anlage3.aid = Convert.ToInt32(taid4.Text);
            }
            catch
            {
                MessageBox.Show("Bitte eine gültige Zahl eingeben!", "Fehler in Anlage 4", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Anlage3.name = tname4.Text;
            Anlage3.region = auswahl4.Text;
            if (auswahl7.Checked)
                Anlage3.neubau = true;
            if (auswahl8.Checked)
                Anlage3.neubau = false;
            Anlage3.aenderungen = aenderungen4.Text;
        }
        /// <summary>
        /// Werte aus Einagebmenü dort Anlage 5 einlesen
        /// </summary>
        public void Anlage4Einlesen()
        {
            try
            { 
            Anlage4.aid = Convert.ToInt32(taid5.Text);
            }
            catch
            {
                MessageBox.Show("Bitte eine gültige Zahl eingeben!", "Fehler in Anlage 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Anlage4.name = tname5.Text;
            Anlage4.region = auswahl5.Text;
            if (auswahl9.Checked)
                Anlage4.neubau = true;
            if (auswahl10.Checked)
                Anlage4.neubau = false;
            Anlage4.aenderungen = aenderungen5.Text;
        }
        //Prüfen ob Anlagen updaten ausgewäht wurde und wegen Sinnhaftigkeit hier den Button "Anlage neubau" unsichtbar setzen und Änderung aktivieren
        private void auswahlArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(auswahlArt.Text=="Anlagen updaten")
            {
                auswahl1.Visible = false;
                auswahl3.Visible = false;
                auswahl5.Visible = false;
                auswahl7.Visible = false;
                auswahl9.Visible = false;
                auswahl2.Checked = true;
                auswahl4.Checked = true;
                auswahl6.Checked = true;
                auswahl8.Checked = true;
                auswahl10.Checked = true;
            }
            else
            {
                auswahl1.Visible = true;
                auswahl3.Visible = true;
                auswahl5.Visible = true;
                auswahl7.Visible = true;
                auswahl9.Visible = true;
            }
        }
    }
}
