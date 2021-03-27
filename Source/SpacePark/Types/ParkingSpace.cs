namespace SpacePark.Types
{
    public class ParkingSpace
    {
        public int ID { get; set; }
        public bool Occupied { get; set; }
        public double Size { get; set; }
        public ParkingSpace(int id, double size, bool occupied)
        {
            ID = id;
            Size = size;
            Occupied = occupied;
        }
        // Olika skepp klassas in på olika parkeringsplatser baserat på deras length-attribut
        // T.ex. kan small vara 0-20; medium 21-120; large 121-500; capital 501+
    }
}
