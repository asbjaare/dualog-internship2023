
namespace dualog_internship2023
{
    public class Ferry : Vessel
    {
        private int numberOfPassengers { get; set; }
        private int numberOfCars { get; set; }

        public Ferry(string name, string yearBuilt, int numberOfPassengers, int numberOfCars, Speed speed) : base(name, yearBuilt, speed)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.numberOfCars = numberOfCars;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n Number of Passengers: {numberOfPassengers}\n Number of Cars: {numberOfCars}\n";
        }

        public override string GetVesselInfo()
        {
            return $"{GetType().Name} {ToString()}";
        }

    }

}