using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePark.Types
{
    public class ParkingLot
    {
        List<ParkingSpace> spaces = new List<ParkingSpace>();
        public bool CheckForFreeParkingSpaces()
        {
            foreach (ParkingSpace item in spaces)
            {
                if (item.Occupied == false)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
