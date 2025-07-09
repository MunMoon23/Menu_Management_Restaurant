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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            SeachTB = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            VacanTable = new ListBox();
            AvailableTable = new ListBox();
            AvailableUpdate = new Label();
            label2 = new Label();
            popuppanel = new Panel();
            ExitPopup = new Guna.UI2.WinForms.Guna2CircleButton();
            vacantAccept = new Button();
            DateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            Accept = new Button();
            label7 = new Label();
            NumberOrderTxt = new TextBox();
            label6 = new Label();
            NameTxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
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
            customizableEdges6.TopRight = false;
            SeachTB.CustomizableEdges = customizableEdges6;
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
            SeachTB.ShadowDecoration.CustomizableEdges = customizableEdges7;
            SeachTB.Size = new Size(200, 36);
            SeachTB.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(VacanTable);
            panel1.Controls.Add(AvailableTable);
            panel1.Controls.Add(AvailableUpdate);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 687);
            panel1.TabIndex = 6;
            // 
            // VacanTable
            // 
            VacanTable.FormattingEnabled = true;
            VacanTable.Location = new Point(427, 81);
            VacanTable.Name = "VacanTable";
            VacanTable.Size = new Size(319, 409);
            VacanTable.TabIndex = 1;
            VacanTable.SelectedIndexChanged += VacanTable_SelectedIndexChanged;
            // 
            // AvailableTable
            // 
            AvailableTable.FormattingEnabled = true;
            AvailableTable.Items.AddRange(new object[] { "Table 1", "Table 2", "Table 5", "Table 7", "Table 12", "Table 16", "Table 20", "Table 21", "Table 22", "Table 23" });
            AvailableTable.Location = new Point(23, 81);
            AvailableTable.Name = "AvailableTable";
            AvailableTable.Size = new Size(319, 409);
            AvailableTable.TabIndex = 1;
            AvailableTable.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // AvailableUpdate
            // 
            AvailableUpdate.AutoSize = true;
            AvailableUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailableUpdate.Location = new Point(241, 25);
            AvailableUpdate.Name = "AvailableUpdate";
            AvailableUpdate.Size = new Size(59, 25);
            AvailableUpdate.TabIndex = 0;
            AvailableUpdate.Text = "10/30";
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
            popuppanel.Controls.Add(ExitPopup);
            popuppanel.Controls.Add(vacantAccept);
            popuppanel.Controls.Add(DateTime);
            popuppanel.Controls.Add(Accept);
            popuppanel.Controls.Add(label7);
            popuppanel.Controls.Add(NumberOrderTxt);
            popuppanel.Controls.Add(label6);
            popuppanel.Controls.Add(NameTxt);
            popuppanel.Controls.Add(label5);
            popuppanel.Controls.Add(label4);
            popuppanel.Location = new Point(496, -5);
            popuppanel.Name = "popuppanel";
            popuppanel.Size = new Size(332, 790);
            popuppanel.TabIndex = 7;
            // 
            // ExitPopup
            // 
            ExitPopup.DisabledState.BorderColor = Color.DarkGray;
            ExitPopup.DisabledState.CustomBorderColor = Color.DarkGray;
            ExitPopup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExitPopup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExitPopup.FillColor = Color.Silver;
            ExitPopup.Font = new Font("Segoe UI", 9F);
            ExitPopup.ForeColor = Color.White;
            ExitPopup.Location = new Point(20, 32);
            ExitPopup.Name = "ExitPopup";
            ExitPopup.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ExitPopup.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ExitPopup.Size = new Size(50, 39);
            ExitPopup.TabIndex = 11;
            ExitPopup.Text = "<--";
            ExitPopup.Click += ExitPopup_Click;
            // 
            // vacantAccept
            // 
            vacantAccept.Location = new Point(89, 415);
            vacantAccept.Name = "vacantAccept";
            vacantAccept.Size = new Size(139, 42);
            vacantAccept.TabIndex = 10;
            vacantAccept.Text = "accept";
            vacantAccept.UseVisualStyleBackColor = true;
            vacantAccept.Click += vacantAccept_Click;
            // 
            // DateTime
            // 
            DateTime.Checked = true;
            DateTime.CustomizableEdges = customizableEdges9;
            DateTime.Font = new Font("Segoe UI", 9F);
            DateTime.Format = DateTimePickerFormat.Long;
            DateTime.Location = new Point(35, 303);
            DateTime.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateTime.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateTime.Name = "DateTime";
            DateTime.ShadowDecoration.CustomizableEdges = customizableEdges10;
            DateTime.Size = new Size(272, 29);
            DateTime.TabIndex = 9;
            DateTime.Value = new DateTime(2025, 7, 9, 12, 20, 37, 456);
            // 
            // Accept
            // 
            Accept.Location = new Point(89, 415);
            Accept.Name = "Accept";
            Accept.Size = new Size(139, 42);
            Accept.TabIndex = 8;
            Accept.Text = "xác nhận";
            Accept.UseVisualStyleBackColor = true;
            Accept.Click += button1_Click;
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
            // NumberOrderTxt
            // 
            NumberOrderTxt.Location = new Point(42, 214);
            NumberOrderTxt.Name = "NumberOrderTxt";
            NumberOrderTxt.Size = new Size(99, 23);
            NumberOrderTxt.TabIndex = 6;
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
            // NameTxt
            // 
            NameTxt.Location = new Point(42, 131);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(256, 23);
            NameTxt.TabIndex = 6;
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
            label4.Location = new Point(103, 32);
            label4.Name = "label4";
            label4.Size = new Size(106, 39);
            label4.TabIndex = 4;
            label4.Text = "TABLES";
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
        private Label AvailableUpdate;
        private ListBox VacanTable;
        private ListBox AvailableTable;
        private Panel popuppanel;
        private Label label4;
        private Label label7;
        private TextBox NumberOrderTxt;
        private Label label6;
        private TextBox NameTxt;
        private Label label5;
        private Button Accept;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTime;
        private Button vacantAccept;
        private Guna.UI2.WinForms.Guna2CircleButton ExitPopup;
    }
}