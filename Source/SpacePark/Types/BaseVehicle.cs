using System;
using System.Collections.Generic;

namespace SpacePark.Types
{
    public class BaseVehicle
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Cost_In_Credits { get; set; }
        public string Length { get; set; }

        public string Max_Atmosphering_Speed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        public string Cargo_capacity { get; set; }
        public string Consumables { get; set; }


        public IList<string> Pilots { get; set; }
        public IList<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }








    }
}
