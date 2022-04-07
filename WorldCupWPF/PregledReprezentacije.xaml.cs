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
using System.Windows.Shapes;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for PregledReprezentacije.xaml
    /// </summary>
    public partial class PregledReprezentacije : Window
    {
        private JezikAplikacije jezikAplikacije;
        private TipPrvenstva tipPrvenstva;
        private string omiljenaReprezentacija;
        private string protivnickaReprezentacija;
        private List<Team> listaTimova = new List<Team>();
        private List<Match> listaMatcheva = new List<Match>();


        public PregledReprezentacije()
        {
            DohvatiPostavke();
            InitializeComponent();
        }

        private void DohvatiPostavke()
        {
            List<string> postavke = Repository.DohvacanjePostavki();
            jezikAplikacije = postavke[0] == "en" ? JezikAplikacije.English : JezikAplikacije.Hrvatski;
            tipPrvenstva = postavke[1] == "male" ? TipPrvenstva.Musko : TipPrvenstva.Zensko;

            switch (postavke[3])
            {
                case "Mala":
                    this.Width = 265;
                    this.Height = 230;
                    break;
                case "Srednja":
                    this.Width = 800;
                    this.Height = 700;
                    break;
                case "Velika":
                    this.Width = 1000;
                    this.Height = 875;
                    break;
                case "FullScreen":
                    WindowState = WindowState.Maximized;
                    break;
                default:
                    this.Width = 800;
                    this.Height = 700;
                    break;
            }

            string culture = postavke[0] == "en" ? "en" : "hr";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DohvatiSveTimove();
        }

        private async void DohvatiSveTimove()
        {
            try
            {
                lblInfo.Text = Properties.Resources.PregledReprezentacijeInfoUcitavam;
                listaTimova = await Repository.DohvatiSveTimoveIzJsona(tipPrvenstva);
                lblInfo.Text = "";

                NapuniDDLOmiljenaReprezentacija();
                UcitajOmiljenuUDDL();
            }
            catch (Exception)
            {

                lblInfo.Text = Properties.Resources.PregledReprezentacijeGreska;
            }
        }

        private void UcitajOmiljenuUDDL()
        {
            ddlOmiljenaReprezentacija.SelectedIndex = 0;

            bool provjeraPostojanjaPostavki = Repository.DaLiPostojePostavke();
            if (provjeraPostojanjaPostavki)
            {
                List<string> list = Repository.DohvacanjePostavki();

                int brojac = 0;
                foreach (Team team in listaTimova)
                {
                    if (team.FifaCode == list[2])
                    {
                        ddlOmiljenaReprezentacija.SelectedIndex = brojac;
                    }
                   
                    brojac++;
                }
            }
           
        }

        private void NapuniDDLOmiljenaReprezentacija()
        {
            foreach (Team team in listaTimova)
            {
                ddlOmiljenaReprezentacija.Items.Add(team);
            }
        }


        private async void ddlOmiljenaReprezentacija_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            try
            {
                Team odabraniTeam = (Team)ddlOmiljenaReprezentacija.SelectedItem;
                omiljenaReprezentacija = odabraniTeam.FifaCode;

                lblInfo.Text = Properties.Resources.PregledReprezentacijeInfoUcitavam;
                listaMatcheva = await Repository.DohvatiPodatkeZaReprezentacijuIzJsona(tipPrvenstva, omiljenaReprezentacija);
                lblInfo.Text = "";

                HashSet<string> setTimova = new HashSet<string>();
                
                foreach (Match match in listaMatcheva)
                {
                    setTimova.Add(match.HomeTeam.Code);
                    setTimova.Add(match.AwayTeam.Code);   
                }

                ddlProtivnik.Items.Clear();


                foreach (var team in listaTimova)
                {
                    foreach (string tim in setTimova)
                    {
                        if (team.FifaCode == tim && tim != omiljenaReprezentacija)
                        {
                            ddlProtivnik.Items.Add(team);
                        }
                    }

                }

            }
            catch (Exception)
            {
                lblInfo.Text = Properties.Resources.PregledReprezentacijeGreska;
            }
        }

        private void ddlProtivnik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            protivnickaReprezentacija = ((Team)(ddlProtivnik).SelectedItem).FifaCode;
            Match match = DohvatiMatch();
            NapuniTeren();
        }


        private void btnProtivnikInfo_Click(object sender, RoutedEventArgs e)
        {
            protivnickaReprezentacija = ((Team)ddlProtivnik.SelectedItem).FifaCode;

            foreach (var team in listaTimova)
            {
                if (protivnickaReprezentacija == team.FifaCode)
                {
                    new StatistikaReprezentacije(team).ShowDialog();
                }
            }
        }

        private void btnOmiljenaInfo_Click(object sender, RoutedEventArgs e)
        {

            foreach (var team in listaTimova)
            {
                if (((Team)ddlOmiljenaReprezentacija.SelectedItem).FifaCode == team.FifaCode)
                {
                    new StatistikaReprezentacije(team).ShowDialog();
                }
            }
        }

        private Match DohvatiMatch()
        {
            if (listaMatcheva == null)
            {
                return null;
            }

            protivnickaReprezentacija = ((Team)ddlProtivnik.SelectedItem).FifaCode;
            omiljenaReprezentacija = ((Team)ddlOmiljenaReprezentacija.SelectedItem).FifaCode;

            foreach (Match match in listaMatcheva)
            {
                if (match.HomeTeam.Code.Equals(omiljenaReprezentacija) && match.AwayTeam.Code.Equals(protivnickaReprezentacija))
                {
                    return match;
                }

                if (match.AwayTeam.Code.Equals(omiljenaReprezentacija) && match.HomeTeam.Code.Equals(protivnickaReprezentacija))
                {
                    return match;
                }
            }

            return null;

        }

        private void NapuniTeren()
        {
            Match match = DohvatiMatch();

            if (match.HomeTeam.Code == ((Team)ddlOmiljenaReprezentacija.SelectedItem).FifaCode)
            {
                lblRezultat.Content = $"{match.HomeTeam.Goals} : {match.AwayTeam.Goals} ";
            }
            else
            {
                lblRezultat.Content = $"{match.AwayTeam.Goals} : {match.HomeTeam.Goals} ";

            }

            if (match == null)
            {
                return;
            }

            List<Player> omiljeniIgraci = new List<Player>();
            List<Player> protivnickiIgraci = new List<Player>();

            if (match.HomeTeam.Code == omiljenaReprezentacija)
            {
                omiljeniIgraci = match.HomeTeamStatistics.StartingEleven;
                protivnickiIgraci = match.AwayTeamStatistics.StartingEleven;
            }
            else
            {
                omiljeniIgraci = match.AwayTeamStatistics.StartingEleven;
                protivnickiIgraci = match.HomeTeamStatistics.StartingEleven;
            }

            gridIgraci.Children.Clear();
            DodajIgraceNaTeren(omiljeniIgraci, true);
            DodajIgraceNaTeren(protivnickiIgraci, false);
            
        }

        private void DodajIgraceNaTeren(List<Player> igraci, bool favoriteTeam)
        {
            int golmanStupac = favoriteTeam ? 0 : 7;
            var golman = igraci[0];


            DodajIgracaNaTeren(golman, golmanStupac, 2, favoriteTeam);
            int redakObrambenog = 0;
            int redakVeznjaka = 0;
            int redakNapadaca = 0;

 
            foreach (Player trenutniIgrac in igraci)
            {

                if (trenutniIgrac.Position.Equals("Defender"))
                {
                    int stupac = favoriteTeam ? 1 : 6;
                    
                    DodajIgracaNaTeren(trenutniIgrac, stupac, redakObrambenog, favoriteTeam);
                    redakObrambenog++;
                }

                else if (trenutniIgrac.Position.Equals("Midfield"))
                {
                    int stupac = favoriteTeam ? 2 : 5;
                    DodajIgracaNaTeren(trenutniIgrac, stupac, redakVeznjaka, favoriteTeam);
                    redakVeznjaka++;
                }

                else if (trenutniIgrac.Position.Equals("Forward"))
                {
                    int stupac = favoriteTeam ? 3 : 4;
                    DodajIgracaNaTeren(trenutniIgrac, stupac, redakNapadaca, favoriteTeam);
                    redakNapadaca++;
                }

            }
        }

        private void DodajIgracaNaTeren(Player trenutniIgrac, int stupac, int redak, bool favoriteTeam)
        {

            IgracKontrola igrac = new IgracKontrola(trenutniIgrac, favoriteTeam);
            igrac.MouseDown += Igrac_MouseDown;

            Grid.SetColumn(igrac, stupac);
            Grid.SetRow(igrac, redak);

            gridIgraci.Children.Add(igrac);


        }

        private void Igrac_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new StatIgraca((sender as IgracKontrola).Igrac, DohvatiMatch()).ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new Postavke(omiljenaReprezentacija).ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new ZatvaranjeAplikacije(Properties.Resources.PregledReprezentacijeZatvaranjeAplikacije).ShowDialog();
            e.Cancel = true;

        }
    }
}
