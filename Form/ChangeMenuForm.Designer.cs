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
            panel1 = new Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel2 = new Panel();
            ShowData = new DataGridView();
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
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 775);
            panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(52, 47);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(171, 27);
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
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 775);
            panel2.TabIndex = 4;
            // 
            // ShowData
            // 
            ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowData.Location = new Point(21, 325);
            ShowData.Name = "ShowData";
            ShowData.Size = new Size(664, 376);
            ShowData.TabIndex = 7;
            ShowData.SelectionChanged += ShowData_SelectionChanged;
            // 
            // CategoryCBB
            // 
            CategoryCBB.FormattingEnabled = true;
            CategoryCBB.Location = new Point(49, 194);
            CategoryCBB.Name = "CategoryCBB";
            CategoryCBB.Size = new Size(204, 23);
            CategoryCBB.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox);
            panel3.Location = new Point(717, 194);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 230);
            panel3.TabIndex = 5;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(214, 224);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // Browse
            // 
            Browse.Font = new Font("Microsoft Sans Serif", 14.25F);
            Browse.Location = new Point(747, 446);
            Browse.Name = "Browse";
            Browse.Size = new Size(133, 58);
            Browse.TabIndex = 4;
            Browse.Text = "Tìm kiếm";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Font = new Font("Microsoft Sans Serif", 14.25F);
            RemoveBtn.Location = new Point(873, 568);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(85, 40);
            RemoveBtn.TabIndex = 4;
            RemoveBtn.Text = "Xóa";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AlterBtn
            // 
            AlterBtn.Font = new Font("Microsoft Sans Serif", 14.25F);
            AlterBtn.Location = new Point(782, 568);
            AlterBtn.Name = "AlterBtn";
            AlterBtn.Size = new Size(85, 40);
            AlterBtn.TabIndex = 4;
            AlterBtn.Text = "Sửa";
            AlterBtn.UseVisualStyleBackColor = true;
            AlterBtn.Click += AlterBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Microsoft Sans Serif", 14.25F);
            AddBtn.Location = new Point(691, 568);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(85, 40);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Thêm";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DishIdTxt
            // 
            DishIdTxt.Location = new Point(343, 194);
            DishIdTxt.Name = "DishIdTxt";
            DishIdTxt.Size = new Size(179, 23);
            DishIdTxt.TabIndex = 3;
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(352, 296);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(179, 23);
            PriceTxt.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F);
            label5.Location = new Point(343, 150);
            label5.Name = "label5";
            label5.Size = new Size(32, 24);
            label5.TabIndex = 2;
            label5.Text = "ID ";
            label5.Click += label3_Click;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(49, 296);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(179, 23);
            NameTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.Location = new Point(352, 252);
            label3.Name = "label3";
            label3.Size = new Size(38, 24);
            label3.TabIndex = 2;
            label3.Text = "Giá";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.Location = new Point(717, 151);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 2;
            label2.Text = "Hình ảnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 150);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 2;
            label4.Text = "danh mục";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.Location = new Point(49, 252);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
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
        private Panel panel3;
        private Button RemoveBtn;
        private Button AlterBtn;
        private Button AddBtn;
        private ComboBox CategoryCBB;
        private Label label4;
        private Button Browse;
        private DataGridView ShowData;
        private TextBox DishIdTxt;
        private Label label5;
        private PictureBox pictureBox;
    }
}