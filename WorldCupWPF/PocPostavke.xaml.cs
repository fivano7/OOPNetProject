using PodatkovniSloj;
using PodatkovniSloj.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PocPostavke : Window
    {
        public PocPostavke()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NapuniDDLOdabirPrvenstva();
            NapuniDDLJezik();
            NapuniDDLRezolucija();
        }


        private void NapuniDDLJezik()
        {
            string hr = Properties.Resources.jezikHrvatski;
            string en = Properties.Resources.jezikEngleski;
            ddlJezik.Items.Add(hr);
            ddlJezik.Items.Add(en);
            ddlJezik.SelectedIndex = 0;
        }

        private void NapuniDDLOdabirPrvenstva()
        {
            string musko = Properties.Resources.spolMuski;
            string zensko = Properties.Resources.spolZenski;
            ddlPrvenstvo.Items.Add(musko);
            ddlPrvenstvo.Items.Add(zensko);
            ddlPrvenstvo.SelectedIndex = 0;
        }
        private void NapuniDDLRezolucija()
        {
            string malaRezolucija = Properties.Resources.rezolucijaMala;
            string srednjaRezolucija = Properties.Resources.rezolucijaSrednja;
            string velikaRezolucija = Properties.Resources.rezolucijaVelika;
            string fullscreenRezolucija = Properties.Resources.rezolucijaFullscreen;
            ddlRezolucija.Items.Add(malaRezolucija);
            ddlRezolucija.Items.Add(srednjaRezolucija);
            ddlRezolucija.Items.Add(velikaRezolucija);
            ddlRezolucija.Items.Add(fullscreenRezolucija);
            ddlRezolucija.SelectedIndex = 0;
        }

        private void btnOtvori_Click(object sender, RoutedEventArgs e)
        {
            TipPrvenstva odabraniTipPrvenstva;
            JezikAplikacije odabraniJezikAplikacije;
            Rezolucija odabranaRezolucija = Rezolucija.Srednja;

            odabraniJezikAplikacije = ddlJezik.SelectedIndex == 0 ? JezikAplikacije.Hrvatski : JezikAplikacije.English;
            odabraniTipPrvenstva = ddlPrvenstvo.SelectedIndex == 0 ? TipPrvenstva.Musko : TipPrvenstva.Zensko;

            List<string> list = Repository.DohvacanjePostavki();

            switch (ddlRezolucija.SelectedIndex)
            {
                case 0:
                    odabranaRezolucija = Rezolucija.Mala;
                    break;
                case 1:
                    odabranaRezolucija = Rezolucija.Srednja;
                    break;
                case 2:
                    odabranaRezolucija = Rezolucija.Velika;
                    break;
                case 3:
                    odabranaRezolucija = Rezolucija.FullScreen;
                    break;
            }


            if (list != null)
            {
                Repository.SpremiPostavkeUFileWPF(odabraniJezikAplikacije, odabraniTipPrvenstva, list[2], odabranaRezolucija);
            }
            else
            {
                Repository.SpremiPostavkeUFileWPF(odabraniJezikAplikacije, odabraniTipPrvenstva, "", odabranaRezolucija);
            }

            string culture = ddlJezik.SelectedIndex == 0 ? "hr" : "en";

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);


            new PregledReprezentacije().Show();

            this.Close();

            Close();
        }
    }
}
