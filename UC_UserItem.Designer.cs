namespace Menu_Management
{
    partial class UC_UserItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UserItem));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            RoleLabel = new Label();
            GenderLabel = new Label();
            RoleValue = new Label();
            GenderValue = new Label();
            FullnameValue = new Label();
            FullnameLabel = new Label();
            panel2 = new Panel();
            UsernameValue = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(RoleLabel);
            panel1.Controls.Add(GenderLabel);
            panel1.Controls.Add(RoleValue);
            panel1.Controls.Add(GenderValue);
            panel1.Controls.Add(FullnameValue);
            panel1.Controls.Add(FullnameLabel);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 300);
            panel1.TabIndex = 0;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoleLabel.ForeColor = Color.FromArgb(255, 107, 0);
            RoleLabel.Location = new Point(27, 261);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(47, 21);
            RoleLabel.TabIndex = 1;
            RoleLabel.Text = "Role:";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenderLabel.ForeColor = Color.FromArgb(255, 107, 0);
            GenderLabel.Location = new Point(27, 217);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(69, 21);
            GenderLabel.TabIndex = 1;
            GenderLabel.Text = "Gender:";
            // 
            // RoleValue
            // 
            RoleValue.AutoSize = true;
            RoleValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleValue.ForeColor = Color.DarkRed;
            RoleValue.Location = new Point(134, 261);
            RoleValue.Name = "RoleValue";
            RoleValue.Size = new Size(77, 21);
            RoleValue.TabIndex = 1;
            RoleValue.Text = "Unknown";
            // 
            // GenderValue
            // 
            GenderValue.AutoSize = true;
            GenderValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderValue.ForeColor = Color.Black;
            GenderValue.Location = new Point(134, 217);
            GenderValue.Name = "GenderValue";
            GenderValue.Size = new Size(77, 21);
            GenderValue.TabIndex = 1;
            GenderValue.Text = "Unknown";
            // 
            // FullnameValue
            // 
            FullnameValue.AutoSize = true;
            FullnameValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullnameValue.ForeColor = Color.Black;
            FullnameValue.Location = new Point(134, 174);
            FullnameValue.Name = "FullnameValue";
            FullnameValue.Size = new Size(77, 21);
            FullnameValue.TabIndex = 1;
            FullnameValue.Text = "Unknown";
            // 
            // FullnameLabel
            // 
            FullnameLabel.AutoSize = true;
            FullnameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullnameLabel.ForeColor = Color.FromArgb(255, 107, 0);
            FullnameLabel.Location = new Point(27, 174);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(86, 21);
            FullnameLabel.TabIndex = 1;
            FullnameLabel.Text = "Full Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 40, 51);
            panel2.Controls.Add(UsernameValue);
            panel2.Controls.Add(guna2CirclePictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 151);
            panel2.TabIndex = 0;
            // 
            // UsernameValue
            // 
            UsernameValue.AutoSize = true;
            UsernameValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameValue.ForeColor = Color.FromArgb(255, 107, 0);
            UsernameValue.Location = new Point(134, 114);
            UsernameValue.Name = "UsernameValue";
            UsernameValue.Size = new Size(86, 21);
            UsernameValue.TabIndex = 1;
            UsernameValue.Text = "UserName";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(125, 16);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(100, 95);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // UC_UserItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_UserItem";
            Size = new Size(350, 300);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private Label RoleLabel;
        private Label GenderLabel;
        private Label FullnameLabel;
        private Panel panel2;
        private Label UsernameValue;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label RoleValue;
        private Label GenderValue;
        private Label FullnameValue;
    }
}
