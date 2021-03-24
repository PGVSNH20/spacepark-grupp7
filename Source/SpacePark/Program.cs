﻿using SpacePark.SWAPI;
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
            /*
             * Om steg 3-6-koden
             * 1. Om man skriver in en felaktig användare så går den vidare till "skriv in skepp"
             * 2. Kommer behöva flytta ut metoder och sånt i andra klasser efter att vi gjort så de fungerar korrekt.
             */
            static bool UserVerification(string userName)
            {
                bool flag;
                flag = IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), userName);

                if (flag == true)
                {
                    Console.WriteLine("This user is approved");
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong user. Try again!");
                    return false;
                }
            }

            static bool ShipVerification(string shipName)
            {
                bool flag;
                flag = ShipChecker.TestIfShipIsInStarWars(StarshipFetcher.GetListOfStarships(), shipName);

                if (flag == true)
                {
                    Console.WriteLine("This ship is approved");
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong ship.");
                    return false;
                }

            }

            string userName;
            string shipName;

            int flag = 0;
            int flag1 = 0;
            do
            {
                Console.WriteLine("Enter your username:");
                userName = Console.ReadLine();
                flag++;
            }

            while (UserVerification(userName) == false && flag != 2);

            if (flag != 2)
            {
                do {
                    Console.WriteLine("Enter your ship:");
                    shipName = Console.ReadLine();
                    flag1++;
                }
                while (ShipVerification(shipName) == false && flag1 != 2);    
            }

            /* Här kommenterat pga koden funkar ej för mig.
              
            static void ParkingVerification(string isParkShip)
            {
                bool flag;
                flag = ParkingLotChecks.CheckForFreeParkingSpaces(StarshipFetcher.GetListOfStarships(), shipName);

                if (flag == true)
                {
                    Console.WriteLine("There is a parking space available for your ship.");
                }
                else
                {
                    Console.WriteLine("No parking space available at the moment.");
                }
            }

            string isParkShip;
            Console.WriteLine("Do you want to park your ship?");
            isParkShip = Console.ReadLine();

            if (string.Equals("YES", isParkShip.ToUpper()))
            {
                ParkingVerification(isParkShip);
            }
            */

        }
    }
}