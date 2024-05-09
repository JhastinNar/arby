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
    public partial class balance : Form
    {
        public string SelectedBillType { get; set; }
        public balance(string selectedBillType, double amount)
        {
            InitializeComponent();
            this.SelectedBillType = SelectedBillType;
            billPay.Text = SelectedBillType;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void balance_Load(object sender, EventArgs e)
        {
            label3.Text = $"{Pub.savings}";
        }

        private void billPay_Click(object sender, EventArgs e)
        {
            billPay.Text = SelectedBillType.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
