using Guna.UI2.WinForms;

namespace Menu_Management
{
    partial class MainForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBox1 = new Guna2PictureBox();
            SidePanel = new Guna2Panel();
            CurrentUser = new Label();
            guna2PictureBox2 = new Guna2PictureBox();
            Exit = new Guna2Button();
            Settings = new Guna2Button();
            Reports = new Guna2Button();
            btnBill = new Guna2Button();
            Home = new Guna2Button();
            MainPanel = new Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges19;
            guna2PictureBox1.Image = Properties.Resources.delicousrestaurantlogo;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(38, 12);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2PictureBox1.Size = new Size(211, 127);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.WhiteSmoke;
            SidePanel.BorderThickness = 1;
            SidePanel.Controls.Add(CurrentUser);
            SidePanel.Controls.Add(guna2PictureBox2);
            SidePanel.Controls.Add(Exit);
            SidePanel.Controls.Add(Settings);
            SidePanel.Controls.Add(Reports);
            SidePanel.Controls.Add(btnBill);
            SidePanel.Controls.Add(Home);
            SidePanel.Controls.Add(guna2PictureBox1);
            SidePanel.CustomizableEdges = customizableEdges33;
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.ShadowDecoration.CustomizableEdges = customizableEdges34;
            SidePanel.Size = new Size(276, 775);
            SidePanel.TabIndex = 0;
            // 
            // CurrentUser
            // 
            CurrentUser.AutoSize = true;
            CurrentUser.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurrentUser.Location = new Point(97, 716);
            CurrentUser.Name = "CurrentUser";
            CurrentUser.Size = new Size(69, 17);
            CurrentUser.TabIndex = 3;
            CurrentUser.Text = "Username";
            // 
            // guna2PictureBox2
            // 
            guna2PictureBox2.CustomizableEdges = customizableEdges21;
            guna2PictureBox2.Image = (Image)resources.GetObject("guna2PictureBox2.Image");
            guna2PictureBox2.ImageRotate = 0F;
            guna2PictureBox2.Location = new Point(38, 696);
            guna2PictureBox2.Name = "guna2PictureBox2";
            guna2PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2PictureBox2.Size = new Size(53, 55);
            guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox2.TabIndex = 2;
            guna2PictureBox2.TabStop = false;
            // 
            // Exit
            // 
            Exit.BorderColor = Color.Empty;
            Exit.BorderRadius = 20;
            Exit.BorderThickness = 2;
            Exit.CheckedState.BorderColor = Color.FromArgb(255, 107, 0);
            Exit.CheckedState.FillColor = Color.WhiteSmoke;
            Exit.CheckedState.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Exit.CheckedState.ForeColor = Color.FromArgb(255, 107, 0);
            Exit.CheckedState.Image = (Image)resources.GetObject("resource.Image");
            Exit.CustomizableEdges = customizableEdges23;
            Exit.DisabledState.BorderColor = Color.DarkGray;
            Exit.DisabledState.CustomBorderColor = Color.DarkGray;
            Exit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Exit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Exit.FillColor = Color.WhiteSmoke;
            Exit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.FromArgb(28, 40, 51);
            Exit.HoverState.BorderColor = Color.FromArgb(255, 162, 80);
            Exit.HoverState.FillColor = Color.WhiteSmoke;
            Exit.HoverState.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Exit.HoverState.ForeColor = Color.FromArgb(255, 162, 80);
            Exit.HoverState.Image = (Image)resources.GetObject("resource.Image1");
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.ImageAlign = HorizontalAlignment.Left;
            Exit.ImageOffset = new Point(15, 0);
            Exit.ImageSize = new Size(25, 25);
            Exit.Location = new Point(38, 375);
            Exit.Name = "Exit";
            Exit.PressedColor = Color.LightGray;
            Exit.ShadowDecoration.CustomizableEdges = customizableEdges24;
            Exit.Size = new Size(211, 45);
            Exit.TabIndex = 1;
            Exit.Text = "Exit";
            Exit.TextAlign = HorizontalAlignment.Left;
            Exit.TextOffset = new Point(20, 0);
            Exit.Click += Exit_Click;
            // 
            // Settings
            // 
            Settings.BorderColor = Color.Empty;
            Settings.BorderRadius = 20;
            Settings.BorderThickness = 2;
            Settings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            Settings.CheckedState.BorderColor = Color.FromArgb(255, 107, 0);
            Settings.CheckedState.FillColor = Color.WhiteSmoke;
            Settings.CheckedState.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Settings.CheckedState.ForeColor = Color.FromArgb(255, 107, 0);
            Settings.CheckedState.Image = (Image)resources.GetObject("resource.Image2");
            Settings.CustomizableEdges = customizableEdges25;
            Settings.DisabledState.BorderColor = Color.DarkGray;
            Settings.DisabledState.CustomBorderColor = Color.DarkGray;
            Settings.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Settings.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Settings.FillColor = Color.WhiteSmoke;
            Settings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Settings.ForeColor = Color.FromArgb(28, 40, 51);
            Settings.HoverState.BorderColor = Color.FromArgb(255, 162, 80);
            Settings.HoverState.FillColor = Color.WhiteSmoke;
            Settings.HoverState.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Settings.HoverState.ForeColor = Color.FromArgb(255, 162, 80);
            Settings.HoverState.Image = (Image)resources.GetObject("resource.Image3");
            Settings.Image = (Image)resources.GetObject("Settings.Image");
            Settings.ImageAlign = HorizontalAlignment.Left;
            Settings.ImageOffset = new Point(15, 0);
            Settings.ImageSize = new Size(25, 25);
            Settings.Location = new Point(38, 324);
            Settings.Name = "Settings";
            Settings.PressedColor = Color.LightGray;
            Settings.ShadowDecoration.CustomizableEdges = customizableEdges26;
            Settings.Size = new Size(211, 45);
            Settings.TabIndex = 1;
            Settings.Text = "Settings";
            Settings.TextAlign = HorizontalAlignment.Left;
            Settings.TextOffset = new Point(20, 0);
            Settings.Click += Settings_Click;
            // 
            // Reports
            // 
            Reports.BorderColor = Color.Empty;
            Reports.BorderRadius = 20;
            Reports.BorderThickness = 2;
            Reports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            Reports.CheckedState.BorderColor = Color.FromArgb(255, 107, 0);
            Reports.CheckedState.FillColor = Color.WhiteSmoke;
            Reports.CheckedState.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Reports.CheckedState.ForeColor = Color.FromArgb(255, 107, 0);
            Reports.CheckedState.Image = (Image)resources.GetObject("resource.Image4");
            Reports.CustomizableEdges = customizableEdges27;
            Reports.DisabledState.BorderColor = Color.DarkGray;
            Reports.DisabledState.CustomBorderColor = Color.DarkGray;
            Reports.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Reports.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Reports.FillColor = Color.WhiteSmoke;
            Reports.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reports.ForeColor = Color.FromArgb(28, 40, 51);
            Reports.HoverState.BorderColor = Color.FromArgb(255, 162, 80);
            Reports.HoverState.FillColor = Color.WhiteSmoke;
            Reports.HoverState.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Reports.HoverState.ForeColor = Color.FromArgb(255, 162, 80);
            Reports.HoverState.Image = (Image)resources.GetObject("resource.Image5");
            Reports.Image = (Image)resources.GetObject("Reports.Image");
            Reports.ImageAlign = HorizontalAlignment.Left;
            Reports.ImageOffset = new Point(15, 0);
            Reports.ImageSize = new Size(25, 25);
            Reports.Location = new Point(38, 273);
            Reports.Name = "Reports";
            Reports.PressedColor = Color.LightGray;
            Reports.ShadowDecoration.CustomizableEdges = customizableEdges28;
            Reports.Size = new Size(211, 45);
            Reports.TabIndex = 1;
            Reports.Text = "Reports";
            Reports.TextAlign = HorizontalAlignment.Left;
            Reports.TextOffset = new Point(20, 0);
            // 
            // btnBill
            // 
            btnBill.BorderColor = Color.Empty;
            btnBill.BorderRadius = 20;
            btnBill.BorderThickness = 2;
            btnBill.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnBill.CheckedState.BorderColor = Color.FromArgb(255, 107, 0);
            btnBill.CheckedState.FillColor = Color.WhiteSmoke;
            btnBill.CheckedState.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBill.CheckedState.ForeColor = Color.FromArgb(255, 107, 0);
            btnBill.CheckedState.Image = (Image)resources.GetObject("resource.Image6");
            btnBill.CustomizableEdges = customizableEdges29;
            btnBill.DisabledState.BorderColor = Color.DarkGray;
            btnBill.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBill.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBill.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBill.FillColor = Color.WhiteSmoke;
            btnBill.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBill.ForeColor = Color.FromArgb(28, 40, 51);
            btnBill.HoverState.BorderColor = Color.FromArgb(255, 162, 80);
            btnBill.HoverState.FillColor = Color.WhiteSmoke;
            btnBill.HoverState.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBill.HoverState.ForeColor = Color.FromArgb(255, 162, 80);
            btnBill.HoverState.Image = (Image)resources.GetObject("resource.Image7");
            btnBill.Image = (Image)resources.GetObject("btnBill.Image");
            btnBill.ImageAlign = HorizontalAlignment.Left;
            btnBill.ImageOffset = new Point(15, 0);
            btnBill.ImageSize = new Size(25, 25);
            btnBill.Location = new Point(38, 222);
            btnBill.Name = "btnBill";
            btnBill.PressedColor = Color.LightGray;
            btnBill.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnBill.Size = new Size(211, 45);
            btnBill.TabIndex = 1;
            btnBill.Text = "Bill";
            btnBill.TextAlign = HorizontalAlignment.Left;
            btnBill.TextOffset = new Point(20, 0);
            btnBill.Click += btnBill_Click;
            // 
            // Home
            // 
            Home.BorderColor = Color.Empty;
            Home.BorderRadius = 20;
            Home.BorderThickness = 2;
            Home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            Home.Checked = true;
            Home.CheckedState.BorderColor = Color.FromArgb(255, 107, 0);
            Home.CheckedState.FillColor = Color.WhiteSmoke;
            Home.CheckedState.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Home.CheckedState.ForeColor = Color.FromArgb(255, 107, 0);
            Home.CheckedState.Image = (Image)resources.GetObject("resource.Image8");
            Home.CustomizableEdges = customizableEdges31;
            Home.DisabledState.BorderColor = Color.DarkGray;
            Home.DisabledState.CustomBorderColor = Color.DarkGray;
            Home.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Home.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Home.FillColor = Color.WhiteSmoke;
            Home.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Home.ForeColor = Color.FromArgb(28, 40, 51);
            Home.HoverState.BorderColor = Color.FromArgb(255, 162, 80);
            Home.HoverState.FillColor = Color.WhiteSmoke;
            Home.HoverState.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Home.HoverState.ForeColor = Color.FromArgb(255, 162, 80);
            Home.HoverState.Image = (Image)resources.GetObject("resource.Image9");
            Home.Image = (Image)resources.GetObject("Home.Image");
            Home.ImageAlign = HorizontalAlignment.Left;
            Home.ImageOffset = new Point(15, 0);
            Home.ImageSize = new Size(25, 25);
            Home.Location = new Point(38, 171);
            Home.Name = "Home";
            Home.PressedColor = Color.LightGray;
            Home.ShadowDecoration.CustomizableEdges = customizableEdges32;
            Home.Size = new Size(211, 45);
            Home.TabIndex = 1;
            Home.Text = "Home";
            Home.TextAlign = HorizontalAlignment.Left;
            Home.TextOffset = new Point(20, 0);
            Home.Click += Home_Click;
            // 
            // MainPanel
            // 
            MainPanel.CustomizableEdges = customizableEdges35;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(276, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.ShadowDecoration.CustomizableEdges = customizableEdges36;
            MainPanel.Size = new Size(974, 775);
            MainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1250, 775);
            Controls.Add(MainPanel);
            Controls.Add(SidePanel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button Home;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private Guna.UI2.WinForms.Guna2Button Reports;
        private Guna.UI2.WinForms.Guna2Button Exit;
        private Label CurrentUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna2Panel SidePanel;
        private Guna2Button btnBill;
    }
}