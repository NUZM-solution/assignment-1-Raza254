namespace Ass2_Q1
{
    public partial class Form1 : Form
    {
        Double count;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "Ali Raza" && password == "22011556-007")
            {
                MessageBox.Show("Welcome User.");
            }
            else
            {
                count = count + 1;
                double maxcount = 3;
                double remain = maxcount - count;
                MessageBox.Show("Incorrect username or password.");
                textBox2.Clear();
                textBox1.Clear();
                textBox1.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max tries exceeded.");
                    Application.Exit(); 
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "";
            textBox2.Text = string.Empty;
            textBox2.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
