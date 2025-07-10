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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)ShiftGridview).BeginInit();
            SuspendLayout();
            // 
            // Shift
            // 
            Shift.BackColor = Color.Transparent;
            Shift.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Shift.Location = new Point(41, 52);
            Shift.Name = "Shift";
            Shift.Size = new Size(68, 27);
            Shift.TabIndex = 0;
            Shift.Text = "SHIFT";
            // 
            // ShiftGridview
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ShiftGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ShiftGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ShiftGridview.ColumnHeadersHeight = 17;
            ShiftGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ShiftGridview.Columns.AddRange(new DataGridViewColumn[] { Mon, Tue, Wed, Thus, Fri, Sat, Sun });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ShiftGridview.DefaultCellStyle = dataGridViewCellStyle3;
            ShiftGridview.GridColor = Color.FromArgb(231, 229, 255);
            ShiftGridview.Location = new Point(41, 92);
            ShiftGridview.Name = "ShiftGridview";
            ShiftGridview.RowHeadersVisible = false;
            ShiftGridview.Size = new Size(666, 150);
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
            FShift.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FShift.Location = new Point(41, 268);
            FShift.Name = "FShift";
            FShift.Size = new Size(148, 27);
            FShift.TabIndex = 0;
            FShift.Text = "Finished Shift";
            // 
            // FShiftStat
            // 
            FShiftStat.AutoSize = true;
            FShiftStat.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FShiftStat.Location = new Point(249, 272);
            FShiftStat.Name = "FShiftStat";
            FShiftStat.Size = new Size(83, 30);
            FShiftStat.TabIndex = 2;
            FShiftStat.Text = "28 days";
            // 
            // ChangeMenuBtn
            // 
            ChangeMenuBtn.BorderRadius = 20;
            customizableEdges1.TopRight = false;
            ChangeMenuBtn.CustomizableEdges = customizableEdges1;
            ChangeMenuBtn.DisabledState.BorderColor = Color.DarkGray;
            ChangeMenuBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ChangeMenuBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ChangeMenuBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ChangeMenuBtn.FillColor = Color.FromArgb(238, 140, 33);
            ChangeMenuBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangeMenuBtn.ForeColor = Color.White;
            ChangeMenuBtn.Location = new Point(327, 413);
            ChangeMenuBtn.Name = "ChangeMenuBtn";
            ChangeMenuBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ChangeMenuBtn.Size = new Size(180, 45);
            ChangeMenuBtn.TabIndex = 3;
            ChangeMenuBtn.Text = "Change menu item";
            ChangeMenuBtn.Click += ChangeMenuBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BorderRadius = 20;
            customizableEdges3.TopRight = false;
            ExitBtn.CustomizableEdges = customizableEdges3;
            ExitBtn.DisabledState.BorderColor = Color.DarkGray;
            ExitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ExitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExitBtn.FillColor = Color.FromArgb(26, 29, 30);
            ExitBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = Color.White;
            ExitBtn.Location = new Point(527, 413);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ExitBtn.Size = new Size(180, 45);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Back";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(41, 338);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(150, 27);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "LATE ARRIVE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 341);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 2;
            label1.Text = "4 days";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            customizableEdges5.TopRight = false;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(238, 140, 33);
            guna2Button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(141, 413);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "Admin Checkout";
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 485);
            Controls.Add(ExitBtn);
            Controls.Add(guna2Button1);
            Controls.Add(ChangeMenuBtn);
            Controls.Add(label1);
            Controls.Add(FShiftStat);
            Controls.Add(ShiftGridview);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(FShift);
            Controls.Add(Shift);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Setting";
            Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)ShiftGridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}