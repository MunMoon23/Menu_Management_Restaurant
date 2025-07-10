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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMenuForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel2 = new Panel();
            CategoryCBB = new ComboBox();
            panel3 = new Panel();
            Browse = new Button();
            RemoveBtn = new Button();
            AlterBtn = new Button();
            AddBtn = new Button();
            PriceTxt = new TextBox();
            NameTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            SearchBar.CustomizableEdges = customizableEdges5;
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
            SearchBar.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            panel2.Controls.Add(CategoryCBB);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(Browse);
            panel2.Controls.Add(RemoveBtn);
            panel2.Controls.Add(AlterBtn);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(PriceTxt);
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
            // CategoryCBB
            // 
            CategoryCBB.FormattingEnabled = true;
            CategoryCBB.Location = new Point(334, 129);
            CategoryCBB.Name = "CategoryCBB";
            CategoryCBB.Size = new Size(204, 23);
            CategoryCBB.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Location = new Point(626, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 230);
            panel3.TabIndex = 5;
            // 
            // Browse
            // 
            Browse.Location = new Point(656, 364);
            Browse.Name = "Browse";
            Browse.Size = new Size(133, 58);
            Browse.TabIndex = 4;
            Browse.Text = "Tìm kiếm";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += RemoveBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(224, 364);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(85, 40);
            RemoveBtn.TabIndex = 4;
            RemoveBtn.Text = "Xóa";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AlterBtn
            // 
            AlterBtn.Location = new Point(133, 364);
            AlterBtn.Name = "AlterBtn";
            AlterBtn.Size = new Size(85, 40);
            AlterBtn.TabIndex = 4;
            AlterBtn.Text = "Sửa";
            AlterBtn.UseVisualStyleBackColor = true;
            AlterBtn.Click += AlterBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(42, 364);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(85, 40);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Thêm";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(52, 260);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(179, 23);
            PriceTxt.TabIndex = 3;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(52, 129);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(179, 23);
            NameTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 214);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "Giá";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(626, 76);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Hình ảnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 85);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 2;
            label4.Text = "danh mục";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 85);
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
    }
}