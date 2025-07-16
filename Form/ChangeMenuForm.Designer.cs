namespace Menu_Management
{
    partial class ChangeMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMenuForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel2 = new Panel();
            pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ShowData = new DataGridView();
            CategoryCBB = new ComboBox();
            Browse = new Button();
            RemoveBtn = new Button();
            AlterBtn = new Button();
            AddBtn = new Button();
            DishIdTxt = new TextBox();
            PriceTxt = new TextBox();
            label5 = new Label();
            NameTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShowData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Controls.Add(SearchBar);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 775);
            panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(24, 12);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(66, 61);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 11;
            guna2PictureBox1.TabStop = false;
            // 
            // SearchBar
            // 
            SearchBar.BorderRadius = 20;
            SearchBar.BorderThickness = 0;
            SearchBar.CustomizableEdges = customizableEdges3;
            SearchBar.DefaultText = "";
            SearchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchBar.FillColor = Color.FromArgb(224, 224, 224);
            SearchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchBar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchBar.IconRight = (Image)resources.GetObject("SearchBar.IconRight");
            SearchBar.IconRightSize = new Size(36, 36);
            SearchBar.Location = new Point(576, 20);
            SearchBar.Margin = new Padding(4);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderForeColor = Color.Silver;
            SearchBar.PlaceholderText = "Search dish";
            SearchBar.SelectedText = "";
            SearchBar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SearchBar.Size = new Size(385, 45);
            SearchBar.TabIndex = 10;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(28, 40, 51);
            guna2HtmlLabel1.Location = new Point(96, 26);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(135, 32);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Change Menu";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox);
            panel2.Controls.Add(ShowData);
            panel2.Controls.Add(CategoryCBB);
            panel2.Controls.Add(Browse);
            panel2.Controls.Add(RemoveBtn);
            panel2.Controls.Add(AlterBtn);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(DishIdTxt);
            panel2.Controls.Add(PriceTxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(NameTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 683);
            panel2.TabIndex = 4;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.CustomizableEdges = customizableEdges5;
            pictureBox.ImageRotate = 0F;
            pictureBox.Location = new Point(720, 117);
            pictureBox.Name = "pictureBox";
            pictureBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pictureBox.Size = new Size(220, 230);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 8;
            pictureBox.TabStop = false;
            pictureBox.Click += Browse_Click;
            // 
            // ShowData
            // 
            ShowData.AllowUserToOrderColumns = true;
            ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowData.Location = new Point(24, 219);
            ShowData.Name = "ShowData";
            ShowData.Size = new Size(664, 452);
            ShowData.TabIndex = 7;
            ShowData.SelectionChanged += ShowData_SelectionChanged;
            // 
            // CategoryCBB
            // 
            CategoryCBB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryCBB.FormattingEnabled = true;
            CategoryCBB.Location = new Point(27, 56);
            CategoryCBB.Name = "CategoryCBB";
            CategoryCBB.Size = new Size(204, 29);
            CategoryCBB.TabIndex = 6;
            // 
            // Browse
            // 
            Browse.Location = new Point(768, 378);
            Browse.Name = "Browse";
            Browse.Size = new Size(133, 58);
            Browse.TabIndex = 4;
            Browse.Text = "Tìm kiếm";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(876, 502);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(85, 40);
            RemoveBtn.TabIndex = 4;
            RemoveBtn.Text = "Xóa";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AlterBtn
            // 
            AlterBtn.Location = new Point(785, 502);
            AlterBtn.Name = "AlterBtn";
            AlterBtn.Size = new Size(85, 40);
            AlterBtn.TabIndex = 4;
            AlterBtn.Text = "Sửa";
            AlterBtn.UseVisualStyleBackColor = true;
            AlterBtn.Click += AlterBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(694, 502);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(85, 40);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Thêm";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DishIdTxt
            // 
            DishIdTxt.Font = new Font("Segoe UI", 12F);
            DishIdTxt.Location = new Point(346, 56);
            DishIdTxt.Name = "DishIdTxt";
            DishIdTxt.Size = new Size(110, 29);
            DishIdTxt.TabIndex = 3;
            // 
            // PriceTxt
            // 
            PriceTxt.Font = new Font("Segoe UI", 12F);
            PriceTxt.Location = new Point(346, 155);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(204, 29);
            PriceTxt.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(346, 22);
            label5.Name = "label5";
            label5.Size = new Size(30, 21);
            label5.TabIndex = 2;
            label5.Text = "ID ";
            label5.Click += label3_Click;
            // 
            // NameTxt
            // 
            NameTxt.Font = new Font("Segoe UI", 12F);
            NameTxt.Location = new Point(27, 155);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(204, 29);
            NameTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(343, 117);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 2;
            label3.Text = "Price";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(793, 83);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 2;
            label2.Text = "Picture";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 22);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 2;
            label4.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(27, 117);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // ChangeMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 775);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeMenuForm";
            Text = "ChangeMenuForm";
            Load += ChangeMenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShowData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox NameTxt;
        private Label label1;
        private Label label2;
        private TextBox PriceTxt;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Button RemoveBtn;
        private Button AlterBtn;
        private Button AddBtn;
        private ComboBox CategoryCBB;
        private Label label4;
        private Button Browse;
        private DataGridView ShowData;
        private TextBox DishIdTxt;
        private Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
    }
}