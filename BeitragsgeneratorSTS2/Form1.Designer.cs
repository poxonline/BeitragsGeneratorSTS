namespace BeitragsgeneratorSTS2
{
    partial class Auswahl
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auswahl));
            this.auswahl1 = new System.Windows.Forms.Button();
            this.auswahl2 = new System.Windows.Forms.Button();
            this.beenden = new System.Windows.Forms.Button();
            this.changelog = new System.Windows.Forms.Button();
            this.erbauer = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // auswahl1
            // 
            this.auswahl1.Location = new System.Drawing.Point(31, 12);
            this.auswahl1.Name = "auswahl1";
            this.auswahl1.Size = new System.Drawing.Size(141, 23);
            this.auswahl1.TabIndex = 0;
            this.auswahl1.Text = "Eine Anlage";
            this.auswahl1.UseVisualStyleBackColor = true;
            this.auswahl1.Click += new System.EventHandler(this.auswahl1_Click);
            // 
            // auswahl2
            // 
            this.auswahl2.Location = new System.Drawing.Point(206, 12);
            this.auswahl2.Name = "auswahl2";
            this.auswahl2.Size = new System.Drawing.Size(141, 23);
            this.auswahl2.TabIndex = 1;
            this.auswahl2.Text = "Mehere Anlagen";
            this.auswahl2.UseVisualStyleBackColor = true;
            this.auswahl2.Click += new System.EventHandler(this.auswahl2_Click);
            // 
            // beenden
            // 
            this.beenden.Location = new System.Drawing.Point(119, 78);
            this.beenden.Name = "beenden";
            this.beenden.Size = new System.Drawing.Size(141, 23);
            this.beenden.TabIndex = 2;
            this.beenden.Text = "Beenden";
            this.beenden.UseVisualStyleBackColor = true;
            this.beenden.Click += new System.EventHandler(this.beenden_Click);
            // 
            // changelog
            // 
            this.changelog.Location = new System.Drawing.Point(206, 49);
            this.changelog.Name = "changelog";
            this.changelog.Size = new System.Drawing.Size(141, 23);
            this.changelog.TabIndex = 3;
            this.changelog.Text = "Changelog";
            this.changelog.UseVisualStyleBackColor = true;
            this.changelog.Click += new System.EventHandler(this.changelog_Click);
            // 
            // erbauer
            // 
            this.erbauer.Location = new System.Drawing.Point(31, 49);
            this.erbauer.Name = "erbauer";
            this.erbauer.Size = new System.Drawing.Size(141, 23);
            this.erbauer.TabIndex = 4;
            this.erbauer.Text = "Erbauer austragen lassen";
            this.erbauer.UseVisualStyleBackColor = true;
            this.erbauer.Click += new System.EventHandler(this.erbauer_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Beitragsgenerator STS";
            this.notifyIcon1.BalloonTipTitle = "Beitragsgenerator STS";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Beitragsgenerator STS";
            this.notifyIcon1.Visible = true;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(281, 85);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(10, 13);
            this.version.TabIndex = 5;
            this.version.Text = "-";
            // 
            // Auswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 110);
            this.Controls.Add(this.version);
            this.Controls.Add(this.erbauer);
            this.Controls.Add(this.changelog);
            this.Controls.Add(this.beenden);
            this.Controls.Add(this.auswahl2);
            this.Controls.Add(this.auswahl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auswahl";
            this.Text = "Beitragsgenerator STS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button auswahl1;
        private System.Windows.Forms.Button auswahl2;
        private System.Windows.Forms.Button beenden;
        private System.Windows.Forms.Button changelog;
        private System.Windows.Forms.Button erbauer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label version;
    }
}

