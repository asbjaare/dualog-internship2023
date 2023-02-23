using System;

namespace dualog_internship2023
{
    public class Vessel
    {
        public string Name { get; }
        public int YearBuilt { get; }
        public Speed Speed { get; }
        private readonly int _maxAge = 20;

        public Vessel(string name, int yearBuilt, Speed speed)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The name can not be null", nameof(name));
            }

            if (yearBuilt > DateTime.Now.Year || yearBuilt < 0)
            {
                throw new ArgumentException("Year built invalid", nameof(yearBuilt));
            }
            else if (DateTime.Now.Year - yearBuilt > _maxAge)
            {
                // Ship to old
                throw new oldShipException();
            }


            Name = name;

            YearBuilt = yearBuilt;

            Speed = speed ?? throw new ArgumentNullException(nameof(speed));
        }

        public override string ToString()
        {
            return $"Name: {Name}\n Year Built: {YearBuilt}\n {Speed}\n";
        }

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