using SpacePark.SWAPI;
using SpacePark.Tools;
using SpacePark.Types;
using System;
using System.Collections.Generic;

namespace SpacePark
{
    class Program
    {
        List<ParkingSpace> ParkingSpaces = new List<ParkingSpace>();
        static void Main(string[] args)
        {
            Console.WriteLine(IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), "Luke Skywalker"));
            Console.WriteLine(IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), "Lake Skyswimmer"));



        }
        private static void GenerateParkingSpaces()
        {
            throw new NotImplementedException();
        }
    }

}
