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
          Additionally: Create a simple table in [the database] using Entity Framework and register that the user has registered
          Also: List in the UI all completed registrations
     ✔️* 5. Program asks uses to input name of ship.
     ✔️* 6. Program fetches list of ships and checks if the ship is on the list of approved starships. If true, continue.
       * 7. Program checks if there is a parking space of the appropriate size available in the parking lot. If true, continue.
       * 8. Program gives a message to the user that parking has been allowed, says the ID of the parking space, and the expected cost of parking.
       *  Also: Add a simple menu system if time allows.
       * And done.
       */
        static void Main(string[] args)
        {
            static void UserVerification()
            {
                Console.WriteLine("Enter your username:");

                if (IdentityChecker.TestIfStarWarsActor(
                    PeopleFetcher.GetListOfPeople(), Console.ReadLine()
                    ))
                {
                    Console.WriteLine("This user is approved");
                }
                else
                {
                    Console.WriteLine("Wrong user. Try again!");
                    UserVerification();
                }
            }

            static void ShipVerification()
            {
                Console.WriteLine("Enter the name of the ship:");

                if (ShipChecker.TestIfShipIsInStarWars(StarshipFetcher.GetListOfStarships(), Console.ReadLine()
                    ))
                {
                    Console.WriteLine("This ship is approved");
                }
                else
                {
                    Console.WriteLine("Wrong ship. Try again");
                    ShipVerification();
                }

            }

            UserVerification();
            ShipVerification();

            /*string userName;
            string shipName;

            int flag = 0;
            int flag1 = 0;
            do
            {
              
                userName = Console.ReadLine();
                flag++;
            } while (UserVerification(userName) == false && flag != 2);
            
            if (flag != 2)
            {
                do {
                    Console.WriteLine("Enter your ship:");
                    shipName = Console.ReadLine();
                    flag1++;
                } while (ShipVerification(shipName) == false && flag1 != 2);    
            }
            */

            

            string isParkShip;
            Console.WriteLine("Do you want to park your ship? (yes/no)");
            isParkShip = Console.ReadLine();

            if (string.Equals("YES", isParkShip.ToUpper()))
            {
                ParkingVerification();
            }

        }
        private static void ParkingVerification()
        {
            string shipName = Console.ReadLine();

            if (ParkingLotChecks.CheckForFreeParkingSpaces(StarshipFetcher.GetListOfStarships(), shipName))
            {
                Console.WriteLine("There is a parking space available for your ship.");
            }
            else
            {
                Console.WriteLine("No parking space available at the moment.");
            }
        }

    }
    }