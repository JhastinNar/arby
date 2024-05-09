
namespace ATM_machine
{
    partial class withdraw
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(withdraw));
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            textBox1 = new TextBox();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Silver;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(129, 510);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(127, 35);
            guna2Button1.TabIndex = 22;
            guna2Button1.Text = "Cancel";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(158, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 26);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // guna2Button4
            // 
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BorderRadius = 20;
            guna2Button4.CustomizableEdges = customizableEdges3;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Gainsboro;
            guna2Button4.Font = new Font("Segoe UI", 9F);
            guna2Button4.ForeColor = Color.Black;
            guna2Button4.Location = new Point(129, 469);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button4.Size = new Size(127, 35);
            guna2Button4.TabIndex = 20;
            guna2Button4.Text = "Withdraw";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(47, 241);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 19;
            label2.Text = "Amount :";
            label2.Click += label1_Click;
            // 
            // withdraw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(391, 557);
            Controls.Add(guna2Button1);
            Controls.Add(textBox1);
            Controls.Add(guna2Button4);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "withdraw";
            Load += withdraw_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void withdraw_Load(object sender, EventArgs e)
        {
                    
        }

#endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Label label2;
    }
}