
namespace WorldCupWF
{
    partial class OdabirReprezentacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdabirReprezentacije));
            this.cbOmiljenaReprezentacija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdaberiReprezentaciju = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOmiljenaReprezentacija
            // 
            this.cbOmiljenaReprezentacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOmiljenaReprezentacija.FormattingEnabled = true;
            this.cbOmiljenaReprezentacija.Location = new System.Drawing.Point(31, 65);
            this.cbOmiljenaReprezentacija.Name = "cbOmiljenaReprezentacija";
            this.cbOmiljenaReprezentacija.Size = new System.Drawing.Size(526, 28);
            this.cbOmiljenaReprezentacija.TabIndex = 3;
            this.cbOmiljenaReprezentacija.Tag = "CRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = Properties.Resources.OdabirReprezentacijeOmiljena;
            // 
            // btnOdaberiReprezentaciju
            // 
            this.btnOdaberiReprezentaciju.Location = new System.Drawing.Point(31, 135);
            this.btnOdaberiReprezentaciju.Name = "btnOdaberiReprezentaciju";
            this.btnOdaberiReprezentaciju.Size = new System.Drawing.Size(526, 80);
            this.btnOdaberiReprezentaciju.TabIndex = 5;
            this.btnOdaberiReprezentaciju.Text = Properties.Resources.OdabirReprezentacijeOdaberiOmiljenu;
            this.btnOdaberiReprezentaciju.UseVisualStyleBackColor = true;
            this.btnOdaberiReprezentaciju.Click += new System.EventHandler(this.btnOdaberiReprezentaciju_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 252);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 28);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slInfo
            // 
            this.slInfo.Name = "slInfo";
            this.slInfo.Size = new System.Drawing.Size(0, 21);
            // 
            // OdabirReprezentacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 280);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnOdaberiReprezentaciju);
            this.Controls.Add(this.cbOmiljenaReprezentacija);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OdabirReprezentacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Properties.Resources.OdabirReprezentacijeNaslov;
            this.Load += new System.EventHandler(this.OdabirReprezentacije_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOmiljenaReprezentacija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaberiReprezentaciju;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slInfo;
    }
}