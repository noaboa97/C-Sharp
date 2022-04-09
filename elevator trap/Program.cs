namespace elevator_trap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Elevator mainhall = new Elevator();
            
            mainhall.set_maxweight(300);
            mainhall.add_Person(75);
            mainhall.Ride(3);
            mainhall.status();
        }
    }
}