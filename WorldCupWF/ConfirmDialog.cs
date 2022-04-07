using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupWF
{
    public partial class ConfirmDialog : Form
    {
        public static DialogResult ShowDialog(IWin32Window owner, string naslov)
        {
          
            using (var confirmDialog = new ConfirmDialog(naslov))
            {
                return confirmDialog.ShowDialog(owner);
            }
        }
        public ConfirmDialog(string naslov)
        {
            InitializeComponent();
            this.Text = naslov;
        }

        private void ConfirmDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnOdustani_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnPotvrdi_Click(sender, e);
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
