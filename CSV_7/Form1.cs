using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataContainers;
using System.IO;

namespace CSV_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Adding DataError handler for DataGridView
            DataGridView.DataError += new DataGridViewDataErrorEventHandler(DataGrid_DataError);

            // Adding types of ordering
            SelectSort.Items.AddRange(new string[] { "Rayon", "Institution sort", "Distance" });
            SelectSort.SelectedIndex = 0;

            // Adding types of filtering
            SelectFilter.Items.AddRange(new string[] { "Form of incorp", "Institution sort" });
            SelectFilter.SelectedIndex = 0;

            DataGridView.DataSource = new BindingSource(SerializedData, null);
        }

        /// <summary>
        /// true if filter was used or the number of rows is larger than the number
        /// of rows that need to be displayed
        /// </summary>
        public static bool filterUsed = false;

        /// <summary>
        /// Current file path
        /// </summary>
        public static string CurrentFilePath;

        /// <summary>
        /// Full list of data
        /// </summary>
        public static List<OpenCourseData> SerializedData = new List<OpenCourseData>();

        /// <summary>
        /// List of displayed data
        /// </summary>
        public static List<OpenCourseData> SerializedDataHalved = new List<OpenCourseData>();

        private void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong data format", "Error");
        }

        /// <summary>
        /// To open file and load data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = OpenFileDialog.FileName;             
                List<string> UnparsedLines = new List<string>();

                try
                {
                    using (StreamReader fs = new StreamReader(CurrentFilePath, Encoding.Default))
                    {
                        while (!fs.EndOfStream)
                        {
                            UnparsedLines.Add(fs.ReadLine());
                        }
                    }

                    SerializedData = CSVSerialization.Parse(UnparsedLines);

                    // Checking if list if displayed data is needed
                    if (SerializedData.Count <= NumberOfRows.Value)
                    {
                        filterUsed = false;
                        DataGridView.DataSource = new BindingSource(SerializedData, null);
                    }        
                    else
                    {                     
                        for (int i = 0; i < NumberOfRows.Value; i++)
                        {                      
                            SerializedDataHalved.Add(SerializedData[i]);
                            DataGridView.DataSource = new BindingSource(SerializedDataHalved, null);
                            filterUsed = true;
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("File is used by another process", "Error");
                    CurrentFilePath = null;
                    SerializedData = null;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Wrong data format, cant open file\n{ex.Message}", "Error");
                    CurrentFilePath = null;
                    SerializedData = null;
                }          
            }
        }

        /// <summary>
        /// To save current file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentFilePath != null)
            {
                List<string> convertedLines = CSVSerialization.ToCSV(SerializedData);
                FileStream fs = new FileStream(CurrentFilePath, FileMode.Create);

                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (var item in convertedLines)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("No current file availible, please use \"Save as\" option", "Error");
            }
        }

        /// <summary>
        /// To save as new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = SaveFileDialog.FileName;
                List<string> convertedLines = CSVSerialization.ToCSV(SerializedData);

                File.WriteAllLines(CurrentFilePath, convertedLines, Encoding.Default);            
            }
        }

        /// <summary>
        /// Append to existing file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void appendToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppendFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = AppendFileDialog.FileName;
                List<string> convertedLines = CSVSerialization.ToCSV(SerializedData);
                FileStream fs = new FileStream(CurrentFilePath, FileMode.Append);

                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (var item in convertedLines)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
        }

        /// <summary>
        /// Delete selected row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow != null)
            {
                int num = DataGridView.CurrentRow.Index;
                DataGridView.Rows.Remove(DataGridView.Rows[num]);
            }         
        }

        /// <summary>
        /// Sort by chosen property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectSort.SelectedIndex)
            {
                case 0:
                    var temp = from i in SerializedData
                               orderby i.Rayon
                               select i;
                    SerializedData = temp.ToList();

                    // If all the rows shouldnt be displayed or a filter was used
                    if (filterUsed)
                    {
                        temp = from i in SerializedDataHalved
                               orderby i.Rayon
                               select i;
                        SerializedDataHalved = temp.ToList();
                        DataGridView.DataSource = new BindingSource(SerializedDataHalved, null);
                    }
                    else
                        DataGridView.DataSource = new BindingSource(SerializedData, null);
                    break;
                case 1:
                    var temp1 = from i in SerializedData
                                orderby i.InstitutionSort
                                select i;
                    SerializedData = temp1.ToList();

                    // If all the rows shouldnt be displayed or a filter was used
                    if (filterUsed)
                    {
                        temp1 = from i in SerializedDataHalved
                                orderby i.Rayon
                                select i;
                        SerializedDataHalved = temp1.ToList();
                        DataGridView.DataSource = new BindingSource(SerializedDataHalved, null);
                    }
                    else
                        DataGridView.DataSource = new BindingSource(SerializedData, null);
                    break;
                case 2:
                    var temp2 = from i in SerializedData
                                orderby i.Distance((double)NumericXCoord.Value, (double)NumericYCoord.Value)
                                select i;
                    SerializedData = temp2.ToList();

                    // If all the rows shouldnt be displayed or a filter was used
                    if (filterUsed)
                    {
                        temp2 = from i in SerializedDataHalved
                                orderby i.Rayon
                                select i;
                        SerializedDataHalved = temp2.ToList();
                        DataGridView.DataSource = new BindingSource(SerializedDataHalved, null);
                    }
                    else
                        DataGridView.DataSource = new BindingSource(SerializedData, null);
                    break;
            }
        }

        /// <summary>
        /// Filter by the key word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectFilter.SelectedIndex)
            {
                case 0:
                    var temp = from i in SerializedData
                               where i.FormOfIncorporation == FilterKey.Text
                               select i;
                    SerializedDataHalved = temp.ToList();

                    List<OpenCourseData> SerializedDataHalved2 = new List<OpenCourseData>();

                    // If all the rows shouldnt be displayed
                    for (int i = 0; (i < NumberOfRows.Value) && (i < SerializedDataHalved.Count); i++)
                    {
                        SerializedDataHalved2.Add(SerializedDataHalved[i]);
                    }

                    DataGridView.DataSource = new BindingSource(SerializedDataHalved2, null);
                    filterUsed = true;
                    break;
                case 1:
                    var temp1 = from i in SerializedData
                                where i.InstitutionSort == FilterKey.Text
                                select i;
                    SerializedDataHalved = temp1.ToList();

                    List<OpenCourseData> SerializedDataHalved3 = new List<OpenCourseData>();

                    // If all the rows shouldnt be displayed
                    for (int i = 0; (i < NumberOfRows.Value) && (i < SerializedDataHalved.Count); i++)
                    {
                        SerializedDataHalved3.Add(SerializedDataHalved[i]);
                    }

                    DataGridView.DataSource = new BindingSource(SerializedDataHalved3, null);
                    filterUsed = true; 
                    break;
            }
        }

        /// <summary>
        /// Useless button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats! You're the first person to click this button", "About");
        }

        /// <summary>
        /// Display another number of rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberOfRows_ValueChanged(object sender, EventArgs e)
        {  
            // Display all if the number is larger than the number of rows availible
            if (SerializedData.Count <= NumberOfRows.Value)
            {
                DataGridView.DataSource = new BindingSource(SerializedData, null);
                filterUsed = false;
            }
            else
            {
                SerializedDataHalved = new List<OpenCourseData>();

                for (int i = 0; i < NumberOfRows.Value; i++)
                {
                    SerializedDataHalved.Add(SerializedData[i]);
                    DataGridView.DataSource = new BindingSource(SerializedDataHalved, null);
                    filterUsed = true;
                }
            }
        }
    }
}
