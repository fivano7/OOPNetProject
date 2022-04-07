using PodatkovniSloj;
using PodatkovniSloj.Models;
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
    public partial class StatistikaGledateljaReprezentacije : Form
    {
        private JezikAplikacije jezikAplikacije;
        private TipPrvenstva tipPrvenstva;
        private string omiljenaReprezentacija;
        private ListViewColumnSorter lvwColumnSorter;

        public StatistikaGledateljaReprezentacije(JezikAplikacije jezikAplikacije, TipPrvenstva tipPrvenstva, string omiljenaReprezentacija)
        {
            InitializeComponent();
            this.jezikAplikacije = jezikAplikacije;
            this.tipPrvenstva = tipPrvenstva;
            this.omiljenaReprezentacija = omiljenaReprezentacija;

            lvwColumnSorter = new ListViewColumnSorter();
            lvIgraci.ListViewItemSorter = lvwColumnSorter;

        }

        private void StatistikaReprezentacije_Load(object sender, EventArgs e)
        {
            DohvacanjeMatcheva();
            
        }

        private async void DohvacanjeMatcheva()
        {
           
            try
            {
                lblInfo.Text = Properties.Resources.StatistikaGledateljaDohvacamPodatke;
                List<Match> listaMatcheva = await Repository.DohvatiPodatkeZaReprezentacijuIzJsona(tipPrvenstva, omiljenaReprezentacija);

                foreach (Match match in listaMatcheva)
                {
                    string[] row = { match.Location, match.Attendance, match.HomeTeamCountry, match.AwayTeamCountry };
                    lvIgraci.Items.Add(new ListViewItem(row));
                }
                lblInfo.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void btnIspisi_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show(Properties.Resources.StatistikaIgracaPrintanje);
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(this.Width, this.Height);

            this.DrawToBitmap(bmp, new Rectangle
            {

                X = 0,
                Y = 0,

                Width = this.Width,
                Height = this.Height
            });

            e.Graphics.DrawImage(bmp, new Point { X = e.MarginBounds.X, Y = e.MarginBounds.Y });

        }

        private void lvIgraci_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            lvIgraci.Sort();
        }
    }
}
