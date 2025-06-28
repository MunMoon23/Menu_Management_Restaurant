namespace Menu_Management
{
    partial class TablesForm
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
            tablesItems1 = new TablesItems();
            tablesItems2 = new TablesItems();
            tablesItems3 = new TablesItems();
            smallTable1 = new SmallTable();
            smallTable2 = new SmallTable();
            smallTable3 = new SmallTable();
            smallTable4 = new SmallTable();
            smallTable5 = new SmallTable();
            smallTable6 = new SmallTable();
            label1 = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // tablesItems1
            // 
            tablesItems1.Location = new Point(12, 75);
            tablesItems1.Name = "tablesItems1";
            tablesItems1.Size = new Size(208, 299);
            tablesItems1.TabIndex = 0;
            // 
            // tablesItems2
            // 
            tablesItems2.Location = new Point(12, 393);
            tablesItems2.Name = "tablesItems2";
            tablesItems2.Size = new Size(208, 299);
            tablesItems2.TabIndex = 0;
            // 
            // tablesItems3
            // 
            tablesItems3.Location = new Point(485, 75);
            tablesItems3.Name = "tablesItems3";
            tablesItems3.Size = new Size(208, 299);
            tablesItems3.TabIndex = 0;
            tablesItems3.Load += tablesItems3_Load;
            // 
            // smallTable1
            // 
            smallTable1.Location = new Point(263, 75);
            smallTable1.Name = "smallTable1";
            smallTable1.Size = new Size(199, 141);
            smallTable1.TabIndex = 1;
            // 
            // smallTable2
            // 
            smallTable2.Location = new Point(263, 222);
            smallTable2.Name = "smallTable2";
            smallTable2.Size = new Size(199, 141);
            smallTable2.TabIndex = 1;
            // 
            // smallTable3
            // 
            smallTable3.Location = new Point(263, 551);
            smallTable3.Name = "smallTable3";
            smallTable3.Size = new Size(199, 141);
            smallTable3.TabIndex = 1;
            // 
            // smallTable4
            // 
            smallTable4.Location = new Point(263, 379);
            smallTable4.Name = "smallTable4";
            smallTable4.Size = new Size(199, 141);
            smallTable4.TabIndex = 1;
            // 
            // smallTable5
            // 
            smallTable5.Location = new Point(494, 551);
            smallTable5.Name = "smallTable5";
            smallTable5.Size = new Size(199, 141);
            smallTable5.TabIndex = 1;
            // 
            // smallTable6
            // 
            smallTable6.Location = new Point(494, 379);
            smallTable6.Name = "smallTable6";
            smallTable6.Size = new Size(199, 141);
            smallTable6.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 23);
            label1.Name = "label1";
            label1.Size = new Size(110, 45);
            label1.TabIndex = 2;
            label1.Text = "Tables";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.Gray;
            guna2TextBox1.BorderRadius = 20;
            guna2TextBox1.BorderThickness = 2;
            customizableEdges1.BottomLeft = false;
            customizableEdges1.TopRight = false;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.MistyRose;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.ForeColor = Color.White;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(388, 25);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "find guest";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(255, 36);
            guna2TextBox1.TabIndex = 3;
            // 
            // TablesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 719);
            Controls.Add(guna2TextBox1);
            Controls.Add(label1);
            Controls.Add(smallTable6);
            Controls.Add(smallTable5);
            Controls.Add(smallTable4);
            Controls.Add(smallTable3);
            Controls.Add(smallTable2);
            Controls.Add(smallTable1);
            Controls.Add(tablesItems3);
            Controls.Add(tablesItems2);
            Controls.Add(tablesItems1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TablesForm";
            Text = "Tables";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TablesItems tablesItems1;
        private TablesItems tablesItems2;
        private TablesItems tablesItems3;
        private SmallTable smallTable1;
        private SmallTable smallTable2;
        private SmallTable smallTable3;
        private SmallTable smallTable4;
        private SmallTable smallTable5;
        private SmallTable smallTable6;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}