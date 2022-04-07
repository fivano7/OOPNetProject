using PodatkovniSloj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for StatIgraca.xaml
    /// </summary>
    public partial class StatIgraca : Window
    {
        public StatIgraca(Player igrac, Match match)
        {
            InitializeComponent();
            Match trenutniMatch = match;

            foreach (TeamEvent teamEvent in trenutniMatch.HomeTeamEvents)
            {
                DodavanjeEventaNaIgraca(teamEvent, igrac);
            }

            foreach (TeamEvent teamEvent in trenutniMatch.AwayTeamEvents)
            {
                DodavanjeEventaNaIgraca(teamEvent, igrac);
            }

            PrikaziIgraca(igrac);
            igrac.Pogodci = 0;
            igrac.ZutiKartoni = 0;
        }

        private void DodavanjeEventaNaIgraca(TeamEvent teamEvent, Player igrac)
        {

            if (igrac.Name == teamEvent.Player)
            {
                if (teamEvent.TypeOfEvent == "yellow-card")
                {
                    igrac.ZutiKartoni ++;

                }
                else if (teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty")
                {
                    igrac.Pogodci ++;
                }
            }

        }

        private void PrikaziIgraca(Player igrac)
        {
            lblIgrac.Content = igrac.Name;
            lblBrojIgracaPodatak.Content = igrac.ShirtNumber;

            switch (igrac.Position)
            {
                case "Goalie":
                    igrac.Position = Properties.Resources.pozicijaGolman;
                        break;
                case "Defender":
                    igrac.Position = Properties.Resources.pozicijaObrambeni;
                    break;
                case "Midfield":
                    igrac.Position = Properties.Resources.pozicijaVezni;
                    break;
                case "Forward":
                    igrac.Position = Properties.Resources.pozicijaNapadac;
                    break;
                default:
                    break;
            }

            lblPozicijaPodatak.Content = igrac.Position;
            lblKapetanPodatak.Content = (bool)igrac.Captain ? Properties.Resources.kapetanDa : Properties.Resources.kapetanNe;
            lblGoloviPodatak.Content = igrac.Pogodci;
            lblZutiKartoniPodatak.Content = igrac.ZutiKartoni;
        }
    }
}
