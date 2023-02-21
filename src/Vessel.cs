
namespace dualog_internship2023
{
    public class Vessel
    {
        private string Name { get; set; }
        private string yearBuilt { get; set; }
        // add a max age of 20 years
        private Speed speed { get; set; }

        private int maxAge = 20;
        // Get currnet year
        private int currentYear = System.DateTime.Now.Year;


        public Vessel(string name, string yearBuilt, Speed speed)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name), "The name can not be null");
            }
            Name = name;
            // the difference between the current year and the year built should be less than the max age
            // if the age is to high throw a oldShipException
            if (currentYear - int.Parse(yearBuilt) > maxAge)
            {
                throw new oldShipException();
            } else if (int.Parse(yearBuilt) > currentYear)
            {
                throw new ArgumentException("The ship is too new");
            }
            this.yearBuilt = yearBuilt;

            this.speed = speed;
        }
        
        public override string ToString()
        {
            return $"{Name} {yearBuilt}\n {speed}";
        }

        // GetVesselInfo returns the type of vessel, its name and year built
        public virtual string GetVesselInfo()
        {
            return $"{GetType().Name} {ToString()}";
        }
    }
    public class oldShipException : Exception
    {
        public oldShipException() : base("The vessel should be less than 20 years old")
        {
        }
    }
}