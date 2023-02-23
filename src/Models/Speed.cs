
namespace dualog_internship2023
{
    public class Speed : IFormattable
    {
        public double SpeedValue { get; }

        public Speed(double speed)
        {
            if (speed < 0)
            {
                throw new ArgumentException("Speed can not be negative", nameof(speed));
            }
            SpeedValue = speed;
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (format == null)
            {
                format = "KN";
            }
            if (format == "KN")
            {
                return $"Speed: {SpeedValue} knots";
            }
            else if (format == "MS")
            {
                return $"Speed: {SpeedValue * 0.514444} m/s";
            }
            else
            {
                throw new FormatException($"The {format} format string is not supported.");
            }
        }
    }
}