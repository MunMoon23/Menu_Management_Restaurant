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
            panel1 = new Panel();
            SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel2 = new Panel();
            ShowData = new DataGridView();
            DishID = new DataGridViewTextBoxColumn();
            DishName = new DataGridViewTextBoxColumn();
            CategoryID = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            DishIMG = new DataGridViewTextBoxColumn();
            CategoryCBB = new ComboBox();
            panel3 = new Panel();
            pictureBox = new PictureBox();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowData).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SearchBar);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 775);
            panel1.TabIndex = 0;
            // 
            // SearchBar
            // 
            SearchBar.BorderRadius = 20;
            SearchBar.BorderThickness = 0;
            SearchBar.CustomizableEdges = customizableEdges1;
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
            SearchBar.Location = new Point(264, 47);
            SearchBar.Margin = new Padding(4);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderForeColor = Color.Silver;
            SearchBar.PlaceholderText = "Search dish";
            SearchBar.SelectedText = "";
            SearchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchBar.Size = new Size(385, 45);
            SearchBar.TabIndex = 10;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font(".VnBook-AntiquaH", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(52, 47);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(179, 34);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "CHANGE MENU";
            // 
            // panel2
            // 
            panel2.Controls.Add(ShowData);
            panel2.Controls.Add(CategoryCBB);
            panel2.Controls.Add(panel3);
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
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 657);
            panel2.TabIndex = 4;
            // 
            // ShowData
            // 
            ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowData.Columns.AddRange(new DataGridViewColumn[] { DishID, DishName, CategoryID, Price, DishIMG });
            ShowData.Location = new Point(3, 278);
            ShowData.Name = "ShowData";
            ShowData.Size = new Size(664, 376);
            ShowData.TabIndex = 7;
            ShowData.SelectionChanged += ShowData_SelectionChanged;
            // 
            // DishID
            // 
            DishID.HeaderText = "Dish ID";
            DishID.Name = "DishID";
            // 
            // DishName
            // 
            DishName.HeaderText = "Dish Name";
            DishName.Name = "DishName";
            // 
            // CategoryID
            // 
            CategoryID.HeaderText = " Category ID";
            CategoryID.Name = "CategoryID";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // DishIMG
            // 
            DishIMG.HeaderText = "Dish Image";
            DishIMG.Name = "DishIMG";
            // 
            // CategoryCBB
            // 
            CategoryCBB.FormattingEnabled = true;
            CategoryCBB.Location = new Point(52, 128);
            CategoryCBB.Name = "CategoryCBB";
            CategoryCBB.Size = new Size(204, 23);
            CategoryCBB.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox);
            panel3.Location = new Point(720, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 230);
            panel3.TabIndex = 5;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(214, 224);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // Browse
            // 
            Browse.Location = new Point(750, 380);
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
            DishIdTxt.Location = new Point(346, 128);
            DishIdTxt.Name = "DishIdTxt";
            DishIdTxt.Size = new Size(179, 23);
            DishIdTxt.TabIndex = 3;
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(355, 230);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(179, 23);
            PriceTxt.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 84);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 2;
            label5.Text = "ID ";
            label5.Click += label3_Click;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(52, 230);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(179, 23);
            NameTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 186);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "Giá";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(720, 85);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Hình ảnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 84);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 2;
            label4.Text = "danh mục";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 186);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Tên món";
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShowData).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox NameTxt;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label2;
        private TextBox PriceTxt;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Panel panel3;
        private Button RemoveBtn;
        private Button AlterBtn;
        private Button AddBtn;
        private ComboBox CategoryCBB;
        private Label label4;
        private Button Browse;
        private DataGridView ShowData;
        private DataGridViewTextBoxColumn DishID;
        private DataGridViewTextBoxColumn DishName;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn DishIMG;
        private TextBox DishIdTxt;
        private Label label5;
        private PictureBox pictureBox;
    }
}