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
            label1 = new Label();
            SeachTB = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 687);
            panel1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(427, 81);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(319, 409);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Table 1", "Table 2", "Table 5", "Table 7", "Table 12", "Table 16", "Table 20", "Table 21", "Table 22", "Table 23" });
            listBox1.Location = new Point(23, 81);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 409);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(241, 25);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 0;
            label3.Text = "10/30";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 25);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 0;
            label2.Text = "số bàn còn lại";
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 817);
            Controls.Add(panel1);
            Controls.Add(SeachTB);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TableForm";
            Text = "TableForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox SeachTB;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private ListBox listBox2;
        private ListBox listBox1;
    }
}