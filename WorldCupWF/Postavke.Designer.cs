
namespace WorldCupWF
{
    partial class Postavke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postavke));
            this.btnPrimjeniPostavke = new System.Windows.Forms.Button();
            this.cbJezikAplikacije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOdabirPrvenstva = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrimjeniPostavke
            // 
            this.btnPrimjeniPostavke.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnPrimjeniPostavke.Location = new System.Drawing.Point(31, 242);
            this.btnPrimjeniPostavke.Name = "btnPrimjeniPostavke";
            this.btnPrimjeniPostavke.Size = new System.Drawing.Size(526, 80);
            this.btnPrimjeniPostavke.TabIndex = 9;
            this.btnPrimjeniPostavke.Text = global::WorldCupWF.Properties.Resources.PostavkePrimjeniPostavkeBtn;
            this.btnPrimjeniPostavke.UseVisualStyleBackColor = true;
            this.btnPrimjeniPostavke.Click += new System.EventHandler(this.btnPrimjeniPostavke_Click);
            // 
            // cbJezikAplikacije
            // 
            this.cbJezikAplikacije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJezikAplikacije.FormattingEnabled = true;
            this.cbJezikAplikacije.Location = new System.Drawing.Point(31, 169);
            this.cbJezikAplikacije.Name = "cbJezikAplikacije";
            this.cbJezikAplikacije.Size = new System.Drawing.Size(526, 28);
            this.cbJezikAplikacije.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Odaberite jezik aplikacije:";
            // 
            // cbOdabirPrvenstva
            // 
            this.cbOdabirPrvenstva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdabirPrvenstva.FormattingEnabled = true;
            this.cbOdabirPrvenstva.Location = new System.Drawing.Point(31, 65);
            this.cbOdabirPrvenstva.Name = "cbOdabirPrvenstva";
            this.cbOdabirPrvenstva.Size = new System.Drawing.Size(526, 28);
            this.cbOdabirPrvenstva.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Odabir prvenstva:";
            // 
            // Postavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 344);
            this.Controls.Add(this.btnPrimjeniPostavke);
            this.Controls.Add(this.cbJezikAplikacije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOdabirPrvenstva);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Postavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Postavke";
            this.Load += new System.EventHandler(this.Postavke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimjeniPostavke;
        private System.Windows.Forms.ComboBox cbJezikAplikacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOdabirPrvenstva;
        private System.Windows.Forms.Label label1;
    }
}