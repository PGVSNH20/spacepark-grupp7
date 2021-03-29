using Newtonsoft.Json;
using SpacePark.Types;
using System;
using System.Collections.Generic;
using System.Net;

namespace SpacePark.SWAPI
{
    public static class PeopleFetcher
    {
        public static List<PersonalData> output = new List<PersonalData>();
        public static List<PersonalData> GetListOfPeople()
        {
            output = new List<PersonalData>();
            Fetch(@"https://swapi.dev/api/people/");
            return output;
        }

        private static void Fetch(string url)
        {
            using (WebClient wc = new WebClient())
            {
                var data = wc.DownloadString(url);
                PeopleData pd = JsonConvert.DeserializeObject<PeopleData>(data);
                foreach (PersonalData person in pd.Results)
                {
                    output.Add(person);
                }
                if (!String.IsNullOrEmpty(pd.Next)) // NOT
                {
                    Fetch(pd.Next);
                }
            }
        }
    }
}
