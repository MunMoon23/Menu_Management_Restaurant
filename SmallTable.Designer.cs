namespace Menu_Management
{
    partial class SmallTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            table = new Guna.UI2.WinForms.Guna2Panel();
            NumberGuest = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ResevDate = new Label();
            CusName = new Label();
            TableStatus = new Label();
            TableLable = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            table.SuspendLayout();
            SuspendLayout();
            // 
            // table
            // 
            table.BackColor = SystemColors.Control;
            table.BorderColor = Color.White;
            table.BorderRadius = 30;
            table.BorderThickness = 2;
            table.Controls.Add(NumberGuest);
            table.Controls.Add(guna2Panel1);
            table.Controls.Add(ResevDate);
            table.Controls.Add(CusName);
            table.Controls.Add(TableStatus);
            table.Controls.Add(TableLable);
            table.CustomizableEdges = customizableEdges9;
            table.FillColor = Color.LightGray;
            table.Location = new Point(40, 3);
            table.Name = "table";
            table.ShadowDecoration.CustomizableEdges = customizableEdges10;
            table.Size = new Size(116, 140);
            table.TabIndex = 8;
            // 
            // NumberGuest
            // 
            NumberGuest.AutoSize = true;
            NumberGuest.BackColor = Color.Transparent;
            NumberGuest.Location = new Point(3, 90);
            NumberGuest.Name = "NumberGuest";
            NumberGuest.Size = new Size(98, 15);
            NumberGuest.TabIndex = 2;
            NumberGuest.Text = "Number of Guest";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 30;
            customizableEdges7.BottomLeft = false;
            customizableEdges7.BottomRight = false;
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.FillColor = Color.FromArgb(128, 255, 128);
            guna2Panel1.Location = new Point(3, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(113, 33);
            guna2Panel1.TabIndex = 6;
            // 
            // ResevDate
            // 
            ResevDate.AutoSize = true;
            ResevDate.BackColor = Color.Transparent;
            ResevDate.Location = new Point(2, 60);
            ResevDate.Name = "ResevDate";
            ResevDate.Size = new Size(107, 15);
            ResevDate.TabIndex = 2;
            ResevDate.Text = "Reseve date + time";
            // 
            // CusName
            // 
            CusName.AutoSize = true;
            CusName.BackColor = Color.Transparent;
            CusName.Location = new Point(3, 75);
            CusName.Name = "CusName";
            CusName.Size = new Size(94, 15);
            CusName.TabIndex = 2;
            CusName.Text = "Customer Name";
            // 
            // TableStatus
            // 
            TableStatus.AutoSize = true;
            TableStatus.BackColor = Color.Transparent;
            TableStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableStatus.ForeColor = Color.Lime;
            TableStatus.Location = new Point(3, 105);
            TableStatus.Name = "TableStatus";
            TableStatus.Size = new Size(73, 21);
            TableStatus.TabIndex = 1;
            TableStatus.Text = "Available";
            // 
            // TableLable
            // 
            TableLable.AutoSize = true;
            TableLable.BackColor = Color.Transparent;
            TableLable.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TableLable.Location = new Point(82, 39);
            TableLable.Name = "TableLable";
            TableLable.Size = new Size(25, 21);
            TableLable.TabIndex = 1;
            TableLable.Text = "T1";
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = SystemColors.Control;
            guna2Panel2.BorderColor = Color.White;
            guna2Panel2.BorderRadius = 25;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.CustomizableEdges = customizableEdges11;
            guna2Panel2.FillColor = Color.LightGray;
            guna2Panel2.Location = new Point(0, 43);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel2.Size = new Size(200, 71);
            guna2Panel2.TabIndex = 9;
            // 
            // SmallTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(table);
            Controls.Add(guna2Panel2);
            Name = "SmallTable";
            Size = new Size(202, 147);
            table.ResumeLayout(false);
            table.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel table;
        private Label NumberGuest;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label ResevDate;
        private Label CusName;
        private Label TableStatus;
        private Label TableLable;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
