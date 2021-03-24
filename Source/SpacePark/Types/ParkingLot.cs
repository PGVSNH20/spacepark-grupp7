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
        public static bool CheckForFreeParkingSpaces()
        {
            foreach (ParkingSpace item in ParkingSpaces)
            {
                if (item.Occupied == false)
                {
                    return false;
                }
            }
            return true;
        }
        public static void GenerateParkingSpaces()
        {
            ParkingSpaces = new List<ParkingSpace>();
            /*
            int index = 0;
            for (; index < 100; index++)
            {
                ParkingSpaces.Add(new ParkingSpace());
            }
            for (; index < 110; index++)
            {

            }


             Console.WriteLine("ID parkingsize?");
             var id = Console.Read();
             Console.WriteLine("Size");
             double size = Console.Read();
             ParkingSpaces.Add(new ParkingSpace() { ID = 1, Occupied = false, Size = 12.3 });
            */
        }

    }
}
