using System.Collections.Generic;

namespace SpacePark.Types
{
    public class StarshipData : BaseVehicle
    {
        public string Hyperdrive_Rating { get; set; }
        public string MGLT { get; set; }
        public string Starship_Class { get; set; }
        
    }

    public class Starship
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }
        public IList<StarshipData> Results { get; set; }

        //Hello
    }
}
