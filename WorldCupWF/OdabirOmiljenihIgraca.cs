using PodatkovniSloj;
using PodatkovniSloj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupWF.Models;

namespace WorldCupWF
{
    public partial class OdabirOmiljenihIgraca : Form
    {

        private JezikAplikacije jezikAplikacije;
        private TipPrvenstva tipPrvenstva;
        private string omiljenaReprezentacija;

        private Control panelPokrenuoDnD;

        private List<Player> listaIgraca;
        private List<Match> listaMatcheva;

        private IgracKontrola selektiraniIgrac;
        private HashSet<IgracKontrola> selektiraniIgraci = new HashSet<IgracKontrola>();



        public OdabirOmiljenihIgraca()
        {
            UcitajPostavkeAplikacije();
            InitializeComponent();
            Inicijalizacija();


        }


        private void Inicijalizacija()
        {
            
            UcitajIgraceIzJsona();
           
        }

        private void UcitajPostavkeAplikacije()
        {
            List<string> postavke = Repository.DohvacanjePostavki();
            jezikAplikacije = postavke[0] == "en" ? JezikAplikacije.English : JezikAplikacije.Hrvatski;

            string culture = postavke[0] == "hr" ? "hr" : "en";

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            tipPrvenstva = postavke[1] == "male" ? TipPrvenstva.Musko : TipPrvenstva.Zensko;
            omiljenaReprezentacija = postavke[2];


        }


        private async void UcitajIgraceIzJsona()
        {
            try
            {

                lblInfo.Text = Properties.Resources.StatistikaGledateljaDohvacamPodatke;

                listaIgraca = Repository.DohvacanjePodatakaTimaIzFilea(tipPrvenstva, omiljenaReprezentacija);

                if (omiljenaReprezentacija != null)
                {
                    Repository.SpremiPostavkeUFileWPF(jezikAplikacije, tipPrvenstva, omiljenaReprezentacija, Rezolucija.Srednja);
                }

                if (listaIgraca == null)
                {
                    listaIgraca = new List<Player>();


                    listaMatcheva = await Repository.DohvatiPodatkeZaReprezentacijuIzJsona(tipPrvenstva, omiljenaReprezentacija);

                    if (listaMatcheva[0].HomeTeam.Code == omiljenaReprezentacija)
                    {
                        foreach (Player igrac in listaMatcheva[0].HomeTeamStatistics.StartingEleven)
                        {
                            listaIgraca.Add(igrac);
                        }


                        foreach (Player igrac in listaMatcheva[0].HomeTeamStatistics.Substitutes)
                        {
                            listaIgraca.Add(igrac);
                        }
                    }
                    else
                    {
                        foreach (Player igrac in listaMatcheva[0].AwayTeamStatistics.StartingEleven)
                        {
                            listaIgraca.Add(igrac);
                        }


                        foreach (Player igrac in listaMatcheva[0].AwayTeamStatistics.Substitutes)
                        {
                            listaIgraca.Add(igrac);
                        }
                    }
                    

                    PostavljanjeEvenataNaUtakmice(listaIgraca, listaMatcheva);

                }


                lblInfo.Text = "";

                //SpremanjePostavkiTima();

                UcitajIgraceUPanel();

            }

            catch (Exception)
            {
                lblInfo.Text = Properties.Resources.OdabirOmiljenihGreska;
            }

        }

        private void UcitajIgraceUPanel()
        {
            flpOstaliIgraci.Controls.Clear();
            flpOmiljeniIgraci.Controls.Clear();

            foreach (Player igrac in listaIgraca)
            {
                var igracUserKontrola = new IgracKontrola(igrac);
                igracUserKontrola.MouseDown += new MouseEventHandler(kontrola_MouseDown);
                igracUserKontrola.ContextMenuStrip = cmsDodajPremjesti;


                if (igrac.Omiljeni)
                {
                    flpOmiljeniIgraci.Controls.Add(igracUserKontrola);
                }
                else
                {
                    flpOstaliIgraci.Controls.Add(igracUserKontrola);
                }

            }
        }



