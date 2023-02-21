using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dualog_internship2023
{
    public class Submarine : Vessel
    {
        private int maxDepth { get; set; }
        private int numberOfCrew { get; set; }

        public Submarine(string name, string yearBuilt, int maxDepth, int numberOfCrew, Speed speed) : base(name, yearBuilt, speed)
        {
            this.maxDepth = maxDepth;
            this.numberOfCrew = numberOfCrew;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n Max Depth: {maxDepth}\n Number of Crew: {numberOfCrew}\n";
        }

        public override string GetVesselInfo()
        {
            return $"{GetType().Name} {ToString()}";
        }
    }
}