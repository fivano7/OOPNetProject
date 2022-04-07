using Newtonsoft.Json;
using PodatkovniSloj.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodatkovniSloj
{
    public class Repository
    {
        //private const string JSON_PUTANJA = "../../worldcup.sfg.io/men/results";
        private const string OSNOVNA_PUTANJA = "../../../WorldCupWF/bin/Debug/";
        private const string POSTAVKE = OSNOVNA_PUTANJA +  "postavke.txt";
        private const string MUSKI1 = "http://world-cup-json-2018.herokuapp.com/teams/results";
        private const string MUSKI2 = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private const string ZENSKI1 = "http://worldcup.sfg.io/teams/results";
        private const string ZENSKI2 = "http://worldcup.sfg.io/matches/country?fifa_code=";

        public static Task<List<Team>> DohvatiSveTimoveIzJsona(TipPrvenstva tipPrvenstva)
        {
            return Task.Run((Func<List<Team>>)(() =>
            {
                string url = "";

                if (tipPrvenstva == TipPrvenstva.Musko)
                {
                    url = MUSKI1;
                }
                else if (tipPrvenstva == TipPrvenstva.Zensko)
                {
                    url = ZENSKI1;
                }

                var apiKlijent = new RestClient(url);
                var odgovor = apiKlijent.Execute<List<Team>>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Team>>(odgovor.Content);
            }));
        }

        public static Task<List<Match>> DohvatiPodatkeZaReprezentacijuIzJsona(TipPrvenstva tipPrvenstva, string fifaKod)
        {
            return Task.Run((Func<List<Match>>)(() =>
            {
                string url = "";

                if (tipPrvenstva == TipPrvenstva.Musko)
                {
                    url = MUSKI2;
                }
                else if (tipPrvenstva == TipPrvenstva.Zensko)
                {
                    url = ZENSKI2;
                }

                var apiKlijent = new RestClient(url + fifaKod);
                var response = apiKlijent.Execute<List<Match>>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Match>>(response.Content);
            }));
        }

        public static void SpremiPostavkeUFileWPF(JezikAplikacije jezikAplikacije, TipPrvenstva tipPrvenstva, string omiljenaReprezentacija, Rezolucija rezolucija)
        {
            using (StreamWriter writer = new StreamWriter(POSTAVKE))
            {
                writer.Write(jezikAplikacije == JezikAplikacije.Hrvatski ? "hr" : "en");
                writer.Write(Environment.NewLine);
                writer.Write(tipPrvenstva == TipPrvenstva.Musko ? "male" : "female");
                writer.Write(Environment.NewLine);
                writer.Write(omiljenaReprezentacija);
                writer.Write(Environment.NewLine);
                switch (rezolucija)
                {
                    case Rezolucija.Mala:
                        writer.Write("Mala");
                        break;
                    case Rezolucija.Srednja:
                        writer.Write("Srednja");
                        break;
                    case Rezolucija.Velika:
                        writer.Write("Velika");
                        break;
                    case Rezolucija.FullScreen:
                        writer.Write("FullScreen");
                        break;
                }
            }
        }


        public static bool DaLiPostojePostavke()
        {
            return File.Exists(POSTAVKE);
        }


        public static List<string> DohvacanjePostavki()
        {
            if (!DaLiPostojePostavke())
            {
                return null;
            }


            using (StreamReader podaci = new StreamReader(POSTAVKE))
            {
                List<string> postavke = new List<string>();

                while (!podaci.EndOfStream)
                {
                    postavke.Add(podaci.ReadLine());
                }
                return postavke;
            }
        }

        public static void SpremanjePodatakaZaTimUFile(TipPrvenstva tipPrvenstva, string fifaCode, List<Player> igraci) 
        {

            using (StreamWriter writer = new StreamWriter(DohvacanjePutanje(tipPrvenstva, fifaCode)))
            {
                foreach (Player igrac in igraci)
                {
                    writer.Write(igrac.ToString());
                    writer.Write(Environment.NewLine);
                }
            }
        }

        public static string DohvacanjePutanje(TipPrvenstva tipPrvenstva, string fifaCode) 
        {
            return OSNOVNA_PUTANJA + fifaCode + "_" + tipPrvenstva.ToString() + ".txt";
        }

        public static List<Player> DohvacanjePodatakaTimaIzFilea (TipPrvenstva tipPrvenstva, string fifaCode)
        {
            string putanjaFilea = DohvacanjePutanje(tipPrvenstva, fifaCode);

            if (!File.Exists(putanjaFilea))
            {
                return null;
            }

            using (StreamReader reader = new StreamReader(putanjaFilea))
            {
                List<Player> listaIgraca = new List<Player>();

                while (!reader.EndOfStream)
                {
                   
                    listaIgraca.Add(Player.ReadPlayerFromFileLine(reader.ReadLine()));
                }
                return listaIgraca;
            }
        }


    }



}
