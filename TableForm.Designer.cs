namespace Menu_Management
{
    partial class TableForm
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
            longTable1 = new LongTable();
            longTable2 = new LongTable();
            sideWayTable1 = new SideWayTable();
            smallTable1 = new SmallTable();
            smallTable2 = new SmallTable();
            smallTable3 = new SmallTable();
            smallTable4 = new SmallTable();
            sideWayTable2 = new SideWayTable();
            smallTable5 = new SmallTable();
            label1 = new Label();
            SeachTB = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // longTable1
            // 
            longTable1.Location = new Point(54, 99);
            longTable1.Name = "longTable1";
            longTable1.Size = new Size(205, 254);
            longTable1.TabIndex = 0;
            // 
            // longTable2
            // 
            longTable2.Location = new Point(553, 522);
            longTable2.Name = "longTable2";
            longTable2.Size = new Size(205, 254);
            longTable2.TabIndex = 0;
            // 
            // sideWayTable1
            // 
            sideWayTable1.Location = new Point(23, 522);
            sideWayTable1.Name = "sideWayTable1";
            sideWayTable1.Size = new Size(292, 231);
            sideWayTable1.TabIndex = 1;
            // 
            // smallTable1
            // 
            smallTable1.Location = new Point(54, 359);
            smallTable1.Name = "smallTable1";
            smallTable1.Size = new Size(202, 147);
            smallTable1.TabIndex = 2;
            // 
            // smallTable2
            // 
            smallTable2.Location = new Point(556, 359);
            smallTable2.Name = "smallTable2";
            smallTable2.Size = new Size(202, 147);
            smallTable2.TabIndex = 2;
            // 
            // smallTable3
            // 
            smallTable3.Location = new Point(320, 359);
            smallTable3.Name = "smallTable3";
            smallTable3.Size = new Size(202, 147);
            smallTable3.TabIndex = 2;
            // 
            // smallTable4
            // 
            smallTable4.Location = new Point(333, 568);
            smallTable4.Name = "smallTable4";
            smallTable4.Size = new Size(202, 147);
            smallTable4.TabIndex = 2;
            // 
            // sideWayTable2
            // 
            sideWayTable2.Location = new Point(465, 99);
            sideWayTable2.Name = "sideWayTable2";
            sideWayTable2.Size = new Size(293, 232);
            sideWayTable2.TabIndex = 3;
            // 
            // smallTable5
            // 
            smallTable5.Location = new Point(265, 143);
            smallTable5.Name = "smallTable5";
            smallTable5.Size = new Size(202, 147);
            smallTable5.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("VNI-Disney", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 42);
            label1.Name = "label1";
            label1.Size = new Size(106, 39);
            label1.TabIndex = 4;
            label1.Text = "TABLES";
            // 
            // SeachTB
            // 
            SeachTB.BackColor = Color.Transparent;
            SeachTB.BorderRadius = 20;
            customizableEdges1.TopRight = false;
            SeachTB.CustomizableEdges = customizableEdges1;
            SeachTB.DefaultText = "";
            SeachTB.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SeachTB.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SeachTB.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SeachTB.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SeachTB.FillColor = Color.FromArgb(255, 192, 128);
            SeachTB.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SeachTB.Font = new Font("Segoe UI", 9F);
            SeachTB.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SeachTB.Location = new Point(505, 45);
            SeachTB.Name = "SeachTB";
            SeachTB.PlaceholderText = "Find Guest";
            SeachTB.SelectedText = "";
            SeachTB.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SeachTB.Size = new Size(200, 36);
            SeachTB.TabIndex = 5;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 817);
            Controls.Add(SeachTB);
            Controls.Add(label1);
            Controls.Add(sideWayTable2);
            Controls.Add(smallTable4);
            Controls.Add(smallTable5);
            Controls.Add(smallTable3);
            Controls.Add(smallTable2);
            Controls.Add(smallTable1);
            Controls.Add(sideWayTable1);
            Controls.Add(longTable2);
            Controls.Add(longTable1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TableForm";
            Text = "TableForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LongTable longTable1;
        private LongTable longTable2;
        private SideWayTable sideWayTable1;
        private SmallTable smallTable1;
        private SmallTable smallTable2;
        private SmallTable smallTable3;
        private SmallTable smallTable4;
        private SideWayTable sideWayTable2;
        private SmallTable smallTable5;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox SeachTB;
    }
}