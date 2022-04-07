
using PodatkovniSloj;
using PodatkovniSloj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupWF
{
    public partial class PocetnePostavke : Form
    {

        public PocetnePostavke()
        {
            InitializeComponent();
        }

        private void PocetnePostavke_Load(object sender, EventArgs e)
        {
            NapuniDDLOdabirPrvenstva();
            NapuniDDLJezik();
        }

        private void NapuniDDLJezik()
        {
            string hr = Properties.Resources.PostavkeHrvatski;
            string en = Properties.Resources.PostavkeEngleski;
            cbJezikAplikacije.Items.Add(hr);
            cbJezikAplikacije.Items.Add(en);
            cbJezikAplikacije.SelectedIndex = 0;
        }

        private void NapuniDDLOdabirPrvenstva()
        {

            string musko = Properties.Resources.PostavkeMusko;
            string zensko = Properties.Resources.PostavkeZensko;
            cbOdabirPrvenstva.Items.Add(musko);
            cbOdabirPrvenstva.Items.Add(zensko);
            cbOdabirPrvenstva.SelectedIndex = 0;


        }

        private void btnOtvoriAplikaciju_Click(object sender, EventArgs e)
        {
            TipPrvenstva odabraniTipPrvenstva;
            JezikAplikacije odabraniJezikAplikacije;

            odabraniJezikAplikacije = cbJezikAplikacije.SelectedIndex == 0 ? JezikAplikacije.Hrvatski : JezikAplikacije.English;
            odabraniTipPrvenstva = cbOdabirPrvenstva.SelectedIndex == 0 ? TipPrvenstva.Musko : TipPrvenstva.Zensko;

            string culture = cbJezikAplikacije.SelectedIndex == 0 ? "hr" : "en";

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            Repository.SpremiPostavkeUFileWPF(odabraniJezikAplikacije, odabraniTipPrvenstva, "", Rezolucija.Srednja);

            Close();

        }
    }
}
