using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_machine
{
    public partial class transaction : Form
    {
        public transaction()
        {
            InitializeComponent();
            LoadTransactions();
        }

        private void OKBTN_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void VIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void transaction_Load(object sender, EventArgs e)
        {
            // Load transactions from the "transaction.json" file and display in DataGridView
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            string filePath = "transaction.json";

            try
            {
                // Read transactions from file
                List<TransactionInfo> transactions = new List<TransactionInfo>();

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);

                    if (!string.IsNullOrEmpty(json))
                    {
                        // Deserialize JSON into a list of transactions
                        transactions = JsonConvert.DeserializeObject<List<TransactionInfo>>(json);
                    }
                }

                // Bind transactions list to DataGridView
                VIEW.DataSource = transactions;

                // Refresh the DataGridView to reflect the changes
                VIEW.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class TransactionInfo
        {
            public string BillType { get; set; }
            public double Amount { get; set; }
        }
    }
}
