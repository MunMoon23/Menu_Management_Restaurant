namespace Menu_Management
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            RegBanner = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            User = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            Password = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            RegButton = new Guna.UI2.WinForms.Guna2Button();
            GotoLogin = new LinkLabel();
            label4 = new Label();
            ConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)RegBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // RegBanner
            // 
            RegBanner.CustomizableEdges = customizableEdges25;
            RegBanner.Dock = DockStyle.Left;
            RegBanner.Image = Properties.Resources.registerPicture2;
            RegBanner.ImageRotate = 0F;
            RegBanner.Location = new Point(0, 0);
            RegBanner.Margin = new Padding(3, 4, 3, 4);
            RegBanner.Name = "RegBanner";
            RegBanner.ShadowDecoration.CustomizableEdges = customizableEdges26;
            RegBanner.Size = new Size(469, 803);
            RegBanner.TabIndex = 0;
            RegBanner.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Logo
            // 
            Logo.CustomizableEdges = customizableEdges35;
            Logo.Image = Properties.Resources.delicousrestaurantlogo;
            Logo.ImageRotate = 0F;
            Logo.Location = new Point(1014, 0);
            Logo.Margin = new Padding(3, 4, 3, 4);
            Logo.Name = "Logo";
            Logo.ShadowDecoration.CustomizableEdges = customizableEdges36;
            Logo.Size = new Size(181, 167);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(549, 156);
            label1.Name = "label1";
            label1.Size = new Size(116, 37);
            label1.TabIndex = 2;
            label1.Text = "Register";
            // 
            // User
            // 
            User.BackColor = Color.White;
            User.BorderRadius = 10;
            User.CustomizableEdges = customizableEdges33;
            User.DefaultText = "";
            User.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            User.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            User.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            User.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            User.FillColor = Color.WhiteSmoke;
            User.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            User.Font = new Font("Segoe UI", 9F);
            User.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            User.Location = new Point(559, 291);
            User.Margin = new Padding(3, 5, 3, 5);
            User.Name = "User";
            User.PlaceholderText = "Enter your username";
            User.SelectedText = "";
            User.ShadowDecoration.CustomizableEdges = customizableEdges34;
            User.Size = new Size(555, 60);
            User.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(559, 247);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // Password
            // 
            Password.BackColor = Color.White;
            Password.BorderRadius = 10;
            Password.CustomizableEdges = customizableEdges31;
            Password.DefaultText = "";
            Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Password.FillColor = Color.WhiteSmoke;
            Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Password.Font = new Font("Segoe UI", 9F);
            Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Password.Location = new Point(559, 407);
            Password.Margin = new Padding(3, 5, 3, 5);
            Password.Name = "Password";
            Password.PlaceholderText = "Your password";
            Password.SelectedText = "";
            Password.ShadowDecoration.CustomizableEdges = customizableEdges32;
            Password.Size = new Size(555, 60);
            Password.TabIndex = 3;
            Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(559, 363);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // RegButton
            // 
            RegButton.BorderRadius = 10;
            RegButton.CustomizableEdges = customizableEdges27;
            RegButton.DisabledState.BorderColor = Color.DarkGray;
            RegButton.DisabledState.CustomBorderColor = Color.DarkGray;
            RegButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RegButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RegButton.FillColor = Color.FromArgb(255, 107, 0);
            RegButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegButton.ForeColor = Color.White;
            RegButton.Location = new Point(559, 663);
            RegButton.Margin = new Padding(3, 4, 3, 4);
            RegButton.Name = "RegButton";
            RegButton.ShadowDecoration.CustomizableEdges = customizableEdges28;
            RegButton.Size = new Size(555, 65);
            RegButton.TabIndex = 5;
            RegButton.Text = "Register";
            RegButton.Click += RegButton_Click;
            // 
            // GotoLogin
            // 
            GotoLogin.AutoSize = true;
            GotoLogin.LinkColor = Color.FromArgb(255, 107, 0);
            GotoLogin.Location = new Point(879, 755);
            GotoLogin.Name = "GotoLogin";
            GotoLogin.Size = new Size(82, 20);
            GotoLogin.TabIndex = 6;
            GotoLogin.TabStop = true;
            GotoLogin.Text = "Login Here";
            GotoLogin.LinkClicked += GotoLogin_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(720, 752);
            label4.Name = "label4";
            label4.Size = new Size(153, 23);
            label4.TabIndex = 7;
            label4.Text = "Have an Account? ";
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.BackColor = Color.White;
            ConfirmPassword.BorderRadius = 10;
            ConfirmPassword.CustomizableEdges = customizableEdges29;
            ConfirmPassword.DefaultText = "";
            ConfirmPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ConfirmPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ConfirmPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ConfirmPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ConfirmPassword.FillColor = Color.WhiteSmoke;
            ConfirmPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ConfirmPassword.Font = new Font("Segoe UI", 9F);
            ConfirmPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            ConfirmPassword.Location = new Point(559, 536);
            ConfirmPassword.Margin = new Padding(3, 5, 3, 5);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.PlaceholderText = "Confirm password";
            ConfirmPassword.SelectedText = "";
            ConfirmPassword.ShadowDecoration.CustomizableEdges = customizableEdges30;
            ConfirmPassword.Size = new Size(555, 60);
            ConfirmPassword.TabIndex = 3;
            ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(559, 492);
            label5.Name = "label5";
            label5.Size = new Size(170, 28);
            label5.TabIndex = 4;
            label5.Text = "Confirm password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1208, 803);
            Controls.Add(label4);
            Controls.Add(GotoLogin);
            Controls.Add(RegButton);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ConfirmPassword);
            Controls.Add(Password);
            Controls.Add(User);
            Controls.Add(label1);
            Controls.Add(Logo);
            Controls.Add(RegBanner);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)RegBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox RegBanner;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox User;
        private Label label1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2Button RegButton;
        private Label label4;
        private LinkLabel GotoLogin;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPassword;
    }
}
