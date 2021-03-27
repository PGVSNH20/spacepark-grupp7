﻿using SpacePark.Types;
using System;
using System.Collections.Generic;

namespace SpacePark.Tools
{
    class ParkingLotChecks
    {

       // ParkingLot pl = new ParkingLot();



        /* 2. Program checks to see if there are any free parking spaces. If true continue.*/
        /* 7. Program checks if there is a parking space of the appropriate size available in the parking lot.If true, continue.*/

        public static bool CheckForFreeParkingSpaces(List<StarshipData> starshipDataFromSWAPI, string starShipInput)
        {
            string starShipLength = null;

            foreach (StarshipData starshipDataFromSWAPIList in starshipDataFromSWAPI)
            {
                if (starshipDataFromSWAPIList.Name.ToLower() == starShipInput.ToLower())
                {
                    starShipLength = starshipDataFromSWAPIList.Length;
                }
            }

            //if (starShipLength != null && starShipLength != "")
            //{
            foreach (ParkingSpace item in ParkingLot.ParkingSpaces)
            {
                if (item.Occupied == false && (item.Size > 0 && item.Size <= 20 && starShipLength.ToUpper() == "SMALL"
                                                || item.Size > 20 && item.Size <= 120 && starShipLength.ToUpper() == "MEDIUM"
                                                || item.Size > 120 && item.Size <= 500 && starShipLength.ToUpper() == "LARGE"
                                                || item.Size > 500 && starShipLength.ToUpper() == "CAPITAL"))
                {
                    return true;
                }
            }
            // }
            return false;
        }
    }
}
