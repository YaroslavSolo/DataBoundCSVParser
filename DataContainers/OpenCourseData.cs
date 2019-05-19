using System;

namespace DataContainers
{
    public class OpenCourseData
    {
        /// <summary>
        /// Location of an open course
        /// </summary>
        private LocationData Location { get; set; }
        
        /// <summary>
        /// Row number
        /// </summary>
        public string RowNum { get; set; }        

        /// <summary>
        /// Name of an open course
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Address of an open course
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// To get access to Okrug
        /// </summary>
        public string Okrug
        {
            get => Location.Okrug;
            set => Location.Okrug = value;
        }

        /// <summary>
        /// To get access to Rayon
        /// </summary>
        public string Rayon
        {
            get => Location.Rayon;
            set => Location.Rayon = value;
        }

        /// <summary>
        /// Form Of incorporation of an open course
        /// </summary>
        public string FormOfIncorporation { get; set; }

        /// <summary>
        /// Submission of an open course
        /// </summary>
        public string Submission { get; set; }

        /// <summary>
        /// Type of an open course
        /// </summary>
        public string InstitutionType { get; set; }

        /// <summary>
        /// Sort of an open course
        /// </summary>
        public string InstitutionSort { get; set; }

        /// <summary>
        /// Telephone number of an open course
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Website of an open course
        /// </summary>
        public string WebsiteURL { get; set; }

        /// <summary>
        /// Email of an open course
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// To get access to X coordinate
        /// </summary>
        public double X
        {
            get => Location.X;
            set => Location.X = value;
        }

        /// <summary>
        /// To get access to Y coordinate
        /// </summary>
        public double Y
        {
            get => Location.Y;
            set => Location.Y = value;
        }

        /// <summary>
        /// Global id of an open course
        /// </summary>
        public string GlobalId { get; set; }

        /// <summary>
        /// Euclidean distance from the open course to a a given point
        /// </summary>
        /// <param name="x">x coordinate of a point</param>
        /// <param name="y">y coordinate of a point</param>
        /// <returns>distance to the point</returns>
        public double Distance(double x, double y)
        {
            return Math.Sqrt(Math.Pow(Location.X - x, 2) + Math.Pow(Location.Y - y, 2));
        }

        /// <summary>
        /// Initializes Location by default
        /// </summary>
        public OpenCourseData()
        {
            Location = new LocationData(0, 0);
        }

        /// <summary>
        /// Initializes all fields of OpenCourseData
        /// </summary>
        /// <param name="location">location of an open course</param>
        /// <param name="rowNum">row number</param>
        /// <param name="name">name of an open course</param>
        /// <param name="address">address of an open course</param>
        /// <param name="formOfIncorporation">form Of incorporation of an open course</param>
        /// <param name="submission">submission of an open course</param>
        /// <param name="institutionType">type of an open course</param>
        /// <param name="institutionSort">sort of an open course</param>
        /// <param name="telephineNumber">telephone number of an open course</param>
        /// <param name="website">website of an open course</param>
        /// <param name="email">email of an open course</param>
        /// <param name="globalid">global id of an open course</param>
        public OpenCourseData(LocationData location, string rowNum, string name, string address,
            string formOfIncorporation, string submission, string institutionType, string institutionSort,
            string telephineNumber, string website, string email, string globalid)
        {
            Location = location;
            RowNum = rowNum;                 
            Name = name;
            Address = address;
            FormOfIncorporation = formOfIncorporation;
            Submission = submission;
            InstitutionType = institutionType;
            InstitutionSort = institutionSort;
            TelephoneNumber = telephineNumber;
            WebsiteURL = website;
            Email = email;
            GlobalId = globalid;
        }
    }
}
