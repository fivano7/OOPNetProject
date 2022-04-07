
namespace WorldCupWF
{
    partial class OdabirOmiljenihIgraca
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdabirOmiljenihIgraca));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIgraci = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUtakmica = new System.Windows.Forms.ToolStripMenuItem();
            this.flpOmiljeniIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpOstaliIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsDodajPremjesti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajSlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premjestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.cmsDodajPremjesti.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postavkeToolStripMenuItem,
            this.rangListeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1647, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.postavkeToolStripMenuItem.Text = global::WorldCupWF.Properties.Resources.OdabirOmiljenihPostavke;
            this.postavkeToolStripMenuItem.Click += new System.EventHandler(this.postavkeToolStripMenuItem_Click);
            // 
            // rangListeToolStripMenuItem
            // 
            this.rangListeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIgraci,
            this.tsUtakmica});
            this.rangListeToolStripMenuItem.Name = "rangListeToolStripMenuItem";
            this.rangListeToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.rangListeToolStripMenuItem.Text = global::WorldCupWF.Properties.Resources.OdabirOmiljenihStatistika;
            // 
            // tsIgraci
            // 
            this.tsIgraci.Name = "tsIgraci";
            this.tsIgraci.Size = new System.Drawing.Size(289, 34);
            this.tsIgraci.Text = global::WorldCupWF.Properties.Resources.OdabirOmiljenihStatistikaIgraca;
            this.tsIgraci.Click += new System.EventHandler(this.tsIgraci_Click);
            // 
            // tsUtakmica
            // 
            this.tsUtakmica.Name = "tsUtakmica";
            this.tsUtakmica.Size = new System.Drawing.Size(289, 34);
            this.tsUtakmica.Text = global::WorldCupWF.Properties.Resources.OdabirOmiljenihStatistikaGledatelja;
            this.tsUtakmica.Click += new System.EventHandler(this.tsUtakmica_Click);
            // 
            // flpOmiljeniIgraci
            // 
            this.flpOmiljeniIgraci.AllowDrop = true;
            this.flpOmiljeniIgraci.Location = new System.Drawing.Point(12, 76);
            this.flpOmiljeniIgraci.Name = "flpOmiljeniIgraci";
            this.flpOmiljeniIgraci.Size = new System.Drawing.Size(226, 917);
            this.flpOmiljeniIgraci.TabIndex = 1;
            this.flpOmiljeniIgraci.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpOmiljeniIgraci_DragDrop);
            this.flpOmiljeniIgraci.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpOmiljeniIgraci_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Omiljeni igrači";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ostali igrači";
            // 
            // flpOstaliIgraci
            // 
            this.flpOstaliIgraci.AllowDrop = true;
            this.flpOstaliIgraci.AutoScroll = true;
            this.flpOstaliIgraci.Location = new System.Drawing.Point(265, 76);
            this.flpOstaliIgraci.Name = "flpOstaliIgraci";
            this.flpOstaliIgraci.Size = new System.Drawing.Size(1370, 917);
            this.flpOstaliIgraci.TabIndex = 3;
            this.flpOstaliIgraci.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpOstaliIgraci_DragDrop);
            this.flpOstaliIgraci.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpOstaliIgraci_DragEnter);
            // 
            // cmsDodajPremjesti
            // 
            this.cmsDodajPremjesti.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsDodajPremjesti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajSlikuToolStripMenuItem,
            this.premjestiToolStripMenuItem});
            this.cmsDodajPremjesti.Name = "cmsDodajPremjesti";
            this.cmsDodajPremjesti.Size = new System.Drawing.Size(173, 68);
            this.cmsDodajPremjesti.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDodajPremjesti_Opening);
            // 
            // dodajSlikuToolStripMenuItem
            // 
            this.dodajSlikuToolStripMenuItem.Name = "dodajSlikuToolStripMenuItem";
            this.dodajSlikuToolStripMenuItem.Size = new System.Drawing.Size(172, 32);
            this.dodajSlikuToolStripMenuItem.Text = global::WorldCupWF.Properties.Resources.OdabirOmiljenihDodajSliku;
            this.dodajSlikuToolStripMenuItem.Click += new System.EventHandler(this.dodajSlikuToolStripMenuItem_Click);
            // 
            // premjestiToolStripMenuItem
            // 
            this.premjestiToolStripMenuItem.Name = "premjestiToolStripMenuItem";
            this.premjestiToolStripMenuItem.Size = new System.Drawing.Size(172, 32);
            this.premjestiToolStripMenuItem.Text = global::WorldCupWF.Properties.Resources.OdabirOmiljenihPremjesti;
            this.premjestiToolStripMenuItem.Click += new System.EventHandler(this.premjestiToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 1002);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1647, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 15);
            // 
            // OdabirOmiljenihIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 1024);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpOstaliIgraci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpOmiljeniIgraci);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OdabirOmiljenihIgraca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odabir omiljenih igrača";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OdabirOmiljenihIgraca_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsDodajPremjesti.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem postavkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsIgraci;
        private System.Windows.Forms.ToolStripMenuItem tsUtakmica;
        private System.Windows.Forms.FlowLayoutPanel flpOmiljeniIgraci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpOstaliIgraci;
        private System.Windows.Forms.ContextMenuStrip cmsDodajPremjesti;
        private System.Windows.Forms.ToolStripMenuItem dodajSlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premjestiToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
    }
}