        private void PostavljanjeEvenataNaUtakmice(List<Player> listaIgraca, List<Match> listaUtakmica)
        {
            foreach (Match utakmica in listaUtakmica)
            {
                foreach (TeamEvent teamEvent in utakmica.HomeTeamEvents)
                {
                    DodavanjeEventaNaIgraca(teamEvent, listaIgraca);
                }

                foreach (TeamEvent teamEvent in utakmica.AwayTeamEvents)
                {
                    DodavanjeEventaNaIgraca(teamEvent, listaIgraca);
                }
            }
        }

        private void DodavanjeEventaNaIgraca(TeamEvent teamEvent, List<Player> listaIgraca)
        {
            foreach (Player igrac in listaIgraca)
            {
                if (igrac.Name == teamEvent.Player)
                {
                    if (teamEvent.TypeOfEvent == "yellow-card")
                    {
                        igrac.ZutiKartoni++;

                    }
                    else if (teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty")
                    {
                        igrac.Pogodci++; ;
                    }
                }
            }
        }

        private void SpremanjePostavkiTima()
        {

            try
            {
                if (omiljenaReprezentacija != null && listaIgraca != null)
                {

                    List<Player> listaOmiljenihIgraca = new List<Player>();
                    foreach (IgracKontrola kontrola in flpOmiljeniIgraci.Controls)
                    {
                        listaOmiljenihIgraca.Add(kontrola.Igrac);
                    }

                    //Svima stavi da nije omiljeni, pa ako imaju isti broj kao oni iz omiljenih onda su omiljeni
                    foreach (var igrac in listaIgraca)
                    {
                        igrac.Omiljeni = false;

                        foreach (Player player in listaOmiljenihIgraca)
                        {
                            if (igrac.ShirtNumber == player.ShirtNumber)
                            {
                                igrac.Omiljeni = true;
                            }
                        }
                    }


                    Repository.SpremanjePodatakaZaTimUFile(tipPrvenstva, omiljenaReprezentacija, listaIgraca);
                }
            }
            catch (Exception)
            {
                lblInfo.Text = Properties.Resources.OdabirOmiljenihGreskaUSpremanju;
            }
        }

        private void flpOmiljeniIgraci_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            lblInfo.Text = Properties.Resources.OdabirOmiljenihPrebacujemIgraca;
        }

        private void flpOstaliIgraci_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            lblInfo.Text = Properties.Resources.OdabirOmiljenihPrebacujemIgraca; 
        }


        private void kontrola_MouseDown(object sender, MouseEventArgs e)
        {
            IgracKontrola trenutnaKontrola = sender as IgracKontrola;

            if (trenutnaKontrola.Parent.Name == "flpOstaliIgraci")
            {
                flpOstaliIgraci.AllowDrop = false;
            }
            else
            {
                flpOmiljeniIgraci.AllowDrop = false;
            }

            if (selektiraniIgraci.Contains(trenutnaKontrola))
            {
                trenutnaKontrola.BorderStyle = BorderStyle.None;
                selektiraniIgraci.Remove(trenutnaKontrola);
            }
            else
            {
                ZapocniDnD(trenutnaKontrola);
            }
            flpOmiljeniIgraci.AllowDrop = true;
            flpOstaliIgraci.AllowDrop = true;

        }

        private void ZapocniDnD(IgracKontrola ctrl)
        {

            panelPokrenuoDnD = ctrl.Parent;


            if (selektiraniIgraci.Count < 3)
            {
                selektiraniIgraci.Add(ctrl);
                foreach (var igrac in selektiraniIgraci)
                {
                    igrac.BorderStyle = BorderStyle.FixedSingle;
                    
                }
                lblInfo.Text = "";
                this.DoDragDrop(new DragData { KontrolaIgraca = selektiraniIgraci }, DragDropEffects.Move);
            }
            else
            {
                MessageBox.Show(Properties.Resources.OdabirOmiljenihIgracaDragAndDrop3Igraca);
                lblInfo.Text = "";
            }

            lblInfo.Text = "";
        }

