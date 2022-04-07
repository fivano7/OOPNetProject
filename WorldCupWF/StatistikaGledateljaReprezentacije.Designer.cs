
namespace WorldCupWF
{
    partial class StatistikaGledateljaReprezentacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistikaGledateljaReprezentacije));
            this.lvIgraci = new System.Windows.Forms.ListView();
            this.lvColumnLokacija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvColumnPosjetitelja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvColumnDomacin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvColumnGost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIspisi = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvIgraci
            // 
            this.lvIgraci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvColumnLokacija,
            this.lvColumnPosjetitelja,
            this.lvColumnDomacin,
            this.lvColumnGost});
            this.lvIgraci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvIgraci.HideSelection = false;
            this.lvIgraci.Location = new System.Drawing.Point(12, 12);
            this.lvIgraci.Name = "lvIgraci";
            this.lvIgraci.Size = new System.Drawing.Size(781, 272);
            this.lvIgraci.TabIndex = 1;
            this.lvIgraci.UseCompatibleStateImageBehavior = false;
            this.lvIgraci.View = System.Windows.Forms.View.Details;
            this.lvIgraci.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvIgraci_ColumnClick);
            // 
            // lvColumnLokacija
            // 
            this.lvColumnLokacija.Text = global::WorldCupWF.Properties.Resources.StatistikaGledateljaLokacija;
            this.lvColumnLokacija.Width = 118;
            // 
            // lvColumnPosjetitelja
            // 
            this.lvColumnPosjetitelja.Text = global::WorldCupWF.Properties.Resources.StatistikaGledateljaBrojPosjetitelja;
            this.lvColumnPosjetitelja.Width = 119;
            // 
            // lvColumnDomacin
            // 
            this.lvColumnDomacin.Text = global::WorldCupWF.Properties.Resources.StatistikaGledateljaDomacin;
            this.lvColumnDomacin.Width = 140;
            // 
            // lvColumnGost
            // 
            this.lvColumnGost.Text = global::WorldCupWF.Properties.Resources.StatistikaGledateljaGost;
            this.lvColumnGost.Width = 140;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(279, 304);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(246, 70);
            this.btnIspisi.TabIndex = 2;
            this.btnIspisi.Text = global::WorldCupWF.Properties.Resources.StatistikaGledateljaIspisi;
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // printDocument
            // 
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.UseAntiAlias = true;
            this.printPreviewDialog.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 15);
            // 
            // StatistikaGledateljaReprezentacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 422);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.lvIgraci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatistikaGledateljaReprezentacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistika gledatelja po utakmici";
            this.Load += new System.EventHandler(this.StatistikaReprezentacije_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvIgraci;
        private System.Windows.Forms.ColumnHeader lvColumnLokacija;
        private System.Windows.Forms.ColumnHeader lvColumnPosjetitelja;
        private System.Windows.Forms.ColumnHeader lvColumnDomacin;
        private System.Windows.Forms.ColumnHeader lvColumnGost;
        private System.Windows.Forms.Button btnIspisi;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
    }
}