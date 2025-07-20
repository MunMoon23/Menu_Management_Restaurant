namespace Menu_Management
{
    partial class Setting
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Shift = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ShiftGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            Mon = new DataGridViewTextBoxColumn();
            Tue = new DataGridViewTextBoxColumn();
            Wed = new DataGridViewTextBoxColumn();
            Thus = new DataGridViewTextBoxColumn();
            Fri = new DataGridViewTextBoxColumn();
            Sat = new DataGridViewTextBoxColumn();
            Sun = new DataGridViewTextBoxColumn();
            FShift = new Guna.UI2.WinForms.Guna2HtmlLabel();
            FShiftStat = new Label();
            ChangeMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            AdminCheckOut = new Guna.UI2.WinForms.Guna2Button();
            MainPanel = new Panel();
            AddEmployee = new Guna.UI2.WinForms.Guna2Button();
            ChangePassbtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)ShiftGridview).BeginInit();
            MainPanel.SuspendLayout();

            // 
            // Shift
            // 
            Shift.BackColor = Color.Transparent;
            Shift.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Shift.Location = new Point(41, 70);
            Shift.Name = "Shift";
            Shift.Size = new Size(78, 39);
            Shift.TabIndex = 0;
            Shift.Text = "SHIFT";
            // 
            // ShiftGridview
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            ShiftGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ShiftGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ShiftGridview.ColumnHeadersHeight = 17;
            ShiftGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ShiftGridview.Columns.AddRange(new DataGridViewColumn[] { Mon, Tue, Wed, Thus, Fri, Sat, Sun });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ShiftGridview.DefaultCellStyle = dataGridViewCellStyle6;
            ShiftGridview.GridColor = Color.FromArgb(231, 229, 255);
            ShiftGridview.Location = new Point(41, 127);
            ShiftGridview.Name = "ShiftGridview";
            ShiftGridview.RowHeadersVisible = false;
            ShiftGridview.Size = new Size(876, 274);
            ShiftGridview.TabIndex = 1;
            ShiftGridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ShiftGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            ShiftGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ShiftGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ShiftGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ShiftGridview.ThemeStyle.BackColor = Color.White;
            ShiftGridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ShiftGridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ShiftGridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ShiftGridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            ShiftGridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ShiftGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ShiftGridview.ThemeStyle.HeaderStyle.Height = 17;
            ShiftGridview.ThemeStyle.ReadOnly = false;
            ShiftGridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            ShiftGridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ShiftGridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ShiftGridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ShiftGridview.ThemeStyle.RowsStyle.Height = 25;
            ShiftGridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ShiftGridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Mon
            // 
            Mon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Mon.HeaderText = "Monday";
            Mon.Name = "Mon";
            Mon.Width = 95;
            // 
            // Tue
            // 
            Tue.HeaderText = "Tuesday";
            Tue.Name = "Tue";
            // 
            // Wed
            // 
            Wed.HeaderText = "Wednesday";
            Wed.Name = "Wed";
            // 
            // Thus
            // 
            Thus.HeaderText = "Thusday";
            Thus.Name = "Thus";
            // 
            // Fri
            // 
            Fri.HeaderText = "Friday";
            Fri.Name = "Fri";
            // 
            // Sat
            // 
            Sat.HeaderText = "Saturday";
            Sat.Name = "Sat";
            // 
            // Sun
            // 
            Sun.HeaderText = "Sunday";
            Sun.Name = "Sun";
            // 
            // FShift
            // 
            FShift.BackColor = Color.Transparent;
            FShift.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FShift.Location = new Point(41, 461);
            FShift.Name = "FShift";
            FShift.Size = new Size(150, 32);
            FShift.TabIndex = 0;
            FShift.Text = "Finished Shift :";
            // 
            // FShiftStat
            // 
            FShiftStat.AutoSize = true;
            FShiftStat.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FShiftStat.Location = new Point(238, 461);
            FShiftStat.Name = "FShiftStat";
            FShiftStat.Size = new Size(83, 30);
            FShiftStat.TabIndex = 2;
            FShiftStat.Text = "28 days";
            // 
            // ChangeMenuBtn
            // 
            ChangeMenuBtn.BorderRadius = 20;
            customizableEdges11.TopRight = false;
            ChangeMenuBtn.CustomizableEdges = customizableEdges11;
            ChangeMenuBtn.DisabledState.BorderColor = Color.DarkGray;
            ChangeMenuBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ChangeMenuBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ChangeMenuBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ChangeMenuBtn.FillColor = Color.FromArgb(255, 107, 0);
            ChangeMenuBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangeMenuBtn.ForeColor = Color.FromArgb(28, 40, 51);
            ChangeMenuBtn.Image = (Image)resources.GetObject("ChangeMenuBtn.Image");
            ChangeMenuBtn.ImageSize = new Size(35, 35);
            ChangeMenuBtn.Location = new Point(528, 690);
            ChangeMenuBtn.Name = "ChangeMenuBtn";
            ChangeMenuBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
            ChangeMenuBtn.Size = new Size(180, 45);
            ChangeMenuBtn.TabIndex = 3;
            ChangeMenuBtn.Text = "Change Menu Item";
            ChangeMenuBtn.Click += ChangeMenuBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BorderRadius = 20;
            customizableEdges13.BottomRight = false;
            ExitBtn.CustomizableEdges = customizableEdges13;
            ExitBtn.DisabledState.BorderColor = Color.DarkGray;
            ExitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ExitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExitBtn.FillColor = Color.FromArgb(28, 40, 51);
            ExitBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ExitBtn.ForeColor = Color.FromArgb(255, 107, 0);
            ExitBtn.Image = (Image)resources.GetObject("ExitBtn.Image");
            ExitBtn.ImageSize = new Size(25, 25);
            ExitBtn.Location = new Point(737, 76);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            ExitBtn.Size = new Size(180, 45);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Back";
            ExitBtn.Click += ExitBtn_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(41, 531);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(121, 32);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Late Arrive :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 533);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 2;
            label1.Text = "4 days";
            // 
            // AdminCheckOut
            // 
            AdminCheckOut.BorderRadius = 20;
            customizableEdges15.TopRight = false;
            AdminCheckOut.CustomizableEdges = customizableEdges15;
            AdminCheckOut.DisabledState.BorderColor = Color.DarkGray;
            AdminCheckOut.DisabledState.CustomBorderColor = Color.DarkGray;
            AdminCheckOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AdminCheckOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AdminCheckOut.FillColor = Color.FromArgb(255, 107, 0);
            AdminCheckOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminCheckOut.ForeColor = Color.FromArgb(28, 40, 51);
            AdminCheckOut.Location = new Point(116, 690);
            AdminCheckOut.Name = "AdminCheckOut";
            AdminCheckOut.ShadowDecoration.CustomizableEdges = customizableEdges16;
            AdminCheckOut.Size = new Size(180, 45);
            AdminCheckOut.TabIndex = 3;
            AdminCheckOut.Text = "Admin Checkout";
            AdminCheckOut.Click += AdminCheckOut_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(AddEmployee);
            MainPanel.Controls.Add(Shift);
            MainPanel.Controls.Add(ShiftGridview);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(ExitBtn);
            MainPanel.Controls.Add(FShiftStat);
            MainPanel.Controls.Add(AdminCheckOut);
            MainPanel.Controls.Add(guna2HtmlLabel1);
            MainPanel.Controls.Add(ChangePassbtn);
            MainPanel.Controls.Add(ChangeMenuBtn);
            MainPanel.Controls.Add(FShift);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(974, 775);
            MainPanel.TabIndex = 4;
            // 
            // AddEmployee
            // 
            AddEmployee.BorderRadius = 20;
            customizableEdges17.TopRight = false;
            AddEmployee.CustomizableEdges = customizableEdges17;
            AddEmployee.DisabledState.BorderColor = Color.DarkGray;
            AddEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            AddEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddEmployee.FillColor = Color.FromArgb(255, 107, 0);
            AddEmployee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            AddEmployee.ForeColor = Color.FromArgb(28, 40, 51);
            AddEmployee.Image = (Image)resources.GetObject("AddEmployee.Image");
            AddEmployee.ImageSize = new Size(40, 40);
            AddEmployee.Location = new Point(322, 690);
            AddEmployee.Name = "AddEmployee";
            AddEmployee.ShadowDecoration.CustomizableEdges = customizableEdges18;
            AddEmployee.Size = new Size(180, 45);
            AddEmployee.TabIndex = 4;
            AddEmployee.Text = "Add Employee";
            AddEmployee.Click += AddEmployee_Click;
            // 
            // ChangePassbtn
            // 
            ChangePassbtn.BorderRadius = 20;
            customizableEdges19.TopRight = false;
            ChangePassbtn.CustomizableEdges = customizableEdges19;
            ChangePassbtn.DisabledState.BorderColor = Color.DarkGray;
            ChangePassbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ChangePassbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ChangePassbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ChangePassbtn.FillColor = Color.FromArgb(255, 107, 0);
            ChangePassbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangePassbtn.ForeColor = Color.FromArgb(28, 40, 51);
            ChangePassbtn.Image = (Image)resources.GetObject("ChangePassbtn.Image");
            ChangePassbtn.ImageSize = new Size(35, 35);
            ChangePassbtn.Location = new Point(734, 690);
            ChangePassbtn.Name = "ChangePassbtn";
            ChangePassbtn.ShadowDecoration.CustomizableEdges = customizableEdges20;
            ChangePassbtn.Size = new Size(180, 45);
            ChangePassbtn.TabIndex = 3;
            ChangePassbtn.Text = "Change Password";
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 775);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Setting";
            Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)ShiftGridview).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Shift;
        private Guna.UI2.WinForms.Guna2DataGridView ShiftGridview;
        private DataGridViewTextBoxColumn Mon;
        private DataGridViewTextBoxColumn Tue;
        private DataGridViewTextBoxColumn Wed;
        private DataGridViewTextBoxColumn Thus;
        private DataGridViewTextBoxColumn Fri;
        private DataGridViewTextBoxColumn Sat;
        private DataGridViewTextBoxColumn Sun;
        private Guna.UI2.WinForms.Guna2HtmlLabel FShift;
        private Label FShiftStat;
        private Guna.UI2.WinForms.Guna2Button ChangeMenuBtn;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button AdminCheckOut;
        private Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Button AddEmployee;
        private Guna.UI2.WinForms.Guna2Button ChangePassbtn;
    }
}