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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorldCupWPF
{

    public partial class IgracKontrola : UserControl
    {
        public Player Igrac { get; set; }
        public IgracKontrola(Player igrac, bool favourite)
        {
            InitializeComponent();
            this.Igrac = igrac;

            if (favourite)
            {
                unutarnjiGrid.Background = Brushes.LightCoral;
            }
            else
            {
                unutarnjiGrid.Background = Brushes.LightBlue;
            }
            lblIme.Text = igrac.Name;
            lblBroj.Text = igrac.ShirtNumber.ToString();

            //kontrola.MouseDown += Kontrola_MouseDown;
        }

        

        //private void Kontrola_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    new StatIgraca(igrac).ShowDialog();
        //}
    }
}
