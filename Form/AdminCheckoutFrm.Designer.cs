namespace Menu_Management
{
    partial class AdminCheckoutFrm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Shift = new Guna.UI2.WinForms.Guna2HtmlLabel();
            StartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            EndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ReportItemWise = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // Shift
            // 
            Shift.BackColor = Color.Transparent;
            Shift.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Shift.Location = new Point(54, 39);
            Shift.Name = "Shift";
            Shift.Size = new Size(102, 27);
            Shift.TabIndex = 1;
            Shift.Text = "Checkout";
            // 
            // StartDate
            // 
            StartDate.Checked = true;
            StartDate.CustomizableEdges = customizableEdges1;
            StartDate.Font = new Font("Segoe UI", 9F);
            StartDate.Format = DateTimePickerFormat.Long;
            StartDate.Location = new Point(133, 124);
            StartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            StartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            StartDate.Name = "StartDate";
            StartDate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            StartDate.Size = new Size(215, 60);
            StartDate.TabIndex = 2;
            StartDate.Value = new DateTime(2025, 7, 20, 21, 10, 13, 286);
            // 
            // EndDate
            // 
            EndDate.Checked = true;
            EndDate.CustomizableEdges = customizableEdges3;
            EndDate.Font = new Font("Segoe UI", 9F);
            EndDate.Format = DateTimePickerFormat.Long;
            EndDate.Location = new Point(510, 124);
            EndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            EndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            EndDate.Name = "EndDate";
            EndDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            EndDate.Size = new Size(215, 60);
            EndDate.TabIndex = 3;
            EndDate.Value = new DateTime(2025, 7, 20, 21, 10, 13, 286);
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 14.25F);
            guna2HtmlLabel1.Location = new Point(133, 82);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(86, 27);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Start Date";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 14.25F);
            guna2HtmlLabel2.Location = new Point(510, 89);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(79, 27);
            guna2HtmlLabel2.TabIndex = 5;
            guna2HtmlLabel2.Text = "End Date";
            // 
            // ReportItemWise
            // 
            ReportItemWise.CustomizableEdges = customizableEdges5;
            ReportItemWise.Font = new Font("Segoe UI", 9F);
            ReportItemWise.ForeColor = Color.White;
            ReportItemWise.Location = new Point(133, 252);
            ReportItemWise.Name = "ReportItemWise";
            ReportItemWise.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ReportItemWise.Size = new Size(180, 45);
            ReportItemWise.TabIndex = 0;
            ReportItemWise.Text = "Report";
            ReportItemWise.Click += ReportItemWise_Click;
            // 
            // AdminCheckoutFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 632);
            Controls.Add(ReportItemWise);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(EndDate);
            Controls.Add(StartDate);
            Controls.Add(Shift);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminCheckoutFrm";
            Text = "AdminCheckoutFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Shift;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button ReportItemWise;
    }
}