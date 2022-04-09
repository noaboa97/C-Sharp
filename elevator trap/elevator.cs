using System;

namespace elevator_trap
{
    public class Elevator
    {
        private double Maxweight;
        private double Currentloadweight;
        private int Currentfloor;

        public void set_maxweight(double weight)
        {
            this.Maxweight = weight;
        }

        public double get_Currentloadweight()
        {
            return this.Currentloadweight;
        }

        public int get_Currentfloor()
        {
            return this.Currentfloor;
        }

        public void Ride(int floor)
        {
            this.Currentfloor += floor;
        }

        public void add_Person(double weight)
        {
            this.Currentloadweight += weight;
        }

        public void status()
        {
            Console.WriteLine("Current Floor " + this.Currentfloor);
            Console.WriteLine("Weight: " + this.Currentloadweight);
        }

    }
}