namespace dualog_internship2023
{
    public class Tugboat : Vessel
    {
        public int MaxForce { get; }
        public int NumberOfCrew { get; }

        public Tugboat(string name, int yearBuilt, int maxForce, int numberOfCrew, Speed speed) : base(name, yearBuilt, speed)
        {
            if (maxForce < 0)
            {
                throw new ArgumentException("Max force can not be negative", nameof(maxForce));
            }
            if (numberOfCrew < 0)
            {
                throw new ArgumentException("Number of crew can not be negative", nameof(numberOfCrew));
            }

            MaxForce = maxForce;
            NumberOfCrew = numberOfCrew;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Max Force: {MaxForce}\n Number of Crew: {NumberOfCrew}\n";
        }
    }
}