using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePark.Types
{
    public class StarshipData : BaseVehicle
    {
        public string HyperdriveRating { get; set; }
        public string MGLT { get; set; }
        public string StarshipClass { get; set; }
        
    }

    public class Starship
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }
        public IList<StarshipData> Starships { get; set; }
    }
}
