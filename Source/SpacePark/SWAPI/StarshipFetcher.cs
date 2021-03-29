using Newtonsoft.Json;
using SpacePark.Types;
using System;
using System.Collections.Generic;
using System.Net;

namespace SpacePark.SWAPI
{
    public static class StarshipFetcher
    {
        private static List<StarshipData> output = new List<StarshipData>();
        public static List<StarshipData> GetListOfStarships()
        {
            output = new List<StarshipData>();
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
