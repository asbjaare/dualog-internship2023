namespace tests;
using dualog_internship2023;

public class UnitTest1
{
    [Fact]
    public void ConstructorTest()
    {
        Ferry ferry = new Ferry("Noravind", 2003, 100, 10, new Speed(20));
        Tugboat tugboat = new Tugboat("Bamse", 2012, 50, 8, new Speed(8));
        Submarine submarine = new Submarine("KNM Ula", 2022, 100, 16, new Speed(50));

        // Vessel values
        Assert.Equal("Noravind", ferry.Name);
        Assert.Equal(2003, ferry.YearBuilt);
        Assert.Equal(20, ferry.Speed.SpeedValue);

        // Ferry specific values
        Assert.Equal(100, ferry.NumberOfPassengers);
        Assert.Equal(10, ferry.NumberOfCars);

        // Tugboat specific values
        Assert.Equal(50, tugboat.MaxForce);
        Assert.Equal(8, tugboat.NumberOfCrew);

        // Submarine specific values
        Assert.Equal(100, submarine.MaxDepth);
        Assert.Equal(16, submarine.NumberOfCrew);
    }

    [Fact]
    public void ToStringTest()
    {
        Ferry ferry = new Ferry("Noravind", 2003, 100, 10, new Speed(20));
        Assert.Equal("Name: Noravind\n Year Built: 2003\n Speed: 20 knots\n Number of Passengers: 100\n Number of Cars: 10\n", ferry.ToString());
    }

    [Fact]
    public void GetVesselInfoTest()
    {
        Ferry ferry = new Ferry("Noravind", 2003, 100, 10, new Speed(20));
        Assert.Equal("Ferry Name: Noravind\n Year Built: 2003\n Speed: 20 knots\n Number of Passengers: 100\n Number of Cars: 10\n", ferry.GetVesselInfo());
    }

    [Fact]
    public void SpeedFormatTest()
    {
        Speed speed = new Speed(20);
        Assert.Equal("Speed: 20 knots", speed.ToString("KN", null));
        Assert.Equal("Speed: 20 knots", speed.ToString(null, null));
        Assert.Equal("Speed: 10.28888 m/s", speed.ToString("MS", null));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-100)]
    public void SpeedNegativeValueTest(double speed)
    {
        Assert.Throws<ArgumentException>(() => new Speed(speed));
    }

    [Theory]
    [InlineData(20)]
    [InlineData(100)]
    public void ShipToOldTest(int yearBuilt)
    {
        Assert.Throws<oldShipException>(() => new Ferry("Noravind", yearBuilt, 1, 1, new Speed(20)));
    }

    [Fact]
    public void InvalidInputTest()
    {

        Assert.Throws<ArgumentNullException>(() => new Ferry("", 2003, 1, 1, new Speed(20)));
        Assert.Throws<ArgumentException>(() => new Ferry("Noravind", -1, 1, 1, new Speed(20)));
        Assert.Throws<ArgumentException>(() => new Ferry("Noravind", 2003, -1, 1, new Speed(20)));
        Assert.Throws<ArgumentException>(() => new Ferry("Noravind", 2003, 1, -1, new Speed(20)));
        Assert.Throws<ArgumentNullException>(() => new Ferry("Noravind", 2003, 1, 1, null));
    }
}