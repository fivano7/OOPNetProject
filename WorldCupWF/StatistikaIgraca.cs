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
    public partial class StatistikaIgraca : Form
    {
        private JezikAplikacije jezikAplikacije;
        private TipPrvenstva tipPrvenstva;
        private string omiljenaReprezentacija;
        private List<Player> listaIgraca;
        private ListViewColumnSorter lvwColumnSorter;

        public StatistikaIgraca(JezikAplikacije jezikAplikacije, TipPrvenstva tipPrvenstva, string omiljenaReprezentacija, List<Player> listaIgraca)
        {
           
            InitializeComponent();
            
            this.jezikAplikacije = jezikAplikacije;
            this.tipPrvenstva = tipPrvenstva;
            this.omiljenaReprezentacija = omiljenaReprezentacija;
            this.listaIgraca = listaIgraca;
            lvwColumnSorter = new ListViewColumnSorter();
            lvReprezentacija.ListViewItemSorter = lvwColumnSorter;
        }

        private void StatistikaIgraca_Load(object sender, EventArgs e)
        {
            ColumnHeader columnheader;
            ListViewItem listviewitem;

            lvReprezentacija.View = View.Details;

            columnheader = new ColumnHeader();
            columnheader.Text = Properties.Resources.StatistikaIgracaSlika;
            lvReprezentacija.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = Properties.Resources.StatistikaIgracaIme;
            lvReprezentacija.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = Properties.Resources.StatistikaIgracaZutiKartoni;
            lvReprezentacija.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = Properties.Resources.StatistikaIgracaPogodci;
            lvReprezentacija.Columns.Add(columnheader);

            foreach (ColumnHeader ch in lvReprezentacija.Columns)
            {
                //Slika da ima manji prostor
                if (ch == lvReprezentacija.Columns[0])
                {
                    ch.Width = 50;
                }
                else
                {
                    ch.Width = 175;

                }
            }

            foreach (var igrac in listaIgraca)
            {
                listviewitem = new ListViewItem("", 0);
                listviewitem.SubItems.Add(igrac.Name);
                listviewitem.SubItems.Add(igrac.ZutiKartoni.ToString());
                listviewitem.SubItems.Add(igrac.Pogodci.ToString());
                lvReprezentacija.Items.Add(listviewitem);
            }
        }

        private void lvReprezentacija_ColumnClick(object sender, ColumnClickEventArgs e)
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

            lvReprezentacija.Sort();
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
    }
}
