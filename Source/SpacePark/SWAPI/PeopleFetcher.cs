using SpacePark.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Threading;

namespace SpacePark.SWAPI
{
    public static class PeopleFetcher
    {
        public static PeopleData GetListOfPeople()
        {
            using (WebClient wc = new WebClient())
            {
                var data = wc.DownloadString(@"https://swapi.dev/api/people/");
                PeopleData pd = JsonConvert.DeserializeObject<PeopleData>(data);
                return pd;
            }
        }
    }
}
