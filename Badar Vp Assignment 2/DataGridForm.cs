using System;
using System.Windows.Forms;

namespace LoginAndDataGridApp
{
    public partial class DataGridForm : Form
    {
        public DataGridForm()
        {
            InitializeComponent(); // Ensure this is called without parameters
            LoadCourseData();  // Load data on form load
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            // Add initialization code here if needed.
        }

        // Function to load course data into DataGridView
        private void LoadCourseData()
        {
            dataGridViewCourses.ColumnCount = 5;
            dataGridViewCourses.Columns[0].Name = "Course Code";
            dataGridViewCourses.Columns[1].Name = "Course Title";
            dataGridViewCourses.Columns[2].Name = "Obtained Marks";
            dataGridViewCourses.Columns[3].Name = "Grade";
            dataGridViewCourses.Columns[4].Name = "Status";

            // Example data
            string[] row1 = { "IT101", "Visual Programming", "85", "A+", "Pass" };
            string[] row2 = { "IT102", "Data Structures", "70", "B+", "Pass" };
            string[] row3 = { "IT103", "Linear Algebra", "75", "A", "Pass" };

            dataGridViewCourses.Rows.Add(row1);
            dataGridViewCourses.Rows.Add(row2);
            dataGridViewCourses.Rows.Add(row3);
        }

        private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"Cell clicked: Row {e.RowIndex}, Column {e.ColumnIndex}");
        }
    }
}
