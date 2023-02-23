namespace dualog_internship2023
{
    public class Submarine : Vessel
    {
        public int MaxDepth { get; }
        public int NumberOfCrew { get; }

        public Submarine(string name, int yearBuilt, int maxDepth, int numberOfCrew, Speed speed) : base(name, yearBuilt, speed)
        {
            if (maxDepth < 0)
            {
                throw new ArgumentException("Max depth can not be negative", nameof(maxDepth));
            }
            if (numberOfCrew < 0)
            {
                throw new ArgumentException("Number of crew can not be negative", nameof(numberOfCrew));
            }
            MaxDepth = maxDepth;
            NumberOfCrew = numberOfCrew;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Max Depth: {MaxDepth}\n Number of Crew: {NumberOfCrew}\n";
        }
    }
}