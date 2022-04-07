
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
    public partial class OdabirReprezentacije : Form
    {

        private JezikAplikacije jezikAplikacije;
        private TipPrvenstva tipPrvenstva;

        public OdabirReprezentacije()
        {
            InitializeComponent();
        }

        public OdabirReprezentacije(List<string> postavke)
        {
            InitializeComponent();

            jezikAplikacije = postavke[0] == "en" ? JezikAplikacije.English : JezikAplikacije.Hrvatski;
            tipPrvenstva = postavke[1] == "male" ? TipPrvenstva.Musko : TipPrvenstva.Zensko;

        }

        private void OdabirReprezentacije_Load(object sender, EventArgs e)
        {
            
            NapuniDDLReprezentacije();

        }


        private async void NapuniDDLReprezentacije()
        {

            try
            {
                btnOdaberiReprezentaciju.Enabled = false;
                slInfo.Text = Properties.Resources.OdabirReprezentacijeUcitavamPostavke;

                foreach (var team in await Repository.DohvatiSveTimoveIzJsona(tipPrvenstva))
                {

                    cbOmiljenaReprezentacija.Items.Add(team);

                }

                cbOmiljenaReprezentacija.SelectedIndex = 0;

                btnOdaberiReprezentaciju.Enabled = true;
                slInfo.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show(Properties.Resources.izbaciGresku);
            }

        }

        private void btnOdaberiReprezentaciju_Click(object sender, EventArgs e)
        {
            var selectedItem = (Team)cbOmiljenaReprezentacija.SelectedItem;

            Repository.SpremiPostavkeUFileWPF(jezikAplikacije, tipPrvenstva, selectedItem.FifaCode, Rezolucija.Srednja);

            Close();


        }
    }
}
