using System.Collections.Generic;

namespace SpacePark.Types
{

    public class VehicleData
        {
            public string Vehicle_Class { get; set; }
            
        }

        public class Vehicle
        {
            public int Count { get; set; }
            public string Next { get; set; }
            public object Previous { get; set; }
            public IList<VehicleData> Results { get; set; }
        }




    
}
