
namespace dualog_internship2023
{
    public class Ferry : Vessel
    {
        public int NumberOfPassengers { get; }
        public int NumberOfCars { get; }

        public Ferry(string name, int yearBuilt, int numberOfPassengers, int numberOfCars, Speed speed) : base(name, yearBuilt, speed)
        {
            if (numberOfPassengers < 0)
            {
                throw new ArgumentException("Number of passengers can not be negative", nameof(numberOfPassengers));
            }
            if (numberOfCars < 0)
            {
                throw new ArgumentException("Number of cars can not be negative", nameof(numberOfCars));
            }
            NumberOfPassengers = numberOfPassengers;
            NumberOfCars = numberOfCars;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Number of Passengers: {NumberOfPassengers}\n Number of Cars: {NumberOfCars}\n";
        }
    }

}