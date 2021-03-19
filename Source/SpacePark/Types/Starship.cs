using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePark.Types
{
    public class StarshipData
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string CostInCredits { get; set; }
        public string Length { get; set; }
        public string MaxAtmosphericSpeed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        public string Cargo_capacity { get; set; }
        public string Consumables { get; set; }
        public string HyperdriveRating { get; set; }
        public string MGLT { get; set; }
        public string StarshipClass { get; set; }
        public IList<string> Pilots { get; set; }
        public IList<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string URL { get; set; }
    }

    public class Starship
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }
        public IList<StarshipData> Starships { get; set; }
    }
}
