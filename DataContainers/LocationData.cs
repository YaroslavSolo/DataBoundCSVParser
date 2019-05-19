using System;

namespace DataContainers
{
    public class LocationData
    {
        private double _x;

        private double _y;

        /// <summary>
        /// Name of okrug where open course is located
        /// </summary>
        public string Okrug { get; set; }

        /// <summary>
        /// Name of rayon where open course is located
        /// </summary>
        public string Rayon { get; set; }

        /// <summary>
        /// For casting X coordinate to double
        /// </summary>
        private string XStr
        {
            set
            {
                if (!double.TryParse(value, out double xdouble))
                    throw new ArgumentException("X coordinate should be double.");
                else
                    X = xdouble;
            }
        }

        /// <summary>
        /// For casting X coordinate to double
        /// </summary>
        private string YStr
        {
            set
            {
                if (!double.TryParse(value, out double ydouble))
                    throw new ArgumentException("Y coordinate should be double.");
                else
                    Y = ydouble;
            }
        }

        /// <summary>
        /// X coordinate of an open course
        /// </summary>
        public double X
        {
            get => _x;

            set
            {
                if (value >= 0)
                {
                    _x = value;
                }
                else
                {
                    throw new ArgumentException("X coordinate should be a positive value or zero.");
                }
            }
        }

        /// <summary>
        /// Y coordinate of an open course
        /// </summary>
        public double Y
        {
            get => _y;

            set
            {
                if (value >= 0)
                {
                    _y = value;
                }
                else
                {
                    throw new ArgumentException("Y coordinate should be a positive value or zero.");
                }
            }
        }

        /// <summary>
        /// Initializes x and y coordinates
        /// </summary>
        /// <param name="x">x coordinate of an open course</param>
        /// <param name="y">y coordinate of an open course</param>
        public LocationData(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Initializes all fiels of LocationData instance
        /// </summary>
        /// <param name="okrug">Name of okrug where open course is located</param>
        /// <param name="rayon">name of rayon where open course is located</param>
        /// <param name="x">x coordinate of an open course</param>
        /// <param name="y">y coordinate of an open course</param>
        public LocationData(string okrug, string rayon, string x, string y)
        {
            Okrug = okrug;
            Rayon = rayon;
            XStr = x;
            YStr = y;
        }
    }
}
