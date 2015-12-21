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
    public partial class ErbauerAustragen : Form
    {
        public ErbauerAustragen()
        {
            InitializeComponent();
            abfrage2.Checked = true;
            grundangabe.Cursor = Cursors.No;
        }
        bool grundangeben = false;
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (erbauername.Text=="")
                MessageBox.Show("Bitte einen Erbauernamen eingeben!","Fehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                if(grundangeben==true)
                {
                    if(grundangeben==true&&grundangabe.Text=="")
                    {  
                        MessageBox.Show("Bitte den Grund eintragen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ausgabe.Text="Hallo zusammen,"+Environment.NewLine+Environment.NewLine+"bitte einmal den Erbauer "+erbauername.Text+" austragen."+Environment.NewLine+"Dies hat folgenden Grund:"+Environment.NewLine+grundangabe.Text+Environment.NewLine+Environment.NewLine+"Danke und Gruß"+grußname.Text;
                    }
                }
                else
                    ausgabe.Text = "Hallo zusammen," + Environment.NewLine + Environment.NewLine + "bitte einmal den Erbauer " + erbauername.Text + " austragen." + Environment.NewLine + Environment.NewLine + "Danke und Gruß" + grußname.Text;
                System.Windows.Forms.Clipboard.SetDataObject(ausgabe.Text, false);
            }
        }

        private void abfrage1_CheckedChanged(object sender, EventArgs e)
        {
            if (abfrage1.Checked)
            {
                grundangabe.ReadOnly = false;
                grundangeben = true;
                grundangabe.Cursor = Cursors.Default;
            }
            else
            {
                grundangabe.ReadOnly = true;
                grundangeben = false;
                grundangabe.Cursor = Cursors.No;
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void hauptauswahlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auswahl Form1 = new Auswahl();
            Form1.Show();
        }

        private void eineAnlageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EineAnlage Form2 = new EineAnlage();
            Form2.Show();
        }

        private void mehrereAnlagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MehrereAnlagen Form3 = new MehrereAnlagen();
            Form3.Show();
        }

        private void zwischenablageLeerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }

        private void beitragNeuInZwischenablageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(ausgabe.Text, false);
        }
    }
}
