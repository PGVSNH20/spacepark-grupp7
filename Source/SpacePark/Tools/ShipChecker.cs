using SpacePark.Types;
using System.Collections.Generic;

namespace SpacePark.Tools
{
    public static class ShipChecker
    {
        public static bool TestIfShipIsInStarWars(List<StarshipData> starshipDataFromSWAPI, string starShipInput)
        {
            foreach(StarshipData starshipDataFromSWAPIList in starshipDataFromSWAPI)
            {
                if (starshipDataFromSWAPIList.Name.ToLower() == starShipInput.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

    }
}
