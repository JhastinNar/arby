namespace ATM_machine
{
    partial class transaction
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            VIEW = new Guna.UI2.WinForms.Guna2DataGridView();
            OKBTN = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)VIEW).BeginInit();
            SuspendLayout();
            // 
            // VIEW
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            VIEW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            VIEW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            VIEW.ColumnHeadersHeight = 4;
            VIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            VIEW.DefaultCellStyle = dataGridViewCellStyle3;
            VIEW.GridColor = Color.FromArgb(231, 229, 255);
            VIEW.Location = new Point(25, 59);
            VIEW.Name = "VIEW";
            VIEW.RowHeadersVisible = false;
            VIEW.Size = new Size(348, 150);
            VIEW.TabIndex = 0;
            VIEW.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            VIEW.ThemeStyle.AlternatingRowsStyle.Font = null;
            VIEW.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            VIEW.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            VIEW.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            VIEW.ThemeStyle.BackColor = Color.White;
            VIEW.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            VIEW.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            VIEW.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            VIEW.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            VIEW.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            VIEW.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            VIEW.ThemeStyle.HeaderStyle.Height = 4;
            VIEW.ThemeStyle.ReadOnly = false;
            VIEW.ThemeStyle.RowsStyle.BackColor = Color.White;
            VIEW.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            VIEW.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            VIEW.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            VIEW.ThemeStyle.RowsStyle.Height = 25;
            VIEW.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            VIEW.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            VIEW.CellContentClick += VIEW_CellContentClick;
            // 
            // OKBTN
            // 
            OKBTN.BackColor = Color.Transparent;
            OKBTN.BorderRadius = 20;
            OKBTN.CustomizableEdges = customizableEdges1;
            OKBTN.DisabledState.BorderColor = Color.DarkGray;
            OKBTN.DisabledState.CustomBorderColor = Color.DarkGray;
            OKBTN.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OKBTN.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OKBTN.FillColor = Color.Silver;
            OKBTN.Font = new Font("Segoe UI", 9F);
            OKBTN.ForeColor = Color.Black;
            OKBTN.Location = new Point(137, 249);
            OKBTN.Name = "OKBTN";
            OKBTN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            OKBTN.Size = new Size(127, 35);
            OKBTN.TabIndex = 25;
            OKBTN.Text = "OK";
            OKBTN.Click += OKBTN_Click;
            // 
            // transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 380);
            Controls.Add(OKBTN);
            Controls.Add(VIEW);
            Name = "transaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "transaction";
            ((System.ComponentModel.ISupportInitialize)VIEW).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView VIEW;
        private Guna.UI2.WinForms.Guna2Button OKBTN;
    }
}