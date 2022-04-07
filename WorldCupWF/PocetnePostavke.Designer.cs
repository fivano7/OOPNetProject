
namespace WorldCupWF
{
    partial class PocetnePostavke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnePostavke));
            this.label1 = new System.Windows.Forms.Label();
            this.cbOdabirPrvenstva = new System.Windows.Forms.ComboBox();
            this.cbJezikAplikacije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOtvoriAplikaciju = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = Properties.Resources.PostavkeOdabirPrvenstva;
            // 
            // cbOdabirPrvenstva
            // 
            this.cbOdabirPrvenstva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdabirPrvenstva.FormattingEnabled = true;
            this.cbOdabirPrvenstva.Location = new System.Drawing.Point(31, 65);
            this.cbOdabirPrvenstva.Name = "cbOdabirPrvenstva";
            this.cbOdabirPrvenstva.Size = new System.Drawing.Size(526, 28);
            this.cbOdabirPrvenstva.TabIndex = 1;
            // 
            // cbJezikAplikacije
            // 
            this.cbJezikAplikacije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJezikAplikacije.FormattingEnabled = true;
            this.cbJezikAplikacije.Location = new System.Drawing.Point(31, 169);
            this.cbJezikAplikacije.Name = "cbJezikAplikacije";
            this.cbJezikAplikacije.Size = new System.Drawing.Size(526, 28);
            this.cbJezikAplikacije.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = Properties.Resources.PostavkeOdabirJezika;
            // 
            // btnOtvoriAplikaciju
            // 
            this.btnOtvoriAplikaciju.Location = new System.Drawing.Point(31, 242);
            this.btnOtvoriAplikaciju.Name = "btnOtvoriAplikaciju";
            this.btnOtvoriAplikaciju.Size = new System.Drawing.Size(526, 80);
            this.btnOtvoriAplikaciju.TabIndex = 4;
            this.btnOtvoriAplikaciju.Text = Properties.Resources.PocetnePostavkePrimjeniPostavkeBtn;
            this.btnOtvoriAplikaciju.UseVisualStyleBackColor = true;
            this.btnOtvoriAplikaciju.Click += new System.EventHandler(this.btnOtvoriAplikaciju_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slInfo
            // 
            this.slInfo.Name = "slInfo";
            this.slInfo.Size = new System.Drawing.Size(0, 15);
            // 
            // PocetnePostavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnOtvoriAplikaciju);
            this.Controls.Add(this.cbJezikAplikacije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOdabirPrvenstva);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PocetnePostavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Properties.Resources.PocetnePostavkeNaslov;
            this.Load += new System.EventHandler(this.PocetnePostavke_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOdabirPrvenstva;
        private System.Windows.Forms.ComboBox cbJezikAplikacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOtvoriAplikaciju;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slInfo;
    }
}

