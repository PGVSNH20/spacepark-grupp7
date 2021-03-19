using SpacePark.SWAPI;
using SpacePark.Tools;
using System;

namespace SpacePark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), "Luke Skywalker"));
            Console.WriteLine(IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), "Lake Skyswimmer"));



        }
    }
}
