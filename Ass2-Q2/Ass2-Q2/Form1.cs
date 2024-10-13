using System.Data;

namespace Ass2_Q2
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            // Define columns with updated data types
            dt.Columns.Add("ROLL NO", typeof(string)); // Changed from int to string
            dt.Columns.Add("NAME", typeof(string));
            dt.Columns.Add("DOB", typeof(string)); // You can also use DateTime if you prefer
            dt.Columns.Add("CGPA", typeof(decimal)); // Changed from int to decimal

            // Bind the DataTable to DataGridView
            dataGridView1.DataSource = dt;

            // Adjust column width so data fits properly
            dataGridView1.Columns["ROLL NO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  // Adjust width for roll number
            dataGridView1.Columns["NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;     // Adjust width for name
            dataGridView1.Columns["DOB"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;      // Adjust width for DOB
            dataGridView1.Columns["CGPA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;      // Adjust width for CGPA
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add new row with input data
            DataRow newRow = dt.NewRow();
            newRow["ROLL NO"] = textBox1.Text;                // Roll number as string (e.g., "22011556-007")
            newRow["NAME"] = textBox2.Text;                   // Name
            newRow["DOB"] = dateTimePicker1.Value.ToShortDateString();  // Date of birth from DateTimePicker
            newRow["CGPA"] = Convert.ToDecimal(textBox4.Text); // CGPA as decimal (e.g., 3.45)

            // Add row to the DataTable
            dt.Rows.Add(newRow);

            // Clear input fields for next entry
            ClearFields();
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }
    }
}
