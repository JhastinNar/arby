using Newtonsoft.Json;
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
    public partial class deposit : Form
    {
        private string selectedBillType;
        public deposit()
        {
            InitializeComponent();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void deposit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            double amount;
            // Parse the text to double
            double.TryParse(amountTextBox.Text, out amount);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            double amount;

            // Check if the text in amountTextBox is convertible to double
            if (double.TryParse(amountTextBox.Text, out amount))
            {
                // Optionally, you can update the cheque and savings variables here if needed
                Pub.cheque += amount;
                Pub.savings += amount;

                // Create an object to represent the deposit transaction
                TransactionInfo depositTransaction = new TransactionInfo
                {
                    BillType = "Deposit",
                    Amount = amount
                };

                // Save the deposit transaction to the "transaction.json" file
                SaveTransaction(depositTransaction);

                // Show receipt form
                balance showreceipt = new balance(selectedBillType, amount);
                this.Hide();
                showreceipt.Show();
            }
            else
            {
                // Display an error message or take appropriate action if the input is not a valid double
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveTransaction(TransactionInfo transaction)
        {
            string filePath = "transaction.json";

            try
            {
                // Read existing transactions from file
                List<TransactionInfo> transactions = new List<TransactionInfo>();

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);

                    if (!string.IsNullOrEmpty(json)) // Check if JSON string is not null or empty
                    {
                        transactions = JsonConvert.DeserializeObject<List<TransactionInfo>>(json);
                    }
                }

                // Add the new transaction to the list
                transactions.Add(transaction);

                // Serialize the transactions list to JSON with formatting
                string transactionsJson = JsonConvert.SerializeObject(transactions, Formatting.Indented);

                // Write the JSON to the file
                File.WriteAllText(filePath, transactionsJson);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during file operations or JSON serialization
                MessageBox.Show($"Error saving transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class TransactionInfo
    {
        public string BillType { get; set; }
        public double Amount { get; set; }
    }
}

