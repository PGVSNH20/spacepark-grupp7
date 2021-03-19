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
            List<PersonalData> lpd = PeopleFetcher.GetListOfPeople();
            foreach (PersonalData pd in lpd)
            {
                Console.WriteLine(pd.Name);
            }



        }
        private static void GenerateParkingSpaces()
        {
            throw new NotImplementedException();
        }
    }

}
