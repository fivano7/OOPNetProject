
namespace WorldCupWF
{
    partial class StatistikaIgraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistikaIgraca));
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.listaSlika = new System.Windows.Forms.ImageList(this.components);
            this.btnIspisi = new System.Windows.Forms.Button();
            this.lvReprezentacija = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            this.printPreviewDialog.Visible = false;
            // 
            // listaSlika
            // 
            this.listaSlika.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaSlika.ImageStream")));
            this.listaSlika.TransparentColor = System.Drawing.Color.Transparent;
            this.listaSlika.Images.SetKeyName(0, "RandomIgrac.png");
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(277, 853);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(246, 70);
            this.btnIspisi.TabIndex = 6;
            this.btnIspisi.Text = global::WorldCupWF.Properties.Resources.StatistikaGledateljaIspisi;
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // lvReprezentacija
            // 
            this.lvReprezentacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvReprezentacija.HideSelection = false;
            this.lvReprezentacija.Location = new System.Drawing.Point(10, 12);
            this.lvReprezentacija.Name = "lvReprezentacija";
            this.lvReprezentacija.Size = new System.Drawing.Size(781, 825);
            this.lvReprezentacija.SmallImageList = this.listaSlika;
            this.lvReprezentacija.TabIndex = 5;
            this.lvReprezentacija.UseCompatibleStateImageBehavior = false;
            this.lvReprezentacija.View = System.Windows.Forms.View.Details;
            this.lvReprezentacija.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvReprezentacija_ColumnClick);
            // 
            // StatistikaIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 935);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.lvReprezentacija);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatistikaIgraca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistika igrača";
            this.Load += new System.EventHandler(this.StatistikaIgraca_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ImageList listaSlika;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.ListView lvReprezentacija;
    }
}