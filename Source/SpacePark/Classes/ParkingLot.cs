using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePark.Classes
{
    class ParkingLot
    {
        List<ParkingSpace> spaces = new List<ParkingSpace>();



        public bool full()
        {
            foreach (ParkingSpace item in spaces)
            {

                if (item.occupied == false)
                {
                    return false;
                }

                

            }

            return true;
        }


    }
}
