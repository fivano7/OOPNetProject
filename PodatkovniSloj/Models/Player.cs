using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodatkovniSloj.Models
{
    public class Player
    {
        private const char DEL = '|';

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("captain")]
        public bool? Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long? ShirtNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        public bool Omiljeni { get; set; }
        public int Pogodci { get; set; }
        public int ZutiKartoni { get; set; }
        public string Slika { get; set; }

        public static Player ReadPlayerFromFileLine(string line) {

            Player player = new Player();

            try
            {
                var podaci = line.Split(DEL);

                player.Name = podaci[0];
                player.ShirtNumber = long.Parse(podaci[1]);
                player.Position = podaci[2];
                player.Captain = bool.Parse(podaci[3]);

                player.Pogodci = int.Parse(podaci[4]);
                player.ZutiKartoni = int.Parse(podaci[5]);
                player.Slika = podaci[6];
                player.Omiljeni = bool.Parse(podaci[7]);

                return player;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return null;
        
        }

        public override string ToString()
        {
            return Name + DEL + ShirtNumber + DEL + Position + DEL + Captain + DEL + Pogodci + DEL + ZutiKartoni + DEL + Slika + DEL + Omiljeni;
        }

    }
}
