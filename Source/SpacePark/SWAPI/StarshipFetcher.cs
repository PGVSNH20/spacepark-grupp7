using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpacePark.Types;

namespace SpacePark.SWAPI
{
    public static class StarshipFetcher
    {
        public static List<StarshipData> output = new List<StarshipData>();
        public static List<StarshipData> GetListOfStarships()
        {
            Fetch(@"https://swapi.dev/api/starships/");
            return output;
        }

        private static void Fetch(string url)
        {
            using (WebClient wc = new WebClient())
            {
                var data = wc.DownloadString(url);
                Starship ships = JsonConvert.DeserializeObject<Starship>(data);
                foreach (StarshipData starship in ships.Results)
                {
                    output.Add(starship);
                }
                if (!String.IsNullOrEmpty(ships.Next)) // NOT
                {
                    Fetch(ships.Next);
                }
            }
        }
    }
}
