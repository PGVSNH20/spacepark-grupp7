using SpacePark.SWAPI;
using SpacePark.Tools;
using SpacePark.Types;
using System;
using System.Collections.Generic;

namespace SpacePark
{
    class Program
    {
        /*
             * Program flow:
             * 1. User starts the program
             * 2. Program checks to see if there are any free parking spaces. If true continue.
           ✔️* 3. Program asks user to input their name.
           ✔️* 4. Program fetches list of allowed users, and compares the name given to the list. If true, continue.
           ✔️* 5. Program asks uses to input name of ship.
           ✔️* 6. Program fetches list of ships and checks if the ship is on the list of approved starships. If true, continue.
             * 7. Program checks if there is a parking space of the appropriate size available in the parking lot. If true, continue.
             * 8. Program gives a message to the user that parking has been allowed, says the ID of the parking space, and the expected cost of parking.
             * And done.
             */

        static List<ParkingSpace> ParkingSpaces = new List<ParkingSpace>();
        static void Main(string[] args)
        {

            static void UserVerification(string userName)
            {
                bool flag;

                flag = IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), userName);

                if (flag == true)
                {
                    Console.WriteLine("This user is approved");
                }
                else
                {
                    Console.WriteLine("Wrong user.");
                }
            }

            string userName;
            Console.WriteLine("Enter your username:");
            userName = Console.ReadLine();
            UserVerification(userName);

            static void ShipVerification(string shipName)
            {
                bool flag;
                flag = ShipChecker.TestIfShipIsInStarWars(StarshipFetcher.GetListOfStarships(), shipName);

                if (flag == true)
                {
                    Console.WriteLine("This ship is approved");
                }
                else
                {
                    Console.WriteLine("Wrong ship.");
                }

            }
            string shipName;
            Console.WriteLine("Enter your ship:");
            shipName = Console.ReadLine();
            ShipVerification(shipName);

            /*

                  GenerateParkingSpaces();

                  Console.WriteLine(IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), "Luke Skywalker"));
                  Console.WriteLine(IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), "Lake Skyswimmer"));

                  List<StarshipData> starships = StarshipFetcher.GetListOfStarships();
                  foreach (StarshipData starship in starships)
                  {
                      Console.WriteLine($"{starship.Name} is of class {starship.Starship_Class}");
                  }
                 */

        }
        private static void GenerateParkingSpaces()
        {

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