namespace DriverSearch
{
    public class Driver
    {
        public int Id { get; }
        public double X { get; }
        public double Y { get; }

        public Driver(int id, double x, double y)
        {
            Id = id;
            X = x;
            Y = y;
        }
    }
}