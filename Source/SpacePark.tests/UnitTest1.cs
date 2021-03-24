using NUnit.Framework;
using SpacePark.Types;
using SpacePark.Tools;
using SpacePark;
using SpacePark.SWAPI;

namespace SpacePark.tests
{
    public class Tests
    {
        /*
         * DONE: Test whether people fetcher returns list of people with entries. (Count > 0)
         * DONE: Test whether starship fetcher returns list of starships with entries. (Count > 0)
         * DONE: Test if the parking space generator generates parking spaces (Count > 0)
         * DONE: Test if the parking space generator creates small parking spaces (Count of "small" > 0)
         * DONE: Test if the parking space generator creates medium parking spaces (Count of "medium" > 0)
         * DONE: Test if the parking space generator creates large parking spaces (Count of "large" > 0)
         * DONE: Test if the parking space generator creates a massive parking space (Count of "massive" == 0)
         * DONE: Test if a valid name is authenticated by the ID-Checker.
         * DONE: Test if an invalid name is rejected by the ID-checker.
         */
        [SetUp]
        public void Setup()
        {
            ParkingLot.GenerateParkingSpaces();
        }
        [Test]
        public void IdentityChecker_Returns_True_If_Valid_Name_Is_Entered()
        {
            Assert.True(IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), "Darth Vader"));
        }
        [Test]
        public void IdentityChecker_Returns_False_If_Invalid_Name_Is_Entered()
        {
            Assert.False(IdentityChecker.TestIfStarWarsActor(PeopleFetcher.GetListOfPeople(), "Dork Waiter"));
        }
        [Test]
        public void StarshipChecker_Returns_True_If_Valid_Name_Is_Entered()
        {
            Assert.True(ShipChecker.TestIfShipIsInStarWars(StarshipFetcher.GetListOfStarships(), "Millennium Falcon"));
        }
        [Test]
        public void StarshipChecker_Returns_False_If_Invalid_Name_Is_Entered()
        {
            Assert.False(ShipChecker.TestIfShipIsInStarWars(StarshipFetcher.GetListOfStarships(), "Centennial Screechbird"));
        }
        [Test]
        public void PeopleFetcher_Returns_A_List_Of_People()
        {
            Assert.IsNotEmpty(SWAPI.PeopleFetcher.GetListOfPeople());
        }
        [Test]
        public void StarshipFetcher_Returns_A_List_Of_Starships()
        {
            Assert.IsNotEmpty(SWAPI.StarshipFetcher.GetListOfStarships());
        }
        [Test]
        public void ParkingSpaceGenerator_Creates_Parking_Spaces()
        {
            Assert.IsNotEmpty(ParkingLot.ParkingSpaces);
        }
        [Test]
        public void ParkingSpaceGenerator_Creates_At_Least_One_Parking_Space_With_Size_Less_Than_25()
        {
            bool findSmallParkingSpace = false;
            foreach (ParkingSpace ps in ParkingLot.ParkingSpaces)
            {
                if (ps.Size < 25) findSmallParkingSpace = true;
            }
            Assert.True(findSmallParkingSpace);
        }
        [Test]
        public void ParkingSpaceGenerator_Creates_At_Least_One_Parking_Space_With_Size_Between_25_And_250()
        {
            bool findSmallParkingSpace = false;
            foreach (ParkingSpace ps in ParkingLot.ParkingSpaces)
            {
                if (ps.Size >= 25)
                {
                    if (ps.Size < 250) findSmallParkingSpace = true;
                }
            }
            Assert.True(findSmallParkingSpace);
        }
        [Test]
        public void ParkingSpaceGenerator_Creates_At_Least_One_Parking_Space_With_Size_Between_250_And_5000()
        {
            bool findSmallParkingSpace = false;
            foreach (ParkingSpace ps in ParkingLot.ParkingSpaces)
            {
                if (ps.Size >= 250)
                {
                    if (ps.Size < 5000) findSmallParkingSpace = true;
                }
            }
            Assert.True(findSmallParkingSpace);
        }
        [Test]
        public void ParkingSpaceGenerator_Creates_At_Least_One_Parking_Space_With_Size_5000_Or_Higher()
        {
            bool findSmallParkingSpace = false;
            foreach (ParkingSpace ps in ParkingLot.ParkingSpaces)
            {
                if (ps.Size >= 5000) findSmallParkingSpace = true;
            }
            Assert.True(findSmallParkingSpace);
        }
    }
}