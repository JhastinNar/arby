using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_machine
{
    public partial class Form2 : Form
    {
        private string selectedBillType;
        private double amount;
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            withdraw wit = new withdraw();
            this.Hide();
            wit.Show();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            deposit dep = new deposit();
            this.Hide();
            dep.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form1 guna2 = new Form1();
            guna2.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            balance bal = new balance(selectedBillType, amount);
            this.Hide();
            bal.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            paybills pay = new paybills();
            this.Hide();
            pay.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            transaction pay = new transaction();
            this.Hide();
            pay.Show();
        }
    }
}
