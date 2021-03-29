using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePark.Types
{
    public static class ParkingLot
    {
        public static List<ParkingSpace> ParkingSpaces;
        
        public static void GenerateParkingSpaces()
        {
            ParkingSpaces = new List<ParkingSpace>();
            int index = 0;
            for (; index < 100; index++)            // Adds 100 occupied parking spaces for small ships
            {
                ParkingSpaces.Add(new ParkingSpace(index, 20, true));
            }
            for (; index < 110; index++)             // Adds 10 unoccupied parking spaces for small ships
            {
                ParkingSpaces.Add(new ParkingSpace(index, 20, false));
            }
            for (; index < 118; index++)             // Adds 8 occupied parking spaces for medium ships
            {
                ParkingSpaces.Add(new ParkingSpace(index, 120, true));
            }
            for (; index < 120; index++)             // Adds 2 unoccupied parking spaces for medium ships
            {
                ParkingSpaces.Add(new ParkingSpace(index, 120, false));
            }
            for (; index < 124; index++)             // Adds 4 occupied parking spaces for large ships
            {
                ParkingSpaces.Add(new ParkingSpace(index, 500, true));
            }
            for (; index < 125; index++)             // Adds 1 unoccupied parking spaces for large ships
            {
                ParkingSpaces.Add(new ParkingSpace(index, 500, false));
            }
            for (; index < 126; index++)             // Adds 1 unoccupied parking space for capital ships
            {
                ParkingSpaces.Add(new ParkingSpace(index, 5000, false));
            }
        }

    }
}
