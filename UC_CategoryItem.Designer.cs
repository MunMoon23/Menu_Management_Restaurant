namespace Menu_Management
{
    partial class UC_CategoryItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CategoryItem));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            CategoryImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            CategoryLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(CategoryImage);
            panel1.Controls.Add(CategoryLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(11, 13, 0, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 137);
            panel1.TabIndex = 4;
            panel1.MouseLeave += panel1_MouseLeave;
            panel1.MouseHover += panel1_MouseHover;
            // 
            // CategoryImage
            // 
            CategoryImage.Anchor = AnchorStyles.None;
            CategoryImage.BackColor = Color.Transparent;
            CategoryImage.Image = (Image)resources.GetObject("CategoryImage.Image");
            CategoryImage.ImageRotate = 0F;
            CategoryImage.Location = new Point(24, 4);
            CategoryImage.Margin = new Padding(3, 4, 3, 4);
            CategoryImage.Name = "CategoryImage";
            CategoryImage.ShadowDecoration.CustomizableEdges = customizableEdges1;
            CategoryImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CategoryImage.Size = new Size(80, 80);
            CategoryImage.SizeMode = PictureBoxSizeMode.StretchImage;
            CategoryImage.TabIndex = 4;
            CategoryImage.TabStop = false;
            CategoryImage.Click += CategoryImage_Click;
            CategoryImage.MouseLeave += CategoryImage_MouseLeave;
            CategoryImage.MouseHover += CategoryImage_MouseHover;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Dock = DockStyle.Bottom;
            CategoryLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryLabel.Location = new Point(0, 102);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(126, 33);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Breakfast";
            CategoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            CategoryLabel.Click += CategoryLabel_Click;
            CategoryLabel.MouseLeave += CategoryLabel_MouseLeave;
            CategoryLabel.MouseHover += CategoryLabel_MouseHover;
            // 
            // UC_CategoryItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_CategoryItem";
            Size = new Size(128, 137);
            Click += UC_CategoryItem_Click;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CategoryImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CategoryImage;
        private Label CategoryLabel;
    }
}
