namespace dualog_internship2023
{
    public class Tugboat : Vessel
    {
        private int maxForce { get; set; }
        private int numberOfCrew { get; set; }

        public Tugboat(string name, string yearBuilt, int maxForce, int numberOfCrew, Speed speed) : base(name, yearBuilt, speed)
        {
            this.maxForce = maxForce;
            this.numberOfCrew = numberOfCrew;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n Max Force: {maxForce}\n Number of Crew: {numberOfCrew}\n";
        }

        // getVesselInfo returns the type of vessel, its name and year built
        public override string GetVesselInfo()
        {
            return $"{GetType().Name} {ToString()}";
        }
    }
}