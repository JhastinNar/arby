namespace ATM_machine
{
    partial class balance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(balance));
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            billPay = new Label();
            SuspendLayout();
            // 
            // guna2Button4
            // 
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BorderRadius = 17;
            guna2Button4.CustomizableEdges = customizableEdges1;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Silver;
            guna2Button4.Font = new Font("Segoe UI", 9F);
            guna2Button4.ForeColor = Color.Black;
            guna2Button4.Location = new Point(139, 509);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button4.Size = new Size(111, 36);
            guna2Button4.TabIndex = 14;
            guna2Button4.Text = "Cancel";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(68, 251);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 10;
            label1.Text = "Your Balance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(199, 251);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 12;
            label3.Text = "BalanceinRs";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(68, 285);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 15;
            label2.Text = "Chosen Company:";
            // 
            // billPay
            // 
            billPay.AutoSize = true;
            billPay.BackColor = Color.Gainsboro;
            billPay.Font = new Font("Segoe UI", 14.25F);
            billPay.Location = new Point(238, 285);
            billPay.Name = "billPay";
            billPay.Size = new Size(36, 25);
            billPay.TabIndex = 16;
            billPay.Text = "***";
            billPay.Click += billPay_Click;
            // 
            // balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(391, 557);
            Controls.Add(billPay);
            Controls.Add(label2);
            Controls.Add(guna2Button4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "balance";
            Load += balance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label billPay;
    }
}