        private void flpOmiljeniIgraci_DragDrop(object sender, DragEventArgs e)
        {


            DragData dragData = e.Data.GetData(typeof(DragData)) as DragData;

            foreach (var kontrola in dragData.KontrolaIgraca)
            {
                kontrola.BorderStyle = BorderStyle.None;
                if (kontrola != null)
                {
                    if (panelPokrenuoDnD.Name != ((sender as Control).Name))
                    {
                        if (flpOmiljeniIgraci.Controls.Count < 3)
                        {

                            kontrola.ImaZvjezdicu(true);
                            flpOmiljeniIgraci.Controls.Add(kontrola);
                            lblInfo.Text = "";

                        }
                        else
                        {
                            MessageBox.Show(Properties.Resources.OdabirOmiljenihMax3Omiljena);
                            lblInfo.Text = "";
                            break;
                        }
                }
            }
            }
            selektiraniIgraci.Clear();
            lblInfo.Text = "";

        }

        private void flpOstaliIgraci_DragDrop(object sender, DragEventArgs e)
        {

            DragData dragData = e.Data.GetData(typeof(DragData)) as DragData;

            foreach (var kontrola in dragData.KontrolaIgraca)
            {
                kontrola.BorderStyle = BorderStyle.None;
                if (kontrola != null)
                {
                    if (panelPokrenuoDnD.Name != ((sender as Control).Name))
                    {
                        kontrola.ImaZvjezdicu(false);
                        flpOstaliIgraci.Controls.Add(kontrola);

                    }
                }
                }
            selektiraniIgraci.Clear();
            lblInfo.Text = "";

        }

        private void dodajSlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //ofd.Filter = "Slike|*.jpeg;*.jpg;*.png;|All files|*.*";
                ofd.Filter = Properties.Resources.OdabirOmiljenihFilter;
                ofd.Multiselect = false;
                ofd.Title = Properties.Resources.OdabirOmiljenihUcitajSliku;
                ofd.InitialDirectory = Application.StartupPath;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selektiraniIgrac.DodajSliku(new Bitmap(ofd.FileName)); 

                }
            }
        }

        private void premjestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flpOstaliIgraci.Controls.Contains(selektiraniIgrac))
            {

                if (flpOmiljeniIgraci.Controls.Count < 3)
                {
                    flpOstaliIgraci.Controls.Remove(selektiraniIgrac);
                    flpOmiljeniIgraci.Controls.Add(selektiraniIgrac);
                    selektiraniIgrac.ImaZvjezdicu(true);
                    selektiraniIgrac = null;
                }
                else
                {
                    MessageBox.Show(Properties.Resources.OdabirOmiljenihMax3Omiljena);
                    return;
                }
            }
            else
            {

                selektiraniIgrac.ImaZvjezdicu(false);
                flpOmiljeniIgraci.Controls.Remove(selektiraniIgrac);
                flpOstaliIgraci.Controls.Add(selektiraniIgrac);
                selektiraniIgrac = null;
            }
        }

        private void cmsDodajPremjesti_Opening(object sender, CancelEventArgs e)
        {
           
            IgracKontrola kontrola = (sender as ContextMenuStrip).SourceControl as IgracKontrola;
            selektiraniIgrac = kontrola;
        }

        private void postavkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Postavke(omiljenaReprezentacija).ShowDialog();

        }

        private void tsUtakmica_Click(object sender, EventArgs e)
        {
            new StatistikaGledateljaReprezentacije(jezikAplikacije,tipPrvenstva,omiljenaReprezentacija).ShowDialog();
        }

        private void tsIgraci_Click(object sender, EventArgs e)
        {
            new StatistikaIgraca(jezikAplikacije, tipPrvenstva, omiljenaReprezentacija, listaIgraca).ShowDialog();
        }


        private void OdabirOmiljenihIgraca_FormClosing(object sender, FormClosingEventArgs e)
        {
            SpremanjePostavkiTima();
            var dialogResult = ConfirmDialog.ShowDialog(this, Properties.Resources.OdabirOmiljenihIgracaConfirmDialogNaslov);
            if (dialogResult == DialogResult.No)
            {
               
                e.Cancel = true;
            }

            else if (dialogResult == DialogResult.Yes)
            {
                //SpremanjePostavkiTima();
                e.Cancel = false;
            }
        }


    }
}
