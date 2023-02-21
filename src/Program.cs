

namespace dualog_internship2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of new vessels
            List<Vessel> vessels = new List<Vessel>();
            // Create a new ferry
            Ferry ferry = new Ferry("Noravind", "2003", 100, 10, new Speed(20));
            // Create a new submarine
            Submarine submarine = new Submarine("KNM Ula", "2022", 100, 16, new Speed(50));

            Tugboat tugboat = new Tugboat("Bamse", "2012", 50, 8, new Speed(10));
            // Add the vessels to the list
            vessels.Add(ferry);
            vessels.Add(submarine);
            vessels.Add(tugboat);
            // Loop through the list and print the vessels
            foreach (Vessel vessel in vessels)
            {
                Console.WriteLine(vessel.GetVesselInfo());
            }
        }
    }
}