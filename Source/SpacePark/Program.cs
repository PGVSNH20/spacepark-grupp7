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
           ✔️* 5. Program asks uses to input name of ship.
           ✔️* 6. Program fetches list of ships and checks if the ship is on the list of approved starships. If true, continue.
             * 7. Program checks if there is a parking space of the appropriate size available in the parking lot. If true, continue.
             * 8. Program gives a message to the user that parking has been allowed, says the ID of the parking space, and the expected cost of parking.
             * And done.
             */

        static void Main(string[] args)
        {
            /*
             * Om steg 3-6-koden
             * 1. Om man skriver in en felaktig användare så går den vidare till "skriv in skepp"
             * 2. Kommer behöva flytta ut metoder och sånt i andra klasser efter att vi gjort så de fungerar korrekt.
             */
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


        }
    }
}