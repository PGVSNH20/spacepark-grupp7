﻿using SpacePark.SWAPI;
using SpacePark.Tools;
using SpacePark.Types;
using System;
using System.Collections.Generic;

namespace SpacePark
{
    class Program
    {
        static List<ParkingSpace> ParkingSpaces = new List<ParkingSpace>();
        static void Main(string[] args)
        {
            Console.WriteLine(IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), "Luke Skywalker"));
            Console.WriteLine(IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), "Lake Skyswimmer"));

            List<StarshipData> starships = StarshipFetcher.GetListOfStarships();
            foreach (StarshipData starship in starships)
            {
                Console.WriteLine($"{starship.Name} is of class {starship.Starship_Class}");
            }


            List<VehicleData> vehicles = VehicleFetcher.GetListOfVehicles();
            foreach (VehicleData v in vehicles)
            {
                Console.WriteLine($"{v.Name} is of class {v.Vehicle_Class}");
            }

        }
        private static void GenerateParkingSpaces(List<ParkingSpace> ParkingSpaces)
        {

            /* 
             Console.WriteLine("ID parkingsize?");
             var id = Console.Read();
             Console.WriteLine("Size");
             double size = Console.Read();
             ParkingSpaces.Add(new ParkingSpace() { ID = 1, Occupied = false, Size = 12.3 });


            vet ej om detta kommer att funka. jag försöker
             
            */
        }
    }

}
