using PodatkovniSloj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupWF
{

    public partial class IgracKontrola : UserControl
    {

        public Player Igrac { get; set; }
        public IgracKontrola()
        {
            InitializeComponent();
        }

        public IgracKontrola(Player p)
        {
            InitializeComponent();
           
            this.Igrac = p;
          
            lblImeIgraca.Text = (bool)p.Captain ? $"{p.Name} (C)" : $"{p.Name}";
            lblBrojIgraca.Text = (p.ShirtNumber).ToString();


            switch (p.Position)
            {
                case "Goalie":
                    p.Position = Properties.Resources.pozicijaGolman;
                    break;
                case "Defender":
                    p.Position = Properties.Resources.pozicijaObrambeni;
                    break;
                case "Midfield":
                    p.Position = Properties.Resources.pozicijaVezni;
                    break;
                case "Forward":
                    p.Position = Properties.Resources.pozicijaNapadac;
                    break;
                default:
                    break;
            }

            lblPozicija.Text = p.Position;
            lblOmiljeniIgrac.Text = p.Omiljeni ? "★" : "";

        }


        public void ImaZvjezdicu(bool omiljeni)
        {
            lblOmiljeniIgrac.Text = omiljeni ? "★" : "";
            
        }

        public void DodajSliku(Image slika)
        {
            pbIgrac.Image = slika;
        }

    }
}
