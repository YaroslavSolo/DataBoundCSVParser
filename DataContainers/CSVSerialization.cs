using System;
using System.Collections.Generic;
using System.Text;

namespace DataContainers
{
    public static class CSVSerialization
    {
        /// <summary>
        /// Delimiter for cells in csv format
        /// </summary>
        private const char Delimiter = ';';

        /// <summary>
        /// Qoutation mark in csv format
        /// </summary>
        private const char QuotationMark = '"';

        /// <summary>
        /// Number of columns needed to serialize
        /// </summary>
        private const int NumberOfColumns = 15;

        /// <summary>
        /// Converts list of OpenCourseData objects to csv format
        /// </summary>
        /// <param name="list">serialized list of objects</param>
        /// <returns>rows in csv format</returns>
        public static List<string> ToCSV(List<OpenCourseData> list)
        {
            List<string> converted = new List<string>();

            foreach (var i in list)
            {
                string fixedGlobalId = Wrap(i.GlobalId);
                fixedGlobalId = fixedGlobalId.Substring(0, fixedGlobalId.Length - 1);

                string str = Wrap(i.RowNum) + Wrap(i.Name) + Wrap(i.Address) + Wrap(i.Okrug) +
                    Wrap(i.Rayon) + Wrap(i.FormOfIncorporation) + Wrap(i.Submission) + Wrap(i.InstitutionType) +
                    Wrap(i.InstitutionSort) + Wrap(i.TelephoneNumber) + Wrap(i.WebsiteURL) + 
                    Wrap(i.Email) + Wrap(i.X.ToString()) + Wrap(i.Y.ToString()) + fixedGlobalId;

                converted.Add(str);
            }

            return converted;
        }

        /// <summary>
        /// Wraps a cell
        /// </summary>
        /// <param name="str">single cell of a row</param>
        /// <returns>cell in csv format</returns>
        private static string Wrap(string str)
        {
            if (str == null)
            {
                return "\"\";";
            }

            // Doubling quotation marks inside cell
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1) == "\"")
                {
                    str = str.Insert(i, "\"");
                    i++;
                }
            }

            return $"\"{str}\";";
        }

        /// <summary>
        /// Serializes list of csv rows
        /// </summary>
        /// <param name="list">list of rows in csv format</param>
        /// <returns>serialized list of rows</returns>
        public static List<OpenCourseData> Parse(List<string> list)
        {
            List<string>[] NonSerializedFile = new List<string>[list.Count];

            // Creating list of single cells
            for (int i = 0; i < list.Count; i++)
            {
                NonSerializedFile[i] = ParseLine(list[i]);            
            }

            List<OpenCourseData> SerializedFile = new List<OpenCourseData>();

            // Ignore if the first line is header
            int start = 0;
            var temp = NonSerializedFile[0];
            if (temp[12] == "X" && temp[13] == "Y")
                start++;

            for (int i = start; i < NonSerializedFile.Length; i++)
            {
                if (NonSerializedFile[i].Count != NumberOfColumns)
                    throw new ArgumentException($"Invalid number of columns in row {i}: {NonSerializedFile[i].Count}.");

                temp = NonSerializedFile[i];
                SerializedFile.Add(new OpenCourseData(new LocationData(temp[3], temp[4], temp[12], temp[13]), temp[0],
                    temp[1], temp[2], temp[5], temp[6], temp[7], temp[8], temp[9], temp[10], temp[11], temp[14]));
            }

            return SerializedFile;
        }

        /// <summary>
        /// Parses one line in csv
        /// </summary>
        /// <param name="line">line in csv</param>
        /// <returns>list of cells</returns>
        private static List<string> ParseLine(string line)
        {
            List<string> ParsedLine = new List<string>();

            int p = 0;
            while (true)
            {
                string cell = ParseNextCell(line, ref p);

                // If next all cells are read, stop
                if (cell == null)
                    break;

                ParsedLine.Add(cell);
            }
                     
            return ParsedLine;
        }

        /// <summary>
        /// Returns pointer after delimiter in line
        /// </summary>
        /// <param name="line">line to parse</param>
        /// <param name="p">pointer</param>
        /// <returns>pointer</returns>
        private static string ParseNextCell(string line, ref int p)
        {
            if (p >= line.Length)
                return null;

            if (line[p] != QuotationMark)
                return ParseNotEscapedCell(line, ref p);
            else
                return ParseEscapedCell(line, ref p);
        }

        /// <summary>
        /// Returns pointer after delimiter after not escaped cell
        /// </summary>
        /// <param name="line">line to parse</param>
        /// <param name="i">pointer</param>
        /// <returns>pointer</returns>
        private static string ParseNotEscapedCell(string line, ref int p)
        {
            StringBuilder builder = new StringBuilder();

            while (true)
            {
                // End of line
                if (p >= line.Length)
                    break;

                if (line[p] == Delimiter)
                {
                    p++;
                    break;
                }

                builder.Append(line[p]);
                p++;
            }

            return builder.ToString();
        }

        /// <summary>
        /// Returns pointer after delimiter after an escaped cell
        /// </summary>
        /// <param name="line">line to parse</param>
        /// <param name="i">pointer</param>
        /// <returns>pointer</returns>
        private static string ParseEscapedCell(string line, ref int p)
        {
            p++;
            StringBuilder builder = new StringBuilder();

            while (true)
            {
                // End of line
                if (p >= line.Length)
                    break;

                if (line[p] == QuotationMark)
                {
                    p++; 

                    if (p >= line.Length)
                    {
                        break;
                    }

                    if (line[p] == Delimiter)
                    {
                        p++;
                        break;
                    }
                }

                builder.Append(line[p]);
                p++;
            }

            return builder.ToString();
        }
    }
}
