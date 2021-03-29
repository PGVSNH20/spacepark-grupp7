using SpacePark.Data;
using SpacePark.Models;
using SpacePark.SWAPI;
using SpacePark.Tools;
using SpacePark.Types;
using System;

namespace SpacePark
{
    class Program
    {
        /*
       * Program flow:
     ✔️* 1. User starts the program
     ✔️* 2. Program checks to see if there are any free parking spaces. If true continue.
     ✔️* 3. Program asks user to input their name.
     ✔️* 4. Program fetches list of allowed users, and compares the name given to the list. If true, continue.
          Additionally: Create a simple table in [the database] using Entity Framework and register that the user has registered
          Also: List in the UI all completed registrations
     ✔️* 5. Program asks uses to input name of ship.
     ✔️* 6. Program fetches list of ships and checks if the ship is on the list of approved starships. If true, continue.
     ✔️* 7. Program checks if there is a parking space of the appropriate size available in the parking lot. If true, continue.
       * 8. Program gives a message to the user that parking has been allowed, says the ID of the parking space, and the expected cost of parking.
       *  Also: Add a simple menu system if time allows.
       * And done.
       */
        private static string shipName;
        public static UserRegistrationEntry registration;
        static void Main(string[] args)
        {

            ParkingLot.GenerateParkingSpaces();
            if (ParkingLotChecks.AreThereAnyFreeParkingSpaces())
            {
                registration = new UserRegistrationEntry();
                UserVerification();
                ShipVerification();
                ParkingVerification();
                registration.ParkingFee = 100; // placeholder istället för att faktiskt generera ett pris


                using EFContext context = new EFContext();  // Koppling till databasen
                context.Entries.Add(registration);          // Lägg till registreringen till databasen
                context.SaveChanges();                      // Spara inlägget

                Console.WriteLine(  $"\nInvoice\n" +
                                    $"Name:          {registration.Name}\n" +
                                    $"Ship:          {registration.ShipName}\n" +
                                    $"Parking Space: {registration.ParkingSpace}\n" +
                                    $"Fee:           {registration.ParkingFee}\n"
                                 );

            }
            PrintAllRegistrations();
            
        }

        private static void ShipVerification()
        {
            Console.WriteLine("Enter the name of the ship:");
            registration.ShipName = Console.ReadLine();

            if (ShipChecker.TestIfShipIsInStarWars(StarshipFetcher.GetListOfStarships(), registration.ShipName
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

        private static void UserVerification()
        {
            Console.WriteLine("Enter your username:");
            registration.Name = Console.ReadLine();

            if (IdentityChecker.TestIfStarWarsActor(
                PeopleFetcher.GetListOfPeople(), registration.Name
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
        private static void ParkingVerification()
        {

            if (ParkingLotChecks.CheckForFreeParkingSpaces(StarshipFetcher.GetListOfStarships(), registration.ShipName))
            {
                Console.WriteLine("There is a parking space available for your ship.");
                registration.ParkingSpace = new Random().Next(0, 126);  // Placeholder istället för att faktiskt välja en korrekt parkeringsplats
            }
            else
            {
                Console.WriteLine("No parking space available at the moment.");
            }
        }

        private static void PrintAllRegistrations()
        {
            using EFContext context = new EFContext();
            Console.WriteLine("\nListing all previously logged entries:");
            Console.WriteLine(new string('-', 20));
            foreach (UserRegistrationEntry entry in context.Entries)
            {
                Console.WriteLine($"Name:  {entry.Name}\n" +
                                  $"Id:    {entry.Id}\n" +
                                  $"Space: {entry.ParkingSpace}\n" +
                                    new string('-', 20));
            }
        }
    }
}