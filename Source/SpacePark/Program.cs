using SpacePark.SWAPI;
using SpacePark.Tools;
using SpacePark.Types;
using System;
using System.Collections.Generic;

namespace SpacePark
{
    class Program
    {
           
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