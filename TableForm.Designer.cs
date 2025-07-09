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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            SeachTB = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label3 = new Label();
            label2 = new Label();
            popuppanel = new Panel();
            button1 = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            panel1.SuspendLayout();
            popuppanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("VNI-Disney", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 27);
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
            // popuppanel
            // 
            popuppanel.Controls.Add(guna2DateTimePicker1);
            popuppanel.Controls.Add(button1);
            popuppanel.Controls.Add(label7);
            popuppanel.Controls.Add(textBox2);
            popuppanel.Controls.Add(label6);
            popuppanel.Controls.Add(textBox1);
            popuppanel.Controls.Add(label5);
            popuppanel.Controls.Add(label4);
            popuppanel.Location = new Point(496, -5);
            popuppanel.Name = "popuppanel";
            popuppanel.Size = new Size(332, 790);
            popuppanel.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(89, 415);
            button1.Name = "button1";
            button1.Size = new Size(139, 42);
            button1.TabIndex = 8;
            button1.Text = "xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 272);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 5;
            label7.Text = "ngày được đặt";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(99, 23);
            textBox2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 182);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 5;
            label6.Text = "số lượng người";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 99);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 5;
            label5.Text = "Tên người đặt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("VNI-Disney", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 32);
            label4.Name = "label4";
            label4.Size = new Size(106, 39);
            label4.TabIndex = 4;
            label4.Text = "TABLES";
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges3;
            guna2DateTimePicker1.Font = new Font("Segoe UI", 9F);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(35, 303);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2DateTimePicker1.Size = new Size(272, 29);
            guna2DateTimePicker1.TabIndex = 9;
            guna2DateTimePicker1.Value = new DateTime(2025, 7, 9, 12, 20, 37, 456);
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 817);
            Controls.Add(popuppanel);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(SeachTB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TableForm";
            Text = "TableForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            popuppanel.ResumeLayout(false);
            popuppanel.PerformLayout();
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
        private Panel popuppanel;
        private Label label4;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}