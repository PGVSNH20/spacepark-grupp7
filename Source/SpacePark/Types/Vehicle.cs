using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePark.Types
{
    class Vehicle
    {

        public class Result
        {
            public string vehicle_class { get; set; }
            
        }

        public class Root
        {
            public int count { get; set; }
            public string next { get; set; }
            public object previous { get; set; }
            public List<Result> results { get; set; }
        }




    }
}
