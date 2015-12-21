namespace BeitragsgeneratorSTS2
{
    partial class EineAnlage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EineAnlage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswahlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptauswahlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mehrereAnlagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erbauerAustragenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zwischenablageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zwischenablageLeerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beitragNeuInZwischenablageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.neubau = new System.Windows.Forms.RadioButton();
            this.auswahl = new System.Windows.Forms.ComboBox();
            this.aid = new System.Windows.Forms.MaskedTextBox();
            this.anlagenname = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gemacht = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.geaendertcheck = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ausgabe = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.zwischenablageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auswahlToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // auswahlToolStripMenuItem
            // 
            this.auswahlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hauptauswahlToolStripMenuItem,
            this.mehrereAnlagenToolStripMenuItem,
            this.erbauerAustragenToolStripMenuItem});
            this.auswahlToolStripMenuItem.Name = "auswahlToolStripMenuItem";
            this.auswahlToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.auswahlToolStripMenuItem.Text = "Auswahl";
            // 
            // hauptauswahlToolStripMenuItem
            // 
            this.hauptauswahlToolStripMenuItem.Name = "hauptauswahlToolStripMenuItem";
            this.hauptauswahlToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.hauptauswahlToolStripMenuItem.Text = "Hauptauswahl";
            this.hauptauswahlToolStripMenuItem.Click += new System.EventHandler(this.hauptauswahlToolStripMenuItem_Click);
            // 
            // mehrereAnlagenToolStripMenuItem
            // 
            this.mehrereAnlagenToolStripMenuItem.Name = "mehrereAnlagenToolStripMenuItem";
            this.mehrereAnlagenToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.mehrereAnlagenToolStripMenuItem.Text = "Mehrere Anlagen";
            this.mehrereAnlagenToolStripMenuItem.Click += new System.EventHandler(this.mehrereAnlagenToolStripMenuItem_Click);
            // 
            // erbauerAustragenToolStripMenuItem
            // 
            this.erbauerAustragenToolStripMenuItem.Name = "erbauerAustragenToolStripMenuItem";
            this.erbauerAustragenToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.erbauerAustragenToolStripMenuItem.Text = "Erbauer austragen";
            this.erbauerAustragenToolStripMenuItem.Click += new System.EventHandler(this.erbauerAustragenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // zwischenablageToolStripMenuItem
            // 
            this.zwischenablageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zwischenablageLeerenToolStripMenuItem,
            this.beitragNeuInZwischenablageToolStripMenuItem});
            this.zwischenablageToolStripMenuItem.Name = "zwischenablageToolStripMenuItem";
            this.zwischenablageToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.zwischenablageToolStripMenuItem.Text = "Zwischenablage";
            // 
            // zwischenablageLeerenToolStripMenuItem
            // 
            this.zwischenablageLeerenToolStripMenuItem.Name = "zwischenablageLeerenToolStripMenuItem";
            this.zwischenablageLeerenToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.zwischenablageLeerenToolStripMenuItem.Text = "Zwischenablage leeren";
            this.zwischenablageLeerenToolStripMenuItem.Click += new System.EventHandler(this.zwischenablageLeerenToolStripMenuItem_Click);
            // 
            // beitragNeuInZwischenablageToolStripMenuItem
            // 
            this.beitragNeuInZwischenablageToolStripMenuItem.Name = "beitragNeuInZwischenablageToolStripMenuItem";
            this.beitragNeuInZwischenablageToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.beitragNeuInZwischenablageToolStripMenuItem.Text = "Beitrag neu in Zwischenablage";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ausgabe, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.91354F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.08646F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 408);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 360);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auswahl und Eingabe";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.neubau, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.auswahl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.aid, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.anlagenname, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.gemacht, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.geaendertcheck, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.name, 1, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(353, 341);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // neubau
            // 
            this.neubau.AutoSize = true;
            this.neubau.Location = new System.Drawing.Point(179, 82);
            this.neubau.Name = "neubau";
            this.neubau.Size = new System.Drawing.Size(112, 17);
            this.neubau.TabIndex = 24;
            this.neubau.TabStop = true;
            this.neubau.Text = "Anlage ist Neubau";
            this.neubau.UseVisualStyleBackColor = true;
            this.neubau.Visible = false;
            this.neubau.CheckedChanged += new System.EventHandler(this.geaendertcheck_CheckedChanged);
            // 
            // auswahl
            // 
            this.auswahl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auswahl.FormattingEnabled = true;
            this.auswahl.Items.AddRange(new object[] {
            "Anlage sichtbar",
            "Anlage updaten",
            "Anlage vorabprüfen"});
            this.auswahl.Location = new System.Drawing.Point(179, 3);
            this.auswahl.Name = "auswahl";
            this.auswahl.Size = new System.Drawing.Size(171, 21);
            this.auswahl.TabIndex = 0;
            this.auswahl.SelectedValueChanged += new System.EventHandler(this.auswahl_SelectedValueChanged);
            // 
            // aid
            // 
            this.aid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aid.Location = new System.Drawing.Point(179, 30);
            this.aid.Name = "aid";
            this.aid.Size = new System.Drawing.Size(171, 20);
            this.aid.TabIndex = 18;
            this.aid.Visible = false;
            // 
            // anlagenname
            // 
            this.anlagenname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anlagenname.Location = new System.Drawing.Point(179, 56);
            this.anlagenname.Name = "anlagenname";
            this.anlagenname.Size = new System.Drawing.Size(171, 20);
            this.anlagenname.TabIndex = 19;
            this.anlagenname.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "AID:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Anlagenname:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Geändert/Gemacht:";
            this.label3.Visible = false;
            // 
            // gemacht
            // 
            this.gemacht.AcceptsReturn = true;
            this.gemacht.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gemacht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gemacht.Location = new System.Drawing.Point(179, 105);
            this.gemacht.Multiline = true;
            this.gemacht.Name = "gemacht";
            this.gemacht.ReadOnly = true;
            this.gemacht.Size = new System.Drawing.Size(171, 32);
            this.gemacht.TabIndex = 22;
            this.gemacht.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Formulartyp:";
            // 
            // geaendertcheck
            // 
            this.geaendertcheck.AutoSize = true;
            this.geaendertcheck.Location = new System.Drawing.Point(3, 82);
            this.geaendertcheck.Name = "geaendertcheck";
            this.geaendertcheck.Size = new System.Drawing.Size(128, 17);
            this.geaendertcheck.TabIndex = 23;
            this.geaendertcheck.TabStop = true;
            this.geaendertcheck.Text = "Änderungen angeben";
            this.geaendertcheck.UseVisualStyleBackColor = true;
            this.geaendertcheck.Visible = false;
            this.geaendertcheck.CheckedChanged += new System.EventHandler(this.geaendertcheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dein Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(179, 143);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "* Kennzeichnte ein Pflichtfeld";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(368, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Beitrag generieren + Zwischenablage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ausgabe
            // 
            this.ausgabe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ausgabe.Location = new System.Drawing.Point(368, 3);
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.ReadOnly = true;
            this.ausgabe.Size = new System.Drawing.Size(359, 360);
            this.ausgabe.TabIndex = 16;
            this.ausgabe.Text = "";
            // 
            // EineAnlage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 447);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EineAnlage";
            this.Text = "Beitragsgenerator STS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EineAnlage_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auswahlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptauswahlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zwischenablageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zwischenablageLeerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beitragNeuInZwischenablageToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton neubau;
        private System.Windows.Forms.ComboBox auswahl;
        private System.Windows.Forms.MaskedTextBox aid;
        private System.Windows.Forms.MaskedTextBox anlagenname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gemacht;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton geaendertcheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem mehrereAnlagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erbauerAustragenToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RichTextBox ausgabe;
    }
}