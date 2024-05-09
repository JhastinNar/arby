namespace ATM_machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            guna2TextBox2.PasswordChar = guna2CheckBox1.Checked ? '\0' : '*';
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "0000" && guna2TextBox2.Text == "0000")
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid PIN");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
