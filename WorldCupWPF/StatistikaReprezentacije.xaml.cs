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
    
    public partial class StatistikaReprezentacije : Window
    {
        public StatistikaReprezentacije(Team team)
        {
            InitializeComponent();
            IspisiPodatke(team);
        }

        private void IspisiPodatke(Team team)
        {
            lblReprezentacija.Content = team.Country;

            lblNazivPodatak.Content = team.Country;
            lblFifaKodPodatak.Content = team.FifaCode;
            lblOdigraneUtakmicePodatak.Content = team.GamesPlayed;
            lblPobjedePodatak.Content = team.Wins;
            lblPoraziPodatak.Content = team.Losses;
            lblNeodlucenoPodatak.Content = team.Draws;
            lblZabijeniGoloviPodatak.Content = team.GoalsFor;
            lblPrimljeniGoloviPodatak.Content = team.GoalsAgainst;
            lblGolRazlikaPodatak.Content = team.GoalDifferential;
        }
    }
}
