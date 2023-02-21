
namespace dualog_internship2023
{
    public class Speed : IFormattable
    {
        private double speed;

        public Speed(double speed)
        {
            this.speed = speed;
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (format == null)
            {
                format = "KN";
            }
            if (format == "KN")
            {
                return $"Speed: {speed} knots";
            }
            else if (format == "MS")
            {
                return $"Speed: {speed * 0.514444} m/s";
            }
            else
            {
                throw new FormatException($"The {format} format string is not supported.");
            }
        }
    }

}