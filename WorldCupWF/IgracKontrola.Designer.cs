
namespace WorldCupWF
{
    partial class IgracKontrola
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IgracKontrola));
            this.pbIgrac = new System.Windows.Forms.PictureBox();
            this.lblPozicija = new System.Windows.Forms.TextBox();
            this.lblImeIgraca = new System.Windows.Forms.TextBox();
            this.lblBrojIgraca = new System.Windows.Forms.TextBox();
            this.lblOmiljeniIgrac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIgrac)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIgrac
            // 
            this.pbIgrac.Image = global::WorldCupWF.Properties.Resources.RandomIgrac;
            this.pbIgrac.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbIgrac.InitialImage")));
            this.pbIgrac.Location = new System.Drawing.Point(16, 36);
            this.pbIgrac.Name = "pbIgrac";
            this.pbIgrac.Size = new System.Drawing.Size(184, 191);
            this.pbIgrac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIgrac.TabIndex = 2;
            this.pbIgrac.TabStop = false;
            // 
            // lblPozicija
            // 
            this.lblPozicija.BackColor = System.Drawing.Color.Silver;
            this.lblPozicija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPozicija.Enabled = false;
            this.lblPozicija.ForeColor = System.Drawing.Color.Black;
            this.lblPozicija.Location = new System.Drawing.Point(0, 260);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(218, 19);
            this.lblPozicija.TabIndex = 5;
            this.lblPozicija.Text = "Veznjak";
            this.lblPozicija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblImeIgraca
            // 
            this.lblImeIgraca.BackColor = System.Drawing.Color.Silver;
            this.lblImeIgraca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblImeIgraca.Enabled = false;
            this.lblImeIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeIgraca.ForeColor = System.Drawing.Color.Black;
            this.lblImeIgraca.Location = new System.Drawing.Point(0, 235);
            this.lblImeIgraca.Name = "lblImeIgraca";
            this.lblImeIgraca.Size = new System.Drawing.Size(218, 19);
            this.lblImeIgraca.TabIndex = 6;
            this.lblImeIgraca.Text = "Luka Modrić";
            this.lblImeIgraca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBrojIgraca
            // 
            this.lblBrojIgraca.BackColor = System.Drawing.Color.Silver;
            this.lblBrojIgraca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBrojIgraca.Enabled = false;
            this.lblBrojIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojIgraca.ForeColor = System.Drawing.Color.Black;
            this.lblBrojIgraca.Location = new System.Drawing.Point(0, 8);
            this.lblBrojIgraca.Name = "lblBrojIgraca";
            this.lblBrojIgraca.Size = new System.Drawing.Size(218, 19);
            this.lblBrojIgraca.TabIndex = 7;
            this.lblBrojIgraca.Text = "10";
            this.lblBrojIgraca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOmiljeniIgrac
            // 
            this.lblOmiljeniIgrac.BackColor = System.Drawing.Color.Silver;
            this.lblOmiljeniIgrac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblOmiljeniIgrac.Enabled = false;
            this.lblOmiljeniIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmiljeniIgrac.ForeColor = System.Drawing.Color.Black;
            this.lblOmiljeniIgrac.Location = new System.Drawing.Point(139, 8);
            this.lblOmiljeniIgrac.Name = "lblOmiljeniIgrac";
            this.lblOmiljeniIgrac.Size = new System.Drawing.Size(61, 19);
            this.lblOmiljeniIgrac.TabIndex = 8;
            this.lblOmiljeniIgrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IgracKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lblOmiljeniIgrac);
            this.Controls.Add(this.lblBrojIgraca);
            this.Controls.Add(this.lblImeIgraca);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.pbIgrac);
            this.Name = "IgracKontrola";
            this.Size = new System.Drawing.Size(218, 287);
            ((System.ComponentModel.ISupportInitialize)(this.pbIgrac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbIgrac;
        private System.Windows.Forms.TextBox lblPozicija;
        private System.Windows.Forms.TextBox lblImeIgraca;
        private System.Windows.Forms.TextBox lblBrojIgraca;
        private System.Windows.Forms.TextBox lblOmiljeniIgrac;
    }
